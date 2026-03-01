using Custom.HydrogenConfigurationSystem.Data.Entities;
using Custom.HydrogenConfigurationSystem.Data.DB;
using Custom.HydrogenConfigurationSystem.Helpers;
using Custom.HydrogenConfigurationSystem.Globals;
using Custom.HydrogenConfigurationSystem.PlcComm;

namespace Custom.HydrogenConfigurationSystem.Forms
{
    public partial class FrmRecipeManager : System.Windows.Forms.Form
    {
        private RecipeService _recipeService = new RecipeService();
        private RecipeEntity? _currentRecipe = null;
        private List<RecipeEntity> _recipes = new List<RecipeEntity>();
        private bool _isEditing = false;

        public FrmRecipeManager()
        {
            InitializeComponent();
            InitializeEvents();
            LoadRecipes();
            ApplyTheme();
        }

        private void InitializeEvents()
        {
            uiButtonAdd.Click += UiButtonAdd_Click;
            uiButtonEdit.Click += UiButtonEdit_Click;
            uiButtonDelete.Click += UiButtonDelete_Click;
            uiButtonSave.Click += UiButtonSave_Click;
            uiButtonImport.Click += UiButtonImport_Click;
            uiButtonExport.Click += UiButtonExport_Click;
            uiButtonSendToPlc.Click += UiButtonSendToPlc_Click;
            uiListBoxRecipes.SelectedIndexChanged += UiListBoxRecipes_SelectedIndexChanged;
        }

        private void ApplyTheme()
        {
            ThemeManager.ApplyFormTheme(this);
        }

        private void LoadRecipes()
        {
            try
            {
                _recipes = _recipeService.GetList();
                LogHelper.Info($"加载配方列表，共 {_recipes.Count} 个配方");
                RefreshRecipeList();
                if (_recipes.Count > 0)
                {
                    uiListBoxRecipes.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"加载配方列表失败: {ex.Message}", "错误");
                LogHelper.Error($"加载配方列表失败: {ex.Message}");
            }
        }

        private void RefreshRecipeList()
        {
            uiListBoxRecipes.Items.Clear();
            foreach (var recipe in _recipes)
            {
                uiListBoxRecipes.Items.Add($"{recipe.RecipeName} ({recipe.ApplicationScene}) - ID:{recipe.Id}");
            }
        }

        private void UiListBoxRecipes_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (uiListBoxRecipes.SelectedIndex >= 0 && uiListBoxRecipes.SelectedIndex < _recipes.Count)
            {
                _currentRecipe = _recipes[uiListBoxRecipes.SelectedIndex];
                DisplayRecipe(_currentRecipe);
                _isEditing = false;
                SetEditMode(false);
            }
        }

        private void DisplayRecipe(RecipeEntity recipe)
        {
            // 显示配方名称
            uiTextBoxRecipeName.Text = recipe.RecipeName;

            // 显示应用场景（下拉框选择）
            bool existsInComboBox = false;
            for (int i = 0; i < uiComboBoxScene.Items.Count; i++)
            {
                if (uiComboBoxScene.Items[i]?.ToString() == recipe.ApplicationScene)
                {
                    uiComboBoxScene.SelectedIndex = i;
                    existsInComboBox = true;
                    break;
                }
            }

            // 如果不在选项中，默认选择第一个
            if (!existsInComboBox && uiComboBoxScene.Items.Count > 0)
            {
                uiComboBoxScene.SelectedIndex = 0;
            }

            uiTextBoxElecCurrentMin.Text = recipe.ElectrolysisCurrentMin.ToString("F1");
            uiTextBoxElecCurrentMax.Text = recipe.ElectrolysisCurrentMax.ToString("F1");
            uiTextBoxPurPressureMin.Text = recipe.PurificationPressureMin.ToString("F1");
            uiTextBoxPurPressureMax.Text = recipe.PurificationPressureMax.ToString("F1");
            uiTextBoxStoPressure.Text = recipe.StoragePressure.ToString("F1");
            uiTextBoxRefFlowMax.Text = recipe.HydrogenFlowMax.ToString("F1");
        }

