namespace Custom.HydrogenConfigurationSystem.Forms
{
    partial class FrmRecipeManager
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            uiPanelTitle = new Panel();
            uiLabelSubtitle = new Label();
            uiLabelTitle = new Label();
            uiPanelLeft = new Panel();
            uiListBoxRecipes = new ListBox();
            uiLabelRecipeList = new Label();
            uiPanelRight = new Panel();
            uiPanelButtons = new Panel();
            uiButtonSendToPlc = new Button();
            uiButtonExport = new Button();
            uiButtonImport = new Button();
            uiButtonSave = new Button();
            uiButtonDelete = new Button();
            uiButtonEdit = new Button();
            uiButtonAdd = new Button();
            uiPanelParams = new Panel();
            uiLabelRecipeName = new Label();
            uiTextBoxRecipeName = new TextBox();
            uiLabelScene = new Label();
            uiComboBoxScene = new ComboBox();
            uiLabelElecCurrentMin = new Label();
            uiTextBoxElecCurrentMin = new TextBox();
            uiLabelElecCurrentMax = new Label();
            uiTextBoxElecCurrentMax = new TextBox();
            uiLabelPurPressureMin = new Label();
            uiTextBoxPurPressureMin = new TextBox();
            uiLabelPurPressureMax = new Label();
            uiTextBoxPurPressureMax = new TextBox();
            uiLabelStoPressure = new Label();
            uiTextBoxStoPressure = new TextBox();
            uiLabelRefFlowMax = new Label();
            uiTextBoxRefFlowMax = new TextBox();
            uiLabelRecipeDetail = new Label();
            uiPanelTitle.SuspendLayout();
            uiPanelLeft.SuspendLayout();
            uiPanelRight.SuspendLayout();
            uiPanelButtons.SuspendLayout();
            uiPanelParams.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanelTitle
            // 
            uiPanelTitle.BackColor = Color.Transparent;
            uiPanelTitle.Controls.Add(uiLabelSubtitle);
            uiPanelTitle.Controls.Add(uiLabelTitle);
            uiPanelTitle.Location = new Point(20, 20);
            uiPanelTitle.Name = "uiPanelTitle";
            uiPanelTitle.Size = new Size(1160, 60);
            uiPanelTitle.TabIndex = 0;
            // 
            // uiLabelSubtitle
            // 
            uiLabelSubtitle.AutoSize = true;
            uiLabelSubtitle.Font = new Font("微软雅黑", 10F);
            uiLabelSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelSubtitle.Location = new Point(172, 21);
            uiLabelSubtitle.Name = "uiLabelSubtitle";
            uiLabelSubtitle.Size = new Size(192, 27);
            uiLabelSubtitle.TabIndex = 1;
            uiLabelSubtitle.Text = "工艺参数配置与管理";
            // 
            // uiLabelTitle
            // 
            uiLabelTitle.AutoSize = true;
            uiLabelTitle.Font = new Font("微软雅黑", 18F, FontStyle.Bold);
            uiLabelTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelTitle.Location = new Point(2, 4);
            uiLabelTitle.Name = "uiLabelTitle";
            uiLabelTitle.Size = new Size(164, 47);
            uiLabelTitle.TabIndex = 0;
            uiLabelTitle.Text = "配方管理";
            // 
            // uiPanelLeft
            // 
            uiPanelLeft.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelLeft.BorderStyle = BorderStyle.FixedSingle;
            uiPanelLeft.Controls.Add(uiListBoxRecipes);
            uiPanelLeft.Controls.Add(uiLabelRecipeList);
            uiPanelLeft.Location = new Point(20, 100);
            uiPanelLeft.Name = "uiPanelLeft";
            uiPanelLeft.Size = new Size(300, 680);
            uiPanelLeft.TabIndex = 1;
            // 
            // uiListBoxRecipes
            // 
            uiListBoxRecipes.BackColor = Color.FromArgb(15, 23, 42);
            uiListBoxRecipes.Font = new Font("微软雅黑", 10F);
            uiListBoxRecipes.ForeColor = Color.White;
            uiListBoxRecipes.FormattingEnabled = true;
            uiListBoxRecipes.ItemHeight = 27;
            uiListBoxRecipes.Location = new Point(20, 50);
            uiListBoxRecipes.Name = "uiListBoxRecipes";
            uiListBoxRecipes.Size = new Size(260, 598);
            uiListBoxRecipes.TabIndex = 1;
            // 
            // uiLabelRecipeList
            // 
            uiLabelRecipeList.AutoSize = true;
            uiLabelRecipeList.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            uiLabelRecipeList.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelRecipeList.Location = new Point(20, 15);
            uiLabelRecipeList.Name = "uiLabelRecipeList";
            uiLabelRecipeList.Size = new Size(129, 37);
            uiLabelRecipeList.TabIndex = 0;
            uiLabelRecipeList.Text = "配方列表";
            // 
            // uiPanelRight
            // 
            uiPanelRight.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelRight.BorderStyle = BorderStyle.FixedSingle;
            uiPanelRight.Controls.Add(uiPanelButtons);
            uiPanelRight.Controls.Add(uiPanelParams);
            uiPanelRight.Controls.Add(uiLabelRecipeDetail);
            uiPanelRight.Location = new Point(340, 100);
            uiPanelRight.Name = "uiPanelRight";
            uiPanelRight.Size = new Size(840, 680);
            uiPanelRight.TabIndex = 2;
            // 
            // uiPanelButtons
            // 
            uiPanelButtons.BackColor = Color.Transparent;
            uiPanelButtons.Controls.Add(uiButtonSendToPlc);
            uiPanelButtons.Controls.Add(uiButtonExport);
            uiPanelButtons.Controls.Add(uiButtonImport);
            uiPanelButtons.Controls.Add(uiButtonSave);
            uiPanelButtons.Controls.Add(uiButtonDelete);
            uiPanelButtons.Controls.Add(uiButtonEdit);
            uiPanelButtons.Controls.Add(uiButtonAdd);
            uiPanelButtons.Location = new Point(20, 570);
            uiPanelButtons.Name = "uiPanelButtons";
            uiPanelButtons.Size = new Size(800, 90);
            uiPanelButtons.TabIndex = 2;
            // 
            // uiButtonSendToPlc
            // 
            uiButtonSendToPlc.BackColor = Color.FromArgb(168, 85, 247);
            uiButtonSendToPlc.FlatAppearance.BorderSize = 0;
            uiButtonSendToPlc.FlatStyle = FlatStyle.Flat;
            uiButtonSendToPlc.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonSendToPlc.ForeColor = Color.White;
            uiButtonSendToPlc.Location = new Point(700, 20);
            uiButtonSendToPlc.Name = "uiButtonSendToPlc";
            uiButtonSendToPlc.Size = new Size(100, 50);
            uiButtonSendToPlc.TabIndex = 7;
            uiButtonSendToPlc.Text = "下发";
            uiButtonSendToPlc.UseVisualStyleBackColor = false;
            // 
            // uiButtonExport
            // 
            uiButtonExport.BackColor = Color.FromArgb(20, 184, 166);
            uiButtonExport.FlatAppearance.BorderSize = 0;
            uiButtonExport.FlatStyle = FlatStyle.Flat;
            uiButtonExport.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonExport.ForeColor = Color.White;
            uiButtonExport.Location = new Point(600, 20);
            uiButtonExport.Name = "uiButtonExport";
            uiButtonExport.Size = new Size(100, 50);
            uiButtonExport.TabIndex = 5;
            uiButtonExport.Text = "导出";
            uiButtonExport.UseVisualStyleBackColor = false;
            // 
            // uiButtonImport
            // 
            uiButtonImport.BackColor = Color.FromArgb(139, 92, 246);
            uiButtonImport.FlatAppearance.BorderSize = 0;
            uiButtonImport.FlatStyle = FlatStyle.Flat;
            uiButtonImport.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonImport.ForeColor = Color.White;
            uiButtonImport.Location = new Point(480, 20);
            uiButtonImport.Name = "uiButtonImport";
            uiButtonImport.Size = new Size(100, 50);
            uiButtonImport.TabIndex = 4;
            uiButtonImport.Text = "导入";
            uiButtonImport.UseVisualStyleBackColor = false;
            // 
            // uiButtonSave
            // 
            uiButtonSave.BackColor = Color.FromArgb(245, 158, 11);
            uiButtonSave.FlatAppearance.BorderSize = 0;
            uiButtonSave.FlatStyle = FlatStyle.Flat;
            uiButtonSave.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonSave.ForeColor = Color.White;
            uiButtonSave.Location = new Point(360, 20);
            uiButtonSave.Name = "uiButtonSave";
            uiButtonSave.Size = new Size(100, 50);
            uiButtonSave.TabIndex = 3;
            uiButtonSave.Text = "保存";
            uiButtonSave.UseVisualStyleBackColor = false;
            // 
            // uiButtonDelete
            // 
            uiButtonDelete.BackColor = Color.FromArgb(239, 68, 68);
            uiButtonDelete.FlatAppearance.BorderSize = 0;
            uiButtonDelete.FlatStyle = FlatStyle.Flat;
            uiButtonDelete.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonDelete.ForeColor = Color.White;
            uiButtonDelete.Location = new Point(240, 20);
            uiButtonDelete.Name = "uiButtonDelete";
            uiButtonDelete.Size = new Size(100, 50);
            uiButtonDelete.TabIndex = 2;
            uiButtonDelete.Text = "删除";
            uiButtonDelete.UseVisualStyleBackColor = false;
            // 
            // uiButtonEdit
            // 
            uiButtonEdit.BackColor = Color.FromArgb(59, 130, 246);
            uiButtonEdit.FlatAppearance.BorderSize = 0;
            uiButtonEdit.FlatStyle = FlatStyle.Flat;
            uiButtonEdit.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonEdit.ForeColor = Color.White;
            uiButtonEdit.Location = new Point(120, 20);
            uiButtonEdit.Name = "uiButtonEdit";
            uiButtonEdit.Size = new Size(100, 50);
            uiButtonEdit.TabIndex = 1;
            uiButtonEdit.Text = "编辑";
            uiButtonEdit.UseVisualStyleBackColor = false;
            // 
            // uiButtonAdd
            // 
            uiButtonAdd.BackColor = Color.FromArgb(34, 197, 94);
            uiButtonAdd.FlatAppearance.BorderSize = 0;
            uiButtonAdd.FlatStyle = FlatStyle.Flat;
            uiButtonAdd.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonAdd.ForeColor = Color.White;
            uiButtonAdd.Location = new Point(0, 20);
            uiButtonAdd.Name = "uiButtonAdd";
            uiButtonAdd.Size = new Size(100, 50);
            uiButtonAdd.TabIndex = 0;
            uiButtonAdd.Text = "新增";
            uiButtonAdd.UseVisualStyleBackColor = false;
            // 
            // uiPanelParams
            // 
            uiPanelParams.BackColor = Color.Transparent;
            uiPanelParams.Controls.Add(uiLabelRecipeName);
            uiPanelParams.Controls.Add(uiTextBoxRecipeName);
            uiPanelParams.Controls.Add(uiLabelScene);
            uiPanelParams.Controls.Add(uiComboBoxScene);
            uiPanelParams.Controls.Add(uiLabelElecCurrentMin);
            uiPanelParams.Controls.Add(uiTextBoxElecCurrentMin);
            uiPanelParams.Controls.Add(uiLabelElecCurrentMax);
            uiPanelParams.Controls.Add(uiTextBoxElecCurrentMax);
            uiPanelParams.Controls.Add(uiLabelPurPressureMin);
            uiPanelParams.Controls.Add(uiTextBoxPurPressureMin);
            uiPanelParams.Controls.Add(uiLabelPurPressureMax);
            uiPanelParams.Controls.Add(uiTextBoxPurPressureMax);
            uiPanelParams.Controls.Add(uiLabelStoPressure);
            uiPanelParams.Controls.Add(uiTextBoxStoPressure);
            uiPanelParams.Controls.Add(uiLabelRefFlowMax);
            uiPanelParams.Controls.Add(uiTextBoxRefFlowMax);
            uiPanelParams.Location = new Point(20, 50);
            uiPanelParams.Name = "uiPanelParams";
            uiPanelParams.Size = new Size(800, 500);
            uiPanelParams.TabIndex = 1;
            // 
            // uiLabelRecipeName
            // 
            uiLabelRecipeName.AutoSize = true;
            uiLabelRecipeName.Font = new Font("微软雅黑", 10F);
            uiLabelRecipeName.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelRecipeName.Location = new Point(20, 12);
            uiLabelRecipeName.Name = "uiLabelRecipeName";
            uiLabelRecipeName.Size = new Size(92, 27);
            uiLabelRecipeName.TabIndex = 0;
            uiLabelRecipeName.Text = "配方名称";
            // 
            // uiTextBoxRecipeName
            // 
            uiTextBoxRecipeName.BackColor = Color.FromArgb(15, 23, 42);
            uiTextBoxRecipeName.BorderStyle = BorderStyle.FixedSingle;
            uiTextBoxRecipeName.Font = new Font("微软雅黑", 10F);
            uiTextBoxRecipeName.ForeColor = Color.White;
            uiTextBoxRecipeName.Location = new Point(20, 42);
            uiTextBoxRecipeName.Name = "uiTextBoxRecipeName";
            uiTextBoxRecipeName.Size = new Size(200, 34);
            uiTextBoxRecipeName.TabIndex = 1;
            // 
            // uiLabelScene
            // 
            uiLabelScene.AutoSize = true;
            uiLabelScene.Font = new Font("微软雅黑", 10F);
            uiLabelScene.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelScene.Location = new Point(300, 12);
            uiLabelScene.Name = "uiLabelScene";
            uiLabelScene.Size = new Size(92, 27);
            uiLabelScene.TabIndex = 2;
            uiLabelScene.Text = "应用场景";
            // 
            // uiComboBoxScene
            // 
            uiComboBoxScene.BackColor = Color.FromArgb(15, 23, 42);
            uiComboBoxScene.DropDownStyle = ComboBoxStyle.DropDownList;
            uiComboBoxScene.Font = new Font("微软雅黑", 10F);
            uiComboBoxScene.ForeColor = Color.White;
            uiComboBoxScene.FormattingEnabled = true;
            uiComboBoxScene.Items.AddRange(new object[] { "工业用氢", "燃料电池用氢" });
            uiComboBoxScene.Location = new Point(300, 42);
            uiComboBoxScene.Name = "uiComboBoxScene";
            uiComboBoxScene.Size = new Size(200, 35);
            uiComboBoxScene.TabIndex = 3;
            // 
            // uiLabelElecCurrentMin
            // 
            uiLabelElecCurrentMin.AutoSize = true;
            uiLabelElecCurrentMin.Font = new Font("微软雅黑", 10F);
            uiLabelElecCurrentMin.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelElecCurrentMin.Location = new Point(20, 140);
            uiLabelElecCurrentMin.Name = "uiLabelElecCurrentMin";
            uiLabelElecCurrentMin.Size = new Size(160, 27);
            uiLabelElecCurrentMin.TabIndex = 4;
            uiLabelElecCurrentMin.Text = "电解电流下限(A)";
            // 
            // uiTextBoxElecCurrentMin
            // 
            uiTextBoxElecCurrentMin.BackColor = Color.FromArgb(15, 23, 42);
            uiTextBoxElecCurrentMin.BorderStyle = BorderStyle.FixedSingle;
            uiTextBoxElecCurrentMin.Font = new Font("微软雅黑", 10F);
            uiTextBoxElecCurrentMin.ForeColor = Color.White;
            uiTextBoxElecCurrentMin.Location = new Point(20, 173);
            uiTextBoxElecCurrentMin.Name = "uiTextBoxElecCurrentMin";
            uiTextBoxElecCurrentMin.Size = new Size(200, 34);
            uiTextBoxElecCurrentMin.TabIndex = 5;
            uiTextBoxElecCurrentMin.Text = "200";
            // 
            // uiLabelElecCurrentMax
            // 
            uiLabelElecCurrentMax.AutoSize = true;
            uiLabelElecCurrentMax.Font = new Font("微软雅黑", 10F);
            uiLabelElecCurrentMax.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelElecCurrentMax.Location = new Point(300, 140);
            uiLabelElecCurrentMax.Name = "uiLabelElecCurrentMax";
            uiLabelElecCurrentMax.Size = new Size(160, 27);
            uiLabelElecCurrentMax.TabIndex = 6;
            uiLabelElecCurrentMax.Text = "电解电流上限(A)";
            // 
            // uiTextBoxElecCurrentMax
            // 
            uiTextBoxElecCurrentMax.BackColor = Color.FromArgb(15, 23, 42);
            uiTextBoxElecCurrentMax.BorderStyle = BorderStyle.FixedSingle;
            uiTextBoxElecCurrentMax.Font = new Font("微软雅黑", 10F);
            uiTextBoxElecCurrentMax.ForeColor = Color.White;
            uiTextBoxElecCurrentMax.Location = new Point(300, 173);
            uiTextBoxElecCurrentMax.Name = "uiTextBoxElecCurrentMax";
            uiTextBoxElecCurrentMax.Size = new Size(200, 34);
            uiTextBoxElecCurrentMax.TabIndex = 7;
            uiTextBoxElecCurrentMax.Text = "400";
            // 
            // uiLabelPurPressureMin
            // 
            uiLabelPurPressureMin.AutoSize = true;
            uiLabelPurPressureMin.Font = new Font("微软雅黑", 10F);
            uiLabelPurPressureMin.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelPurPressureMin.Location = new Point(20, 210);
            uiLabelPurPressureMin.Name = "uiLabelPurPressureMin";
            uiLabelPurPressureMin.Size = new Size(189, 27);
            uiLabelPurPressureMin.TabIndex = 8;
            uiLabelPurPressureMin.Text = "纯化压力下限(MPa)";
            // 
            // uiTextBoxPurPressureMin
            // 
            uiTextBoxPurPressureMin.BackColor = Color.FromArgb(15, 23, 42);
            uiTextBoxPurPressureMin.BorderStyle = BorderStyle.FixedSingle;
            uiTextBoxPurPressureMin.Font = new Font("微软雅黑", 10F);
            uiTextBoxPurPressureMin.ForeColor = Color.White;
            uiTextBoxPurPressureMin.Location = new Point(20, 243);
            uiTextBoxPurPressureMin.Name = "uiTextBoxPurPressureMin";
            uiTextBoxPurPressureMin.Size = new Size(200, 34);
            uiTextBoxPurPressureMin.TabIndex = 9;
            uiTextBoxPurPressureMin.Text = "4.0";
            // 
            // uiLabelPurPressureMax
            // 
            uiLabelPurPressureMax.AutoSize = true;
            uiLabelPurPressureMax.Font = new Font("微软雅黑", 10F);
            uiLabelPurPressureMax.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelPurPressureMax.Location = new Point(300, 210);
            uiLabelPurPressureMax.Name = "uiLabelPurPressureMax";
            uiLabelPurPressureMax.Size = new Size(189, 27);
            uiLabelPurPressureMax.TabIndex = 10;
            uiLabelPurPressureMax.Text = "纯化压力上限(MPa)";
            // 
            // uiTextBoxPurPressureMax
            // 
            uiTextBoxPurPressureMax.BackColor = Color.FromArgb(15, 23, 42);
            uiTextBoxPurPressureMax.BorderStyle = BorderStyle.FixedSingle;
            uiTextBoxPurPressureMax.Font = new Font("微软雅黑", 10F);
            uiTextBoxPurPressureMax.ForeColor = Color.White;
            uiTextBoxPurPressureMax.Location = new Point(300, 243);
            uiTextBoxPurPressureMax.Name = "uiTextBoxPurPressureMax";
            uiTextBoxPurPressureMax.Size = new Size(200, 34);
            uiTextBoxPurPressureMax.TabIndex = 11;
            uiTextBoxPurPressureMax.Text = "6.0";
            // 
            // uiLabelStoPressure
            // 
            uiLabelStoPressure.AutoSize = true;
            uiLabelStoPressure.Font = new Font("微软雅黑", 10F);
            uiLabelStoPressure.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelStoPressure.Location = new Point(20, 280);
            uiLabelStoPressure.Name = "uiLabelStoPressure";
            uiLabelStoPressure.Size = new Size(189, 27);
            uiLabelStoPressure.TabIndex = 12;
            uiLabelStoPressure.Text = "储氢压力设定(MPa)";
            // 
            // uiTextBoxStoPressure
            // 
            uiTextBoxStoPressure.BackColor = Color.FromArgb(15, 23, 42);
            uiTextBoxStoPressure.BorderStyle = BorderStyle.FixedSingle;
            uiTextBoxStoPressure.Font = new Font("微软雅黑", 10F);
            uiTextBoxStoPressure.ForeColor = Color.White;
            uiTextBoxStoPressure.Location = new Point(20, 310);
            uiTextBoxStoPressure.Name = "uiTextBoxStoPressure";
            uiTextBoxStoPressure.Size = new Size(200, 34);
            uiTextBoxStoPressure.TabIndex = 13;
            uiTextBoxStoPressure.Text = "25.0";
            // 
            // uiLabelRefFlowMax
            // 
            uiLabelRefFlowMax.AutoSize = true;
            uiLabelRefFlowMax.Font = new Font("微软雅黑", 10F);
            uiLabelRefFlowMax.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelRefFlowMax.Location = new Point(300, 280);
            uiLabelRefFlowMax.Name = "uiLabelRefFlowMax";
            uiLabelRefFlowMax.Size = new Size(210, 27);
            uiLabelRefFlowMax.TabIndex = 14;
            uiLabelRefFlowMax.Text = "加氢流量上限(Nm³/h)";
            // 
            // uiTextBoxRefFlowMax
            // 
            uiTextBoxRefFlowMax.BackColor = Color.FromArgb(15, 23, 42);
            uiTextBoxRefFlowMax.BorderStyle = BorderStyle.FixedSingle;
            uiTextBoxRefFlowMax.Font = new Font("微软雅黑", 10F);
            uiTextBoxRefFlowMax.ForeColor = Color.White;
            uiTextBoxRefFlowMax.Location = new Point(300, 310);
            uiTextBoxRefFlowMax.Name = "uiTextBoxRefFlowMax";
            uiTextBoxRefFlowMax.Size = new Size(200, 34);
            uiTextBoxRefFlowMax.TabIndex = 15;
            uiTextBoxRefFlowMax.Text = "80.0";
            // 
            // uiLabelRecipeDetail
            // 
            uiLabelRecipeDetail.AutoSize = true;
            uiLabelRecipeDetail.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            uiLabelRecipeDetail.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelRecipeDetail.Location = new Point(20, 15);
            uiLabelRecipeDetail.Name = "uiLabelRecipeDetail";
            uiLabelRecipeDetail.Size = new Size(129, 37);
            uiLabelRecipeDetail.TabIndex = 0;
            uiLabelRecipeDetail.Text = "配方详情";
            // 
            // FrmRecipeManager
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1220, 760);
            Controls.Add(uiPanelRight);
            Controls.Add(uiPanelLeft);
            Controls.Add(uiPanelTitle);
            Name = "FrmRecipeManager";
            Text = "配方管理";
            uiPanelTitle.ResumeLayout(false);
            uiPanelTitle.PerformLayout();
            uiPanelLeft.ResumeLayout(false);
            uiPanelLeft.PerformLayout();
            uiPanelRight.ResumeLayout(false);
            uiPanelRight.PerformLayout();
            uiPanelButtons.ResumeLayout(false);
            uiPanelParams.ResumeLayout(false);
            uiPanelParams.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel uiPanelTitle;
        private System.Windows.Forms.Label uiLabelTitle;
        private System.Windows.Forms.Label uiLabelSubtitle;
        private System.Windows.Forms.Panel uiPanelLeft;
        private System.Windows.Forms.Label uiLabelRecipeList;
        private System.Windows.Forms.ListBox uiListBoxRecipes;
        private System.Windows.Forms.Panel uiPanelRight;
        private System.Windows.Forms.Label uiLabelRecipeDetail;
        private System.Windows.Forms.Panel uiPanelParams;
        private System.Windows.Forms.Label uiLabelRecipeName;
        private System.Windows.Forms.TextBox uiTextBoxRecipeName;
        private System.Windows.Forms.Label uiLabelScene;
        private System.Windows.Forms.ComboBox uiComboBoxScene;
        private System.Windows.Forms.Label uiLabelElecCurrentMin;
        private System.Windows.Forms.TextBox uiTextBoxElecCurrentMin;
        private System.Windows.Forms.Label uiLabelElecCurrentMax;
        private System.Windows.Forms.TextBox uiTextBoxElecCurrentMax;
        private System.Windows.Forms.Label uiLabelPurPressureMin;
        private System.Windows.Forms.TextBox uiTextBoxPurPressureMin;
        private System.Windows.Forms.Label uiLabelPurPressureMax;
        private System.Windows.Forms.TextBox uiTextBoxPurPressureMax;
        private System.Windows.Forms.Label uiLabelStoPressure;
        private System.Windows.Forms.TextBox uiTextBoxStoPressure;
        private System.Windows.Forms.Label uiLabelRefFlowMax;
        private System.Windows.Forms.TextBox uiTextBoxRefFlowMax;
        private System.Windows.Forms.Panel uiPanelButtons;
        private System.Windows.Forms.Button uiButtonAdd;
        private System.Windows.Forms.Button uiButtonEdit;
        private System.Windows.Forms.Button uiButtonDelete;
        private System.Windows.Forms.Button uiButtonSave;
        private System.Windows.Forms.Button uiButtonImport;
        private System.Windows.Forms.Button uiButtonExport;
        private Button uiButtonSendToPlc;
    }
}
