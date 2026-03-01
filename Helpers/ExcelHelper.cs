using System.Data;
using System.IO;
using MiniExcelLibs;

namespace Custom.HydrogenConfigurationSystem.Helpers
{
    public class ExcelHelper
    {
        /// <summary>
        /// 导入Excel或CSV文件为DataTable
        /// </summary>
        public static DataTable Import(string filePath, string? sheetName = null)
        {
            var dt = new DataTable();
            if (Path.GetExtension(filePath).ToLower() == ".csv")
            {
                LoadCsvToDataTable(filePath, dt);
            }
            else
            {
                LoadXlsxToDataTable(filePath, dt, sheetName);
            }
            return dt;
        }

        /// <summary>
        /// 从CSV文件加载数据到DataTable
        /// </summary>
        private static void LoadCsvToDataTable(string filePath, DataTable dt)
        {
            var lines = File.ReadAllLines(filePath);
            if (lines.Length == 0) return;

            var headers = ParseCsvLine(lines[0]);
            foreach (var header in headers)
            {
                dt.Columns.Add(header.Trim());
            }

            for (int i = 1; i < lines.Length; i++)
            {
                var values = ParseCsvLine(lines[i]);
                var row = dt.NewRow();
                for (int j = 0; j < values.Count && j < dt.Columns.Count; j++)
                {
                    row[j] = values[j].Trim();
                }
                dt.Rows.Add(row);
            }
        }

        /// <summary>
        /// 解析CSV行（处理引号包裹的字段）
        /// </summary>
        private static List<string> ParseCsvLine(string line)
        {
            var result = new List<string>();
            var current = new System.Text.StringBuilder();
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                if (c == '"')
                {
                    if (inQuotes && i + 1 < line.Length && line[i + 1] == '"')
                    {
                        current.Append('"');
                        i++;
                    }
                    else
                    {
                        inQuotes = !inQuotes;
                    }
                }
                else if (c == ',' && !inQuotes)
                {
                    result.Add(current.ToString());
                    current.Clear();
                }
                else
                {
                    current.Append(c);
                }
            }
            result.Add(current.ToString());
            return result;
        }

        /// <summary>
        /// 从Excel文件加载数据到DataTable
        /// </summary>
        private static void LoadXlsxToDataTable(string filePath, DataTable dt, string? sheetName = null)
        {
            var data = MiniExcel.Query(filePath, sheetName: sheetName).ToList();
            if (data.Count == 0) return;

            var firstItem = data[0] as IDictionary<string, object>;
            if (firstItem != null)
            {
                foreach (var key in firstItem.Keys)
                {
                    dt.Columns.Add(key);
                }

                foreach (var item in data)
                {
                    var row = dt.NewRow();
                    var dict = item as IDictionary<string, object>;
                    if (dict != null)
                    {
                        foreach (var key in dict.Keys)
                        {
                            if (dt.Columns.Contains(key))
                            {
                                row[key] = dict[key] ?? DBNull.Value;
                            }
                        }
                    }
                    dt.Rows.Add(row);
                }
            }
        }