        private void UiButtonAdd_Click(object? sender, EventArgs e)
        {
            if (!PermissionHelper.CanManageRecipe())
            {
                UIHelper.ShowError("您没有权限管理配方！", "权限验证");
                return;
            }

            // 弹出命名窗口
            string recipeName = ShowRecipeNameDialog();
            if (string.IsNullOrWhiteSpace(recipeName))
            {
                return; // 用户取消或未输入名称
            }

            _currentRecipe = new RecipeEntity
            {
                RecipeName = recipeName,
                ApplicationScene = "工业用氢",
                ElectrolysisCurrentMin = 200,
                ElectrolysisCurrentMax = 400,
                PurificationPressureMin = 4.0,
                PurificationPressureMax = 6.0,
                StoragePressure = 25.0,
                HydrogenFlowMin = 0,
                HydrogenFlowMax = 80.0,
                HydrogenPurity = 99.99
            };

            DisplayRecipe(_currentRecipe);
            _isEditing = true;
            SetEditMode(true);
            uiComboBoxScene.Focus();
        }

        private string ShowRecipeNameDialog()
        {
            using (var dialog = new Form())
            {
                dialog.Text = "新建配方";
                dialog.Size = new System.Drawing.Size(500, 280);
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialog.MaximizeBox = false;
                dialog.MinimizeBox = false;

                var label = new Label
                {
                    Text = "请输入配方名称：",
                    Location = new System.Drawing.Point(30, 40),
                    Size = new System.Drawing.Size(440, 30),
                    Font = new Font("微软雅黑", 12F)
                };

                var textBox = new TextBox
                {
                    Location = new System.Drawing.Point(30, 80),
                    Size = new System.Drawing.Size(440, 40),
                    Font = new Font("微软雅黑", 12F)
                };

                var btnOk = new Button
                {
                    Text = "确定",
                    DialogResult = DialogResult.OK,
                    Location = new System.Drawing.Point(140, 160),
                    Size = new System.Drawing.Size(100, 45),
                    Font = new Font("微软雅黑", 11F),
                    BackColor = Color.FromArgb(59, 130, 246),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                btnOk.FlatAppearance.BorderSize = 0;

                var btnCancel = new Button
                {
                    Text = "取消",
                    DialogResult = DialogResult.Cancel,
                    Location = new System.Drawing.Point(260, 160),
                    Size = new System.Drawing.Size(100, 45),
                    Font = new Font("微软雅黑", 11F),
                    BackColor = Color.FromArgb(100, 116, 139),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                btnCancel.FlatAppearance.BorderSize = 0;

                dialog.Controls.Add(label);
                dialog.Controls.Add(textBox);
                dialog.Controls.Add(btnOk);
                dialog.Controls.Add(btnCancel);
                dialog.AcceptButton = btnOk;
                dialog.CancelButton = btnCancel;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    return textBox.Text.Trim();
                }
                return string.Empty;
            }
        }

        private void UiButtonEdit_Click(object? sender, EventArgs e)
        {
            if (!PermissionHelper.CanManageRecipe())
            {
                UIHelper.ShowError("您没有权限管理配方！", "权限验证");
                return;
            }

            if (_currentRecipe == null)
            {
                UIHelper.ShowError("请先选择一个配方！", "提示");
                return;
            }

            _isEditing = true;
            SetEditMode(true);
        }

        private void UiButtonDelete_Click(object? sender, EventArgs e)
        {
            if (!PermissionHelper.CanManageRecipe())
            {
                UIHelper.ShowError("您没有权限管理配方！", "权限验证");
                return;
            }

            // 获取当前选中的索引
            int selectedIndex = uiListBoxRecipes.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= _recipes.Count)
            {
                UIHelper.ShowError("请先选择一个配方！", "提示");
                return;
            }

            // 从列表中获取选中的配方
            var selectedRecipe = _recipes[selectedIndex];
            if (selectedRecipe == null)
            {
                UIHelper.ShowError("选中的配方无效！", "错误");
                return;
            }

            // 检查配方ID是否有效
            if (selectedRecipe.Id <= 0)
            {
                UIHelper.ShowError($"配方ID无效（ID={selectedRecipe.Id}），无法删除！\n\n可能是数据库ID未正确生成，请联系管理员。", "错误");
                return;
            }

            var result = MessageBox.Show($"确定要删除配方「{selectedRecipe.RecipeName}」吗？\n\n应用场景: {selectedRecipe.ApplicationScene}\n配方ID: {selectedRecipe.Id}", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // 删除指定ID的配方
                    bool deleteResult = _recipeService.Delete(selectedRecipe.Id);

                    if (deleteResult)
                    {
                        UIHelper.ShowInfo($"配方「{selectedRecipe.RecipeName}」删除成功！", "成功");
                        _currentRecipe = null;
                        LoadRecipes();
                    }
                    else
                    {
                        UIHelper.ShowError("删除失败！", "错误");
                    }
                }
                catch (Exception ex)
                {
                    UIHelper.ShowError($"删除失败: {ex.Message}", "错误");
                }
            }
        }

        private void UiButtonSave_Click(object? sender, EventArgs e)
        {
            if (!PermissionHelper.CanManageRecipe())
            {
                UIHelper.ShowError("您没有权限管理配方！", "权限验证");
                return;
            }

            if (!_isEditing || _currentRecipe == null)
            {
                return;
            }

            if (!ValidateInput())
            {
                return;
            }

            try
            {
                // 保存配方名称
                _currentRecipe.RecipeName = uiTextBoxRecipeName.Text.Trim();
                if (string.IsNullOrWhiteSpace(_currentRecipe.RecipeName))
                {
                    _currentRecipe.RecipeName = "未命名配方";
                }

                // 保存应用场景（下拉框选择）
                _currentRecipe.ApplicationScene = uiComboBoxScene.SelectedItem?.ToString() ?? "工业用氢";

                _currentRecipe.ElectrolysisCurrentMin = double.Parse(uiTextBoxElecCurrentMin.Text);
                _currentRecipe.ElectrolysisCurrentMax = double.Parse(uiTextBoxElecCurrentMax.Text);
                _currentRecipe.PurificationPressureMin = double.Parse(uiTextBoxPurPressureMin.Text);
                _currentRecipe.PurificationPressureMax = double.Parse(uiTextBoxPurPressureMax.Text);
                _currentRecipe.StoragePressure = double.Parse(uiTextBoxStoPressure.Text);
                _currentRecipe.HydrogenFlowMax = double.Parse(uiTextBoxRefFlowMax.Text);

                bool success;
                if (_currentRecipe.Id == 0)
                {
                    success = _recipeService.Add(_currentRecipe);
                    if (success)
                    {
                        LogHelper.Info($"新增配方: {_currentRecipe.RecipeName} ({_currentRecipe.ApplicationScene})");
                    }
                }
                else
                {
                    success = _recipeService.Update(_currentRecipe);
                    if (success)
                    {
                        LogHelper.Info($"更新配方: {_currentRecipe.RecipeName} ({_currentRecipe.ApplicationScene})");
                    }
                }

                if (success)
                {
                    UIHelper.ShowInfo("保存成功！", "成功");
                    _isEditing = false;
                    SetEditMode(false);
                    LoadRecipes();
                }
                else
                {
                    UIHelper.ShowError("保存失败！", "错误");
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"保存失败: {ex.Message}", "错误");
                LogHelper.Error($"保存配方失败: {ex.Message}");
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(uiTextBoxRecipeName.Text))
            {
                UIHelper.ShowError("请输入配方名称！", "提示");
                uiTextBoxRecipeName.Focus();
                return false;
            }

            if (uiComboBoxScene.SelectedItem == null)
            {
                UIHelper.ShowError("请选择应用场景！", "提示");
                uiComboBoxScene.Focus();
                return false;
            }

            if (!double.TryParse(uiTextBoxElecCurrentMin.Text, out _))
            {
                UIHelper.ShowError("电解电流下限格式错误！", "提示");
                uiTextBoxElecCurrentMin.Focus();
                return false;
            }

            if (!double.TryParse(uiTextBoxElecCurrentMax.Text, out _))
            {
                UIHelper.ShowError("电解电流上限格式错误！", "提示");
                uiTextBoxElecCurrentMax.Focus();
                return false;
            }

            if (!double.TryParse(uiTextBoxPurPressureMin.Text, out _))
            {
                UIHelper.ShowError("纯化压力下限格式错误！", "提示");
                uiTextBoxPurPressureMin.Focus();
                return false;
            }

            if (!double.TryParse(uiTextBoxPurPressureMax.Text, out _))
            {
                UIHelper.ShowError("纯化压力上限格式错误！", "提示");
                uiTextBoxPurPressureMax.Focus();
                return false;
            }

            if (!double.TryParse(uiTextBoxStoPressure.Text, out _))
            {
                UIHelper.ShowError("储氢压力格式错误！", "提示");
                uiTextBoxStoPressure.Focus();
                return false;
            }

            if (!double.TryParse(uiTextBoxRefFlowMax.Text, out _))
            {
                UIHelper.ShowError("加氢流量上限格式错误！", "提示");
                uiTextBoxRefFlowMax.Focus();
                return false;
            }

            return true;
        }

        private void UiButtonImport_Click(object? sender, EventArgs e)
        {
            if (!PermissionHelper.CanManageRecipe())
            {
                UIHelper.ShowError("您没有权限管理配方！", "权限验证");
                return;
            }

            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel文件|*.xlsx;*.xls|CSV文件|*.csv|所有文件|*.*";
                openFileDialog.Title = "导入配方";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var importedRecipes = ExcelHelper.Import<RecipeEntity>(openFileDialog.FileName);
                        foreach (var recipe in importedRecipes)
                        {
                            _recipeService.Add(recipe);
                        }

                        UIHelper.ShowInfo($"成功导入 {importedRecipes.Count} 个配方！", "成功");
                        LogHelper.Info($"导入配方: {importedRecipes.Count} 个");
                        LoadRecipes();
                    }
                    catch (Exception ex)
                    {
                        UIHelper.ShowError($"导入失败: {ex.Message}", "错误");
                        LogHelper.Error($"导入配方失败: {ex.Message}");
                    }
                }
            }
        }

        private void UiButtonExport_Click(object? sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel文件|*.xlsx|CSV文件|*.csv";
                saveFileDialog.Title = "导出配方";
                saveFileDialog.FileName = $"配方_{DateTime.Now:yyyyMMddHHmmss}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        bool success = ExcelHelper.Export(saveFileDialog.FileName, _recipes);
                        if (success)
                        {
                            UIHelper.ShowInfo("导出成功！", "成功");
                            LogHelper.Info($"导出配方到: {saveFileDialog.FileName}");
                        }
                        else
                        {
                            UIHelper.ShowError("导出失败！", "错误");
                        }
                    }
                    catch (Exception ex)
                    {
                        UIHelper.ShowError($"导出失败: {ex.Message}", "错误");
                        LogHelper.Error($"导出配方失败: {ex.Message}");
                    }
                }
            }
        }

        private void UiButtonSendToPlc_Click(object? sender, EventArgs e)
        {
            if (!PermissionHelper.CanManageRecipe())
            {
                UIHelper.ShowError("您没有权限管理配方！", "权限验证");
                return;
            }

            if (_currentRecipe == null)
            {
                UIHelper.ShowError("请先选择一个配方！", "提示");
                return;
            }

            if (!GlobalVariables.PlcIsConnected)
            {
                UIHelper.ShowError("PLC未连接！", "错误");
                return;
            }

            var result = MessageBox.Show($"确定要将配方「{_currentRecipe.ApplicationScene}」下发到PLC吗？", "确认下发", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var writeData = new Dictionary<string, object>
                    {
                        { "电解电流下限", _currentRecipe.ElectrolysisCurrentMin },
                        { "电解电流上限", _currentRecipe.ElectrolysisCurrentMax },
                        { "纯化压力下限", _currentRecipe.PurificationPressureMin },
                        { "纯化压力上限", _currentRecipe.PurificationPressureMax },
                        { "储氢压力设定", _currentRecipe.StoragePressure },
                        { "加氢流量上限", _currentRecipe.HydrogenFlowMax }
                    };

                    var plcResult = PlcClientHelper.BatchWritePlcData(writeData);

                    if (plcResult.IsSuccess)
                    {
                        // 保存当前配方信息到全局变量
                        GlobalVariables.CurrentRecipeName = _currentRecipe.ApplicationScene;
                        GlobalVariables.CurrentRecipeSendTime = DateTime.Now;
                        GlobalVariables.CurrentRecipeParams = new Dictionary<string, object>
                        {
                            { "电解电流下限", _currentRecipe.ElectrolysisCurrentMin },
                            { "电解电流上限", _currentRecipe.ElectrolysisCurrentMax },
                            { "纯化压力下限", _currentRecipe.PurificationPressureMin },
                            { "纯化压力上限", _currentRecipe.PurificationPressureMax },
                            { "储氢压力设定", _currentRecipe.StoragePressure },
                            { "加氢流量上限", _currentRecipe.HydrogenFlowMax }
                        };

                        // 更新主界面显示
                        var mainForm = Application.OpenForms["FrmMain"] as FrmMain;
                        mainForm?.UpdateCurrentRecipeDisplay();

                        // 构建详细的下发成功信息
                        var sb = new System.Text.StringBuilder();
                        sb.AppendLine($"配方「{_currentRecipe.ApplicationScene}」下发成功！");
                        sb.AppendLine();
                        sb.AppendLine("已写入PLC的参数：");
                        sb.AppendLine($"  • 电解电流范围: {_currentRecipe.ElectrolysisCurrentMin:F1} ~ {_currentRecipe.ElectrolysisCurrentMax:F1} A");
                        sb.AppendLine($"  • 纯化压力范围: {_currentRecipe.PurificationPressureMin:F2} ~ {_currentRecipe.PurificationPressureMax:F2} MPa");
                        sb.AppendLine($"  • 储氢压力设定: {_currentRecipe.StoragePressure:F2} MPa");
                        sb.AppendLine($"  • 加氢流量上限: {_currentRecipe.HydrogenFlowMax:F1} Nm³/h");
                        sb.AppendLine();
                        sb.AppendLine("PLC将根据这些参数自动限幅控制。");

                        UIHelper.ShowInfo(sb.ToString(), "配方下发成功");
                        LogHelper.Info($"配方下发到PLC成功: {_currentRecipe.ApplicationScene}, " +
                            $"电流:{_currentRecipe.ElectrolysisCurrentMin:F1}-{_currentRecipe.ElectrolysisCurrentMax:F1}A, " +
                            $"纯化压力:{_currentRecipe.PurificationPressureMin:F2}-{_currentRecipe.PurificationPressureMax:F2}MPa, " +
                            $"储氢压力:{_currentRecipe.StoragePressure:F2}MPa, " +
                            $"加氢流量上限:{_currentRecipe.HydrogenFlowMax:F1}Nm³/h");

                        // 记录操作日志
                        LogHelper.LogOperate("配方管理", $"下发配方「{_currentRecipe.ApplicationScene}」到PLC");
                    }
                    else
                    {
                        UIHelper.ShowError($"配方下发失败: {plcResult.Message}", "错误");
                        LogHelper.Error($"配方下发到PLC失败: {plcResult.Message}");
                    }
                }
                catch (Exception ex)
                {
                    UIHelper.ShowError($"配方下发失败: {ex.Message}", "错误");
                    LogHelper.Error($"配方下发到PLC异常: {ex.Message}");
                }
            }
        }

        private void SetEditMode(bool isEdit)
        {
            uiComboBoxScene.Enabled = isEdit;
            uiTextBoxElecCurrentMin.Enabled = isEdit;
            uiTextBoxElecCurrentMax.Enabled = isEdit;
            uiTextBoxPurPressureMin.Enabled = isEdit;
            uiTextBoxPurPressureMax.Enabled = isEdit;
            uiTextBoxStoPressure.Enabled = isEdit;
            uiTextBoxRefFlowMax.Enabled = isEdit;

            uiButtonAdd.Enabled = !isEdit;
            uiButtonEdit.Enabled = !isEdit && _currentRecipe != null;
            uiButtonDelete.Enabled = !isEdit && _currentRecipe != null;
            uiButtonSave.Enabled = isEdit;
            uiButtonImport.Enabled = !isEdit;
            uiButtonExport.Enabled = !isEdit;
            uiButtonSendToPlc.Enabled = !isEdit && _currentRecipe != null;
        }
    }
}
