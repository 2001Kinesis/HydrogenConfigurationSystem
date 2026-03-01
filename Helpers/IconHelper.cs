using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Custom.HydrogenConfigurationSystem.Helpers
{
    /// <summary>
    /// 图标帮助类 - 用于生成菜单按钮图标
    /// </summary>
    public static class IconHelper
    {
        private static readonly Color IconColor = Color.FromArgb(56, 189, 248); // 青蓝色
        private static readonly Color IconHoverColor = Color.FromArgb(34, 211, 238); // 亮青色

        /// <summary>
        /// 创建系统总览图标（仪表盘）
        /// </summary>
        public static Bitmap CreateDashboardIcon(int size = 24)
        {
            var bitmap = new Bitmap(size, size);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                var pen = new Pen(IconColor, 2);
                var brush = new SolidBrush(IconColor);

                // 绘制仪表盘外圈
                g.DrawEllipse(pen, 2, 2, size - 4, size - 4);

                // 绘制指针
                var centerX = size / 2;
                var centerY = size / 2;
                g.DrawLine(pen, centerX, centerY, centerX + 6, centerY - 6);

                pen.Dispose();
                brush.Dispose();
            }
            return bitmap;
        }

        /// <summary>
        /// 创建设备控制图标（从资源文件加载）
        /// </summary>
        public static Bitmap CreateDeviceControlIcon(int size = 24)
        {
            try
            {
                // 尝试从资源文件加载设备控制图标
                string iconPath = Path.Combine(Application.StartupPath, "Resources", "Icons", "device_control.png");
                if (File.Exists(iconPath))
                {
                    using (var original = new Bitmap(iconPath))
                    {
                        return new Bitmap(original, new Size(size, size));
                    }
                }
            }
            catch
            {
                // 如果加载失败，使用默认图标
            }

            // 默认图标（开关/控制符号）
            var bitmap = new Bitmap(size, size);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                var pen = new Pen(IconColor, 2);
                var brush = new SolidBrush(IconColor);

                // 绘制开关符号（两个圆点加连线）
                int circleRadius = 4;
                int leftX = 6;
                int rightX = size - 6;
                int centerY = size / 2;

                // 左圆点
                g.FillEllipse(brush, leftX - circleRadius, centerY - circleRadius, circleRadius * 2, circleRadius * 2);
                // 右圆点
                g.FillEllipse(brush, rightX - circleRadius, centerY - circleRadius, circleRadius * 2, circleRadius * 2);
                // 连线
                g.DrawLine(pen, leftX + circleRadius, centerY, rightX - circleRadius, centerY);

                pen.Dispose();
                brush.Dispose();
            }
            return bitmap;
        }

        /// <summary>
        /// 创建实时监控图标（眼睛/监控）
        /// </summary>
        public static Bitmap CreateMonitorIcon(int size = 24)
        {
            var bitmap = new Bitmap(size, size);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                var pen = new Pen(IconColor, 2);

                // 绘制眼睛外框
                g.DrawEllipse(pen, 2, size / 2 - 4, size - 4, 8);

                // 绘制瞳孔
                g.FillEllipse(new SolidBrush(IconColor), size / 2 - 2, size / 2 - 2, 4, 4);

                pen.Dispose();
            }
            return bitmap;
        }

        /// <summary>
        /// 创建配方管理图标（文档/列表）
        /// </summary>
        public static Bitmap CreateRecipeIcon(int size = 24)
        {
            var bitmap = new Bitmap(size, size);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                var pen = new Pen(IconColor, 2);

                // 绘制文档外框
                g.DrawRectangle(pen, 4, 2, size - 8, size - 4);

                // 绘制文本行
                g.DrawLine(pen, 7, 6, size - 7, 6);
                g.DrawLine(pen, 7, 10, size - 7, 10);
                g.DrawLine(pen, 7, 14, size - 10, 14);

                pen.Dispose();
            }
            return bitmap;
        }

        /// <summary>
        /// 创建日志查询图标（搜索/放大镜）
        /// </summary>
        public static Bitmap CreateLogIcon(int size = 24)
        {
            var bitmap = new Bitmap(size, size);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                var pen = new Pen(IconColor, 2);

                // 绘制放大镜圆圈
                g.DrawEllipse(pen, 2, 2, size - 10, size - 10);

                // 绘制放大镜手柄
                g.DrawLine(pen, size - 8, size - 8, size - 4, size - 4);

                pen.Dispose();
            }
            return bitmap;
        }

        /// <summary>
        /// 创建报表图表图标（图表/柱状图）
        /// </summary>
        public static Bitmap CreateChartIcon(int size = 24)
        {
            var bitmap = new Bitmap(size, size);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                var pen = new Pen(IconColor, 2);
                var brush = new SolidBrush(IconColor);

                // 绘制柱状图
                g.FillRectangle(brush, 4, size - 8, 4, 6);
                g.FillRectangle(brush, 10, size - 12, 4, 10);
                g.FillRectangle(brush, 16, size - 16, 4, 14);

                pen.Dispose();
                brush.Dispose();
            }
            return bitmap;
        }

        /// <summary>
        /// 创建系统配置图标（设置/扳手）
        /// </summary>
        public static Bitmap CreateConfigIcon(int size = 24)
        {
            var bitmap = new Bitmap(size, size);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                var pen = new Pen(IconColor, 2);

                // 绘制扳手形状
                g.DrawLine(pen, 6, 6, size - 6, size - 6);
                g.DrawEllipse(pen, 2, 2, 6, 6);
                g.DrawEllipse(pen, size - 8, size - 8, 6, 6);

                pen.Dispose();
            }
            return bitmap;
        }

        /// <summary>
        /// 创建用户管理图标（用户/人形）
        /// </summary>
        public static Bitmap CreateUserIcon(int size = 24)
        {
            var bitmap = new Bitmap(size, size);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                var pen = new Pen(IconColor, 2);

                // 绘制头部
                g.DrawEllipse(pen, size / 2 - 4, 2, 8, 8);

                // 绘制身体
                g.DrawArc(pen, 2, 10, size - 4, size - 10, 0, 180);

                pen.Dispose();
            }
            return bitmap;
        }

        /// <summary>
        /// 为按钮设置图标
        /// </summary>
        public static void SetButtonIcon(Button button, Bitmap icon)
        {
            if (button == null || icon == null) return;

            button.Image = icon;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.Padding = new Padding(10, 0, 0, 0);
        }
    }
}