        /// <summary>
        /// 导出DataTable到Excel或CSV文件
        /// </summary>
        public static bool Export(string filePath, DataTable dt, string? sheetName = null)
        {
            try
            {
                LogHelper.Info($"开始导出DataTable到: {filePath}, 行数: {dt?.Rows.Count ?? 0}");

                var path = Path.GetDirectoryName(filePath);
                if (!string.IsNullOrEmpty(path) && !Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    LogHelper.Info($"创建目录: {path}");
                }

                var extension = Path.GetExtension(filePath).ToLower();
                if (extension == ".csv")
                {
                    ExportDataTableToCsv(filePath, dt);
                    LogHelper.Info("CSV导出成功");
                }
                else if (extension == ".xlsx")
                {
                    ExportDataTableToXlsx(filePath, dt, sheetName);
                    LogHelper.Info("Excel导出成功");
                }
                else
                {
                    LogHelper.Error($"不支持的文件格式: {extension}");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.Error($"Excel导出失败: {ex.Message}\n堆栈跟踪: {ex.StackTrace}");
                return false;
            }
        }

        /// <summary>
        /// 将DataTable导出为CSV文件
        /// </summary>
        private static void ExportDataTableToCsv(string filePath, DataTable dt)
        {
            var lines = new List<string>();

            // 写入表头
            var headers = dt.Columns.Cast<DataColumn>().Select(c => EscapeCsvField(c.ColumnName));
            lines.Add(string.Join(",", headers));

            // 写入数据行
            foreach (DataRow row in dt.Rows)
            {
                var values = row.ItemArray.Select(item => EscapeCsvField(item?.ToString() ?? ""));
                lines.Add(string.Join(",", values));
            }

            File.WriteAllLines(filePath, lines, System.Text.Encoding.UTF8);
        }

        /// <summary>
        /// 转义CSV字段（处理逗号、引号和换行）
        /// </summary>
        private static string EscapeCsvField(string field)
        {
            if (string.IsNullOrEmpty(field))
                return "";

            // 如果字段包含逗号、引号或换行符，需要用引号包裹
            if (field.Contains(",") || field.Contains("\"") || field.Contains("\n") || field.Contains("\r"))
            {
                // 将字段中的引号替换为两个引号
                field = field.Replace("\"", "\"\"");
                field = "\"" + field + "\"";
            }
            return field;
        }

        /// <summary>
        /// 将DataTable导出为Excel文件（使用MiniExcel）
        /// </summary>
        private static void ExportDataTableToXlsx(string filePath, DataTable dt, string? sheetName = null)
        {
            // 将DataTable转换为匿名对象列表，这是MiniExcel推荐的方式
            var data = new List<Dictionary<string, object?>>();

            foreach (DataRow row in dt.Rows)
            {
                var dict = new Dictionary<string, object?>();
                foreach (DataColumn col in dt.Columns)
                {
                    var value = row[col];
                    // 将DBNull.Value转换为null，MiniExcel处理更好
                    dict[col.ColumnName] = value == DBNull.Value ? null : value;
                }
                data.Add(dict);
            }

            // 使用MiniExcel保存，不指定sheetName时使用默认名称
            if (string.IsNullOrEmpty(sheetName))
            {
                MiniExcel.SaveAs(filePath, data);
            }
            else
            {
                MiniExcel.SaveAs(filePath, data, sheetName: sheetName);
            }
        }

        /// <summary>
        /// 导入Excel文件为强类型列表
        /// </summary>
        public static List<T> Import<T>(string filePath, string? sheetName = null) where T : class, new()
        {
            try
            {
                return MiniExcel.Query<T>(filePath, sheetName: sheetName).ToList();
            }
            catch (Exception ex)
            {
                LogHelper.Error($"Excel导入失败: {ex.Message}");
                return new List<T>();
            }
        }

        /// <summary>
        /// 导出强类型列表到Excel或CSV文件
        /// </summary>
        public static bool Export<T>(string filePath, List<T> data, string? sheetName = null) where T : class, new()
        {
            try
            {
                LogHelper.Info($"开始导出数据到: {filePath}, 数据量: {data?.Count ?? 0}");

                var path = Path.GetDirectoryName(filePath);
                if (!string.IsNullOrEmpty(path) && !Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    LogHelper.Info($"创建目录: {path}");
                }

                var extension = Path.GetExtension(filePath).ToLower();
                LogHelper.Info($"文件扩展名: {extension}");

                if (extension == ".csv")
                {
                    ExportListToCsv(filePath, data);
                    LogHelper.Info("CSV导出成功");
                }
                else if (extension == ".xlsx")
                {
                    ExportListToXlsx(filePath, data, sheetName);
                    LogHelper.Info("Excel导出成功");
                }
                else
                {
                    LogHelper.Error($"不支持的文件格式: {extension}");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.Error($"Excel导出失败: {ex.Message}\n堆栈跟踪: {ex.StackTrace}");
                return false;
            }
        }

        /// <summary>
        /// 将强类型列表导出为CSV文件
        /// </summary>
        private static void ExportListToCsv<T>(string filePath, List<T> data) where T : class, new()
        {
            var lines = new List<string>();

            if (data == null || data.Count == 0)
            {
                File.WriteAllLines(filePath, lines, System.Text.Encoding.UTF8);
                return;
            }

            var firstItem = data[0];
            var properties = firstItem.GetType().GetProperties()
                .Where(p => p.CanRead)
                .ToArray();

            if (properties.Length == 0)
            {
                File.WriteAllLines(filePath, lines, System.Text.Encoding.UTF8);
                return;
            }

            // 写入表头
            var headers = properties.Select(p => EscapeCsvField(p.Name));
            lines.Add(string.Join(",", headers));

            // 写入数据行
            foreach (var item in data)
            {
                var values = properties.Select(p =>
                {
                    try
                    {
                        var value = p.GetValue(item);
                        return EscapeCsvField(value?.ToString() ?? "");
                    }
                    catch
                    {
                        return "";
                    }
                });
                lines.Add(string.Join(",", values));
            }

            File.WriteAllLines(filePath, lines, System.Text.Encoding.UTF8);
        }

        /// <summary>
        /// 将强类型列表导出为Excel文件
        /// </summary>
        private static void ExportListToXlsx<T>(string filePath, List<T> data, string? sheetName = null) where T : class, new()
        {
            if (data == null || data.Count == 0)
            {
                // 导出空列表时创建一个空Excel
                MiniExcel.SaveAs(filePath, new List<T>(), sheetName: sheetName);
                return;
            }

            // 直接使用MiniExcel的泛型导出功能，这是最可靠的方式
            if (string.IsNullOrEmpty(sheetName))
            {
                MiniExcel.SaveAs(filePath, data);
            }
            else
            {
                MiniExcel.SaveAs(filePath, data, sheetName: sheetName);
            }
        }

        /// <summary>
        /// 将DataTable导出为内存流（用于直接下载）
        /// </summary>
        public static MemoryStream ExportToStream(DataTable dt, string? sheetName = null)
        {
            var data = new List<Dictionary<string, object?>>();

            foreach (DataRow row in dt.Rows)
            {
                var dict = new Dictionary<string, object?>();
                foreach (DataColumn col in dt.Columns)
                {
                    var value = row[col];
                    dict[col.ColumnName] = value == DBNull.Value ? null : value;
                }
                data.Add(dict);
            }

            var stream = new MemoryStream();
            if (string.IsNullOrEmpty(sheetName))
            {
                MiniExcel.SaveAs(stream, data);
            }
            else
            {
                MiniExcel.SaveAs(stream, data, sheetName: sheetName);
            }
            stream.Position = 0;
            return stream;
        }

        /// <summary>
        /// 将强类型列表导出为内存流
        /// </summary>
        public static MemoryStream ExportToStream<T>(List<T> data, string? sheetName = null) where T : class, new()
        {
            var stream = new MemoryStream();

            if (data == null || data.Count == 0)
            {
                MiniExcel.SaveAs(stream, new List<T>(), sheetName: sheetName);
            }
            else
            {
                if (string.IsNullOrEmpty(sheetName))
                {
                    MiniExcel.SaveAs(stream, data);
                }
                else
                {
                    MiniExcel.SaveAs(stream, data, sheetName: sheetName);
                }
            }

            stream.Position = 0;
            return stream;
        }
    }
}
