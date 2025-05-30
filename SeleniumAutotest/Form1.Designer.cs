﻿namespace SeleniumAutotest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MeMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuFileOpenLast = new System.Windows.Forms.ToolStripMenuItem();
            this.BuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.BuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.BuFileImport = new System.Windows.Forms.ToolStripMenuItem();
            this.инфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuTestParametersHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.BuCantDownloadDriverHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.BuXpathHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.BuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.BuGithub = new System.Windows.Forms.ToolStripMenuItem();
            this.BuDonate = new System.Windows.Forms.ToolStripMenuItem();
            this.LiTests = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChWaitPageLoad = new System.Windows.Forms.CheckBox();
            this.BuPauseStepMode = new System.Windows.Forms.Button();
            this.ImButtons = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.NuSlowModeMs = new System.Windows.Forms.NumericUpDown();
            this.BuTestStepModePrev = new System.Windows.Forms.Button();
            this.BuTestRunStepMode = new System.Windows.Forms.Button();
            this.ChSelectFoundElements = new System.Windows.Forms.CheckBox();
            this.ChSlowMode = new System.Windows.Forms.CheckBox();
            this.LaRunTime = new System.Windows.Forms.Label();
            this.BuTestDown = new System.Windows.Forms.Button();
            this.BuTestUp = new System.Windows.Forms.Button();
            this.LaTestTime = new System.Windows.Forms.Label();
            this.BuTestStop = new System.Windows.Forms.Button();
            this.BuTestClone = new System.Windows.Forms.Button();
            this.BuTestDelete = new System.Windows.Forms.Button();
            this.BuTestAdd = new System.Windows.Forms.Button();
            this.BuTestRun = new System.Windows.Forms.Button();
            this.GrTestSteps = new System.Windows.Forms.GroupBox();
            this.PaMiddleDownMiddle = new System.Windows.Forms.Panel();
            this.BuStepDelete = new System.Windows.Forms.Button();
            this.BuStepAdd = new System.Windows.Forms.Button();
            this.BuStepClone = new System.Windows.Forms.Button();
            this.TrSteps = new System.Windows.Forms.TreeView();
            this.MeNodes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выставитьСтатусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNotStarted = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPassed = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemError = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemIgnoredError = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSkipped = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemStarted = new System.Windows.Forms.ToolStripMenuItem();
            this.ImTree = new System.Windows.Forms.ImageList(this.components);
            this.BuFontDecrease = new System.Windows.Forms.Button();
            this.BuFontIncrease = new System.Windows.Forms.Button();
            this.BuStepDown = new System.Windows.Forms.Button();
            this.BuStepReloadTree = new System.Windows.Forms.Button();
            this.BuStepUp = new System.Windows.Forms.Button();
            this.BuStepPaste = new System.Windows.Forms.Button();
            this.BuStepClearFocus = new System.Windows.Forms.Button();
            this.BuStepCopy = new System.Windows.Forms.Button();
            this.PaMiddleDownDown = new System.Windows.Forms.Panel();
            this.PaMiddleDownDownLeft = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ChSkipIfElementNotFound = new System.Windows.Forms.CheckBox();
            this.ChStepScrollTo = new System.Windows.Forms.CheckBox();
            this.ChStepIgnoreParent = new System.Windows.Forms.CheckBox();
            this.CoStepSelectorType = new System.Windows.Forms.ComboBox();
            this.CoStepTypeGroup = new System.Windows.Forms.ComboBox();
            this.ChStepIsEnabled = new System.Windows.Forms.CheckBox();
            this.TeStepParameter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ChStepIgnoreError = new System.Windows.Forms.CheckBox();
            this.TeStepValue = new System.Windows.Forms.TextBox();
            this.LaStepValue = new System.Windows.Forms.Label();
            this.NuStepWait = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TeStepSelector = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CoStepType = new System.Windows.Forms.ComboBox();
            this.TeStepName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SpMiddleDownDownRight = new System.Windows.Forms.Splitter();
            this.PaMiddleDownDownRight = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RiLog = new System.Windows.Forms.RichTextBox();
            this.TeTestName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrTestParameters = new System.Windows.Forms.GroupBox();
            this.BuTestParametersUp = new System.Windows.Forms.Button();
            this.BuTestParametersDown = new System.Windows.Forms.Button();
            this.ChTestRegenerateParameters = new System.Windows.Forms.CheckBox();
            this.BuTestGenerateParameters = new System.Windows.Forms.Button();
            this.DaTestParameters = new System.Windows.Forms.DataGridView();
            this.CoTestParameterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoTestParametersPattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoTestParameterValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BuProjectParametersUp = new System.Windows.Forms.Button();
            this.BuProjectParametersDown = new System.Windows.Forms.Button();
            this.ChProjectRegenerateParameters = new System.Windows.Forms.CheckBox();
            this.BuProjectGenerateParameters = new System.Windows.Forms.Button();
            this.DaProjectParameters = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrTestSettings = new System.Windows.Forms.GroupBox();
            this.ChTestRunAfterPrevious = new System.Windows.Forms.CheckBox();
            this.ToMain = new System.Windows.Forms.ToolTip(this.components);
            this.PaRight = new System.Windows.Forms.Panel();
            this.PaRightUp = new System.Windows.Forms.Panel();
            this.SpRightDown = new System.Windows.Forms.Splitter();
            this.PaRightDown = new System.Windows.Forms.Panel();
            this.PaMiddle = new System.Windows.Forms.Panel();
            this.PaMIddleDown = new System.Windows.Forms.Panel();
            this.PaMiddleUp = new System.Windows.Forms.Panel();
            this.SpRight = new System.Windows.Forms.Splitter();
            this.PaLeft = new System.Windows.Forms.Panel();
            this.SpLeft = new System.Windows.Forms.Splitter();
            this.BuBoosty = new System.Windows.Forms.ToolStripMenuItem();
            this.MeMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuSlowModeMs)).BeginInit();
            this.GrTestSteps.SuspendLayout();
            this.PaMiddleDownMiddle.SuspendLayout();
            this.MeNodes.SuspendLayout();
            this.PaMiddleDownDown.SuspendLayout();
            this.PaMiddleDownDownLeft.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuStepWait)).BeginInit();
            this.PaMiddleDownDownRight.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.GrTestParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaTestParameters)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaProjectParameters)).BeginInit();
            this.GrTestSettings.SuspendLayout();
            this.PaRight.SuspendLayout();
            this.PaRightUp.SuspendLayout();
            this.PaRightDown.SuspendLayout();
            this.PaMiddle.SuspendLayout();
            this.PaMIddleDown.SuspendLayout();
            this.PaMiddleUp.SuspendLayout();
            this.PaLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // MeMain
            // 
            this.MeMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инфоToolStripMenuItem});
            this.MeMain.Location = new System.Drawing.Point(0, 0);
            this.MeMain.Name = "MeMain";
            this.MeMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MeMain.Size = new System.Drawing.Size(1386, 24);
            this.MeMain.TabIndex = 0;
            this.MeMain.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuFileOpenLast,
            this.BuFileOpen,
            this.BuFileSave,
            this.BuFileImport});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // BuFileOpenLast
            // 
            this.BuFileOpenLast.Name = "BuFileOpenLast";
            this.BuFileOpenLast.Size = new System.Drawing.Size(184, 22);
            this.BuFileOpenLast.Text = "Открыть последний";
            this.BuFileOpenLast.Click += new System.EventHandler(this.BuFileOpenLast_Click);
            // 
            // BuFileOpen
            // 
            this.BuFileOpen.Name = "BuFileOpen";
            this.BuFileOpen.Size = new System.Drawing.Size(184, 22);
            this.BuFileOpen.Text = "Открыть";
            this.BuFileOpen.Click += new System.EventHandler(this.BuFileOpen_Click);
            // 
            // BuFileSave
            // 
            this.BuFileSave.Name = "BuFileSave";
            this.BuFileSave.Size = new System.Drawing.Size(184, 22);
            this.BuFileSave.Text = "Сохранить";
            this.BuFileSave.Click += new System.EventHandler(this.BuFileSave_Click);
            // 
            // BuFileImport
            // 
            this.BuFileImport.Name = "BuFileImport";
            this.BuFileImport.Size = new System.Drawing.Size(184, 22);
            this.BuFileImport.Text = "Импорт из строки";
            this.BuFileImport.Visible = false;
            // 
            // инфоToolStripMenuItem
            // 
            this.инфоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuTestParametersHelp,
            this.BuCantDownloadDriverHelp,
            this.BuXpathHelp,
            this.BuAbout,
            this.BuGithub,
            this.BuDonate,
            this.BuBoosty});
            this.инфоToolStripMenuItem.Name = "инфоToolStripMenuItem";
            this.инфоToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.инфоToolStripMenuItem.Text = "Инфо";
            // 
            // BuTestParametersHelp
            // 
            this.BuTestParametersHelp.Name = "BuTestParametersHelp";
            this.BuTestParametersHelp.Size = new System.Drawing.Size(208, 22);
            this.BuTestParametersHelp.Text = "Справка по параметрам";
            this.BuTestParametersHelp.Click += new System.EventHandler(this.BuTestParametersHelp_Click);
            // 
            // BuCantDownloadDriverHelp
            // 
            this.BuCantDownloadDriverHelp.Name = "BuCantDownloadDriverHelp";
            this.BuCantDownloadDriverHelp.Size = new System.Drawing.Size(208, 22);
            this.BuCantDownloadDriverHelp.Text = "Нет доступа к интернету";
            this.BuCantDownloadDriverHelp.Click += new System.EventHandler(this.BuCantDownloadDriverHelp_Click);
            // 
            // BuXpathHelp
            // 
            this.BuXpathHelp.Name = "BuXpathHelp";
            this.BuXpathHelp.Size = new System.Drawing.Size(208, 22);
            this.BuXpathHelp.Text = "Справка по XPATH";
            this.BuXpathHelp.Click += new System.EventHandler(this.BuXpathHelp_Click);
            // 
            // BuAbout
            // 
            this.BuAbout.Name = "BuAbout";
            this.BuAbout.Size = new System.Drawing.Size(208, 22);
            this.BuAbout.Text = "О программе";
            this.BuAbout.Click += new System.EventHandler(this.BuAbout_Click);
            // 
            // BuGithub
            // 
            this.BuGithub.Name = "BuGithub";
            this.BuGithub.Size = new System.Drawing.Size(208, 22);
            this.BuGithub.Text = "GitHub";
            this.BuGithub.Click += new System.EventHandler(this.BuGithub_Click);
            // 
            // BuDonate
            // 
            this.BuDonate.Name = "BuDonate";
            this.BuDonate.Size = new System.Drawing.Size(208, 22);
            this.BuDonate.Text = "Donate";
            this.BuDonate.Click += new System.EventHandler(this.BuDonate_Click);
            // 
            // LiTests
            // 
            this.LiTests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LiTests.FormattingEnabled = true;
            this.LiTests.ItemHeight = 15;
            this.LiTests.Location = new System.Drawing.Point(7, 67);
            this.LiTests.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LiTests.Name = "LiTests";
            this.LiTests.Size = new System.Drawing.Size(263, 379);
            this.LiTests.TabIndex = 1;
            this.LiTests.SelectedIndexChanged += new System.EventHandler(this.LiTests_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChWaitPageLoad);
            this.groupBox1.Controls.Add(this.BuPauseStepMode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.NuSlowModeMs);
            this.groupBox1.Controls.Add(this.BuTestStepModePrev);
            this.groupBox1.Controls.Add(this.BuTestRunStepMode);
            this.groupBox1.Controls.Add(this.ChSelectFoundElements);
            this.groupBox1.Controls.Add(this.ChSlowMode);
            this.groupBox1.Controls.Add(this.LaRunTime);
            this.groupBox1.Controls.Add(this.BuTestDown);
            this.groupBox1.Controls.Add(this.BuTestUp);
            this.groupBox1.Controls.Add(this.LaTestTime);
            this.groupBox1.Controls.Add(this.BuTestStop);
            this.groupBox1.Controls.Add(this.BuTestClone);
            this.groupBox1.Controls.Add(this.BuTestDelete);
            this.groupBox1.Controls.Add(this.BuTestAdd);
            this.groupBox1.Controls.Add(this.BuTestRun);
            this.groupBox1.Controls.Add(this.LiTests);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(278, 657);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автотесты";
            // 
            // ChWaitPageLoad
            // 
            this.ChWaitPageLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChWaitPageLoad.AutoSize = true;
            this.ChWaitPageLoad.Checked = true;
            this.ChWaitPageLoad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChWaitPageLoad.Location = new System.Drawing.Point(6, 453);
            this.ChWaitPageLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChWaitPageLoad.Name = "ChWaitPageLoad";
            this.ChWaitPageLoad.Size = new System.Drawing.Size(256, 21);
            this.ChWaitPageLoad.TabIndex = 19;
            this.ChWaitPageLoad.Text = "Ждать завершения загрузки страницы";
            this.ChWaitPageLoad.UseVisualStyleBackColor = true;
            // 
            // BuPauseStepMode
            // 
            this.BuPauseStepMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BuPauseStepMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuPauseStepMode.Enabled = false;
            this.BuPauseStepMode.ImageIndex = 16;
            this.BuPauseStepMode.ImageList = this.ImButtons;
            this.BuPauseStepMode.Location = new System.Drawing.Point(132, 611);
            this.BuPauseStepMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuPauseStepMode.Name = "BuPauseStepMode";
            this.BuPauseStepMode.Size = new System.Drawing.Size(41, 40);
            this.BuPauseStepMode.TabIndex = 18;
            this.ToMain.SetToolTip(this.BuPauseStepMode, "Остановить тест");
            this.BuPauseStepMode.UseVisualStyleBackColor = true;
            this.BuPauseStepMode.Click += new System.EventHandler(this.BuPauseRunStepMode_Click);
            // 
            // ImButtons
            // 
            this.ImButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImButtons.ImageStream")));
            this.ImButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.ImButtons.Images.SetKeyName(0, "icons8-add-32.png");
            this.ImButtons.Images.SetKeyName(1, "icons8-delete-view-32.png");
            this.ImButtons.Images.SetKeyName(2, "icons8-copy-32.png");
            this.ImButtons.Images.SetKeyName(3, "icons8-duplicate-32.png");
            this.ImButtons.Images.SetKeyName(4, "icons8-edit-32.png");
            this.ImButtons.Images.SetKeyName(5, "icons8-paste-32.png");
            this.ImButtons.Images.SetKeyName(6, "icons8-refresh-32.png");
            this.ImButtons.Images.SetKeyName(7, "icons8-sort-down-32.png");
            this.ImButtons.Images.SetKeyName(8, "icons8-sort-up-32.png");
            this.ImButtons.Images.SetKeyName(9, "icons8-bin-32.png");
            this.ImButtons.Images.SetKeyName(10, "icons8-decrease-font-32.png");
            this.ImButtons.Images.SetKeyName(11, "icons8-increase-font-32.png");
            this.ImButtons.Images.SetKeyName(12, "icons8-play-32.png");
            this.ImButtons.Images.SetKeyName(13, "icons8-stop-32.png");
            this.ImButtons.Images.SetKeyName(14, "icons8-end-32.png");
            this.ImButtons.Images.SetKeyName(15, "icons8-back-32.png");
            this.ImButtons.Images.SetKeyName(16, "icons8-pause-32.png");
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 525);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Задержка (мс)";
            // 
            // NuSlowModeMs
            // 
            this.NuSlowModeMs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NuSlowModeMs.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NuSlowModeMs.Location = new System.Drawing.Point(105, 523);
            this.NuSlowModeMs.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NuSlowModeMs.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NuSlowModeMs.Name = "NuSlowModeMs";
            this.NuSlowModeMs.Size = new System.Drawing.Size(165, 24);
            this.NuSlowModeMs.TabIndex = 16;
            this.NuSlowModeMs.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // BuTestStepModePrev
            // 
            this.BuTestStepModePrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuTestStepModePrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuTestStepModePrev.Enabled = false;
            this.BuTestStepModePrev.ImageIndex = 15;
            this.BuTestStepModePrev.ImageList = this.ImButtons;
            this.BuTestStepModePrev.Location = new System.Drawing.Point(181, 611);
            this.BuTestStepModePrev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuTestStepModePrev.Name = "BuTestStepModePrev";
            this.BuTestStepModePrev.Size = new System.Drawing.Size(41, 40);
            this.BuTestStepModePrev.TabIndex = 15;
            this.ToMain.SetToolTip(this.BuTestStepModePrev, "На шаг назад в режиме пошагового выполнения");
            this.BuTestStepModePrev.UseVisualStyleBackColor = true;
            this.BuTestStepModePrev.Click += new System.EventHandler(this.BuTestStepModePrev_Click);
            // 
            // BuTestRunStepMode
            // 
            this.BuTestRunStepMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuTestRunStepMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuTestRunStepMode.ImageIndex = 14;
            this.BuTestRunStepMode.ImageList = this.ImButtons;
            this.BuTestRunStepMode.Location = new System.Drawing.Point(230, 611);
            this.BuTestRunStepMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuTestRunStepMode.Name = "BuTestRunStepMode";
            this.BuTestRunStepMode.Size = new System.Drawing.Size(41, 40);
            this.BuTestRunStepMode.TabIndex = 14;
            this.ToMain.SetToolTip(this.BuTestRunStepMode, "Запустить в режиме пошагового выполнения");
            this.BuTestRunStepMode.UseVisualStyleBackColor = true;
            this.BuTestRunStepMode.Click += new System.EventHandler(this.BuTestRunStepMode_Click);
            // 
            // ChSelectFoundElements
            // 
            this.ChSelectFoundElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChSelectFoundElements.AutoSize = true;
            this.ChSelectFoundElements.Checked = true;
            this.ChSelectFoundElements.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChSelectFoundElements.Location = new System.Drawing.Point(7, 477);
            this.ChSelectFoundElements.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChSelectFoundElements.Name = "ChSelectFoundElements";
            this.ChSelectFoundElements.Size = new System.Drawing.Size(215, 21);
            this.ChSelectFoundElements.TabIndex = 13;
            this.ChSelectFoundElements.Text = "Выделять найденные элементы";
            this.ChSelectFoundElements.UseVisualStyleBackColor = true;
            // 
            // ChSlowMode
            // 
            this.ChSlowMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChSlowMode.AutoSize = true;
            this.ChSlowMode.Location = new System.Drawing.Point(7, 501);
            this.ChSlowMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChSlowMode.Name = "ChSlowMode";
            this.ChSlowMode.Size = new System.Drawing.Size(143, 21);
            this.ChSlowMode.TabIndex = 12;
            this.ChSlowMode.Text = "Медленный режим";
            this.ChSlowMode.UseVisualStyleBackColor = true;
            // 
            // LaRunTime
            // 
            this.LaRunTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LaRunTime.AutoSize = true;
            this.LaRunTime.Location = new System.Drawing.Point(8, 571);
            this.LaRunTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LaRunTime.Name = "LaRunTime";
            this.LaRunTime.Size = new System.Drawing.Size(163, 17);
            this.LaRunTime.TabIndex = 11;
            this.LaRunTime.Text = "Время выполнения общее";
            // 
            // BuTestDown
            // 
            this.BuTestDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuTestDown.ImageIndex = 7;
            this.BuTestDown.ImageList = this.ImButtons;
            this.BuTestDown.Location = new System.Drawing.Point(166, 22);
            this.BuTestDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuTestDown.Name = "BuTestDown";
            this.BuTestDown.Size = new System.Drawing.Size(41, 40);
            this.BuTestDown.TabIndex = 10;
            this.ToMain.SetToolTip(this.BuTestDown, "Переместить автотест ниже");
            this.BuTestDown.UseVisualStyleBackColor = true;
            this.BuTestDown.Click += new System.EventHandler(this.BuTestDown_Click);
            // 
            // BuTestUp
            // 
            this.BuTestUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuTestUp.ImageIndex = 8;
            this.BuTestUp.ImageList = this.ImButtons;
            this.BuTestUp.Location = new System.Drawing.Point(118, 22);
            this.BuTestUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuTestUp.Name = "BuTestUp";
            this.BuTestUp.Size = new System.Drawing.Size(41, 40);
            this.BuTestUp.TabIndex = 9;
            this.ToMain.SetToolTip(this.BuTestUp, "Переместить автотест выше");
            this.BuTestUp.UseVisualStyleBackColor = true;
            this.BuTestUp.Click += new System.EventHandler(this.BuTestUp_Click);
            // 
            // LaTestTime
            // 
            this.LaTestTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LaTestTime.AutoSize = true;
            this.LaTestTime.Location = new System.Drawing.Point(8, 554);
            this.LaTestTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LaTestTime.Name = "LaTestTime";
            this.LaTestTime.Size = new System.Drawing.Size(155, 17);
            this.LaTestTime.TabIndex = 7;
            this.LaTestTime.Text = "Время выполнения теста";
            // 
            // BuTestStop
            // 
            this.BuTestStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BuTestStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuTestStop.Enabled = false;
            this.BuTestStop.ImageIndex = 13;
            this.BuTestStop.ImageList = this.ImButtons;
            this.BuTestStop.Location = new System.Drawing.Point(56, 611);
            this.BuTestStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuTestStop.Name = "BuTestStop";
            this.BuTestStop.Size = new System.Drawing.Size(41, 40);
            this.BuTestStop.TabIndex = 6;
            this.ToMain.SetToolTip(this.BuTestStop, "Остановить тест");
            this.BuTestStop.UseVisualStyleBackColor = true;
            this.BuTestStop.Click += new System.EventHandler(this.BuTestStop_Click);
            // 
            // BuTestClone
            // 
            this.BuTestClone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuTestClone.ImageIndex = 3;
            this.BuTestClone.ImageList = this.ImButtons;
            this.BuTestClone.Location = new System.Drawing.Point(51, 22);
            this.BuTestClone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuTestClone.Name = "BuTestClone";
            this.BuTestClone.Size = new System.Drawing.Size(41, 40);
            this.BuTestClone.TabIndex = 5;
            this.ToMain.SetToolTip(this.BuTestClone, "Дублировать автотест");
            this.BuTestClone.UseVisualStyleBackColor = true;
            this.BuTestClone.Click += new System.EventHandler(this.BuTestClone_Click);
            // 
            // BuTestDelete
            // 
            this.BuTestDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuTestDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuTestDelete.ImageIndex = 9;
            this.BuTestDelete.ImageList = this.ImButtons;
            this.BuTestDelete.Location = new System.Drawing.Point(230, 22);
            this.BuTestDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuTestDelete.Name = "BuTestDelete";
            this.BuTestDelete.Size = new System.Drawing.Size(41, 40);
            this.BuTestDelete.TabIndex = 4;
            this.ToMain.SetToolTip(this.BuTestDelete, "Удалить автотест");
            this.BuTestDelete.UseVisualStyleBackColor = true;
            this.BuTestDelete.Click += new System.EventHandler(this.BuTestDelete_Click);
            // 
            // BuTestAdd
            // 
            this.BuTestAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuTestAdd.ImageIndex = 0;
            this.BuTestAdd.ImageList = this.ImButtons;
            this.BuTestAdd.Location = new System.Drawing.Point(6, 22);
            this.BuTestAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuTestAdd.Name = "BuTestAdd";
            this.BuTestAdd.Size = new System.Drawing.Size(41, 40);
            this.BuTestAdd.TabIndex = 3;
            this.ToMain.SetToolTip(this.BuTestAdd, "Добавить автотест");
            this.BuTestAdd.UseVisualStyleBackColor = true;
            this.BuTestAdd.Click += new System.EventHandler(this.BuTestAdd_Click);
            // 
            // BuTestRun
            // 
            this.BuTestRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BuTestRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuTestRun.ImageIndex = 12;
            this.BuTestRun.ImageList = this.ImButtons;
            this.BuTestRun.Location = new System.Drawing.Point(7, 611);
            this.BuTestRun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuTestRun.Name = "BuTestRun";
            this.BuTestRun.Size = new System.Drawing.Size(41, 40);
            this.BuTestRun.TabIndex = 2;
            this.ToMain.SetToolTip(this.BuTestRun, "Запустить автотест");
            this.BuTestRun.UseVisualStyleBackColor = true;
            this.BuTestRun.Click += new System.EventHandler(this.BuTestRun_Click);
            // 
            // GrTestSteps
            // 
            this.GrTestSteps.Controls.Add(this.PaMiddleDownMiddle);
            this.GrTestSteps.Controls.Add(this.PaMiddleDownDown);
            this.GrTestSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrTestSteps.Enabled = false;
            this.GrTestSteps.Location = new System.Drawing.Point(4, 0);
            this.GrTestSteps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrTestSteps.Name = "GrTestSteps";
            this.GrTestSteps.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrTestSteps.Size = new System.Drawing.Size(742, 604);
            this.GrTestSteps.TabIndex = 3;
            this.GrTestSteps.TabStop = false;
            this.GrTestSteps.Text = "Шаги";
            // 
            // PaMiddleDownMiddle
            // 
            this.PaMiddleDownMiddle.Controls.Add(this.BuStepDelete);
            this.PaMiddleDownMiddle.Controls.Add(this.BuStepAdd);
            this.PaMiddleDownMiddle.Controls.Add(this.BuStepClone);
            this.PaMiddleDownMiddle.Controls.Add(this.TrSteps);
            this.PaMiddleDownMiddle.Controls.Add(this.BuFontDecrease);
            this.PaMiddleDownMiddle.Controls.Add(this.BuFontIncrease);
            this.PaMiddleDownMiddle.Controls.Add(this.BuStepDown);
            this.PaMiddleDownMiddle.Controls.Add(this.BuStepReloadTree);
            this.PaMiddleDownMiddle.Controls.Add(this.BuStepUp);
            this.PaMiddleDownMiddle.Controls.Add(this.BuStepPaste);
            this.PaMiddleDownMiddle.Controls.Add(this.BuStepClearFocus);
            this.PaMiddleDownMiddle.Controls.Add(this.BuStepCopy);
            this.PaMiddleDownMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaMiddleDownMiddle.Location = new System.Drawing.Point(4, 20);
            this.PaMiddleDownMiddle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PaMiddleDownMiddle.Name = "PaMiddleDownMiddle";
            this.PaMiddleDownMiddle.Size = new System.Drawing.Size(734, 351);
            this.PaMiddleDownMiddle.TabIndex = 17;
            // 
            // BuStepDelete
            // 
            this.BuStepDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuStepDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuStepDelete.ImageIndex = 9;
            this.BuStepDelete.ImageList = this.ImButtons;
            this.BuStepDelete.Location = new System.Drawing.Point(689, 47);
            this.BuStepDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuStepDelete.Name = "BuStepDelete";
            this.BuStepDelete.Size = new System.Drawing.Size(41, 40);
            this.BuStepDelete.TabIndex = 5;
            this.ToMain.SetToolTip(this.BuStepDelete, "Удалить выделенный шаг [CTRL+Delete]");
            this.BuStepDelete.UseVisualStyleBackColor = true;
            this.BuStepDelete.Click += new System.EventHandler(this.BuStepDelete_Click);
            // 
            // BuStepAdd
            // 
            this.BuStepAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuStepAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuStepAdd.ImageIndex = 0;
            this.BuStepAdd.ImageList = this.ImButtons;
            this.BuStepAdd.Location = new System.Drawing.Point(643, 2);
            this.BuStepAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuStepAdd.Name = "BuStepAdd";
            this.BuStepAdd.Size = new System.Drawing.Size(41, 40);
            this.BuStepAdd.TabIndex = 4;
            this.ToMain.SetToolTip(this.BuStepAdd, "Добавить шаг [CTRL+A]");
            this.BuStepAdd.UseVisualStyleBackColor = true;
            this.BuStepAdd.Click += new System.EventHandler(this.BuStepAdd_Click);
            // 
            // BuStepClone
            // 
            this.BuStepClone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuStepClone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuStepClone.ImageIndex = 3;
            this.BuStepClone.ImageList = this.ImButtons;
            this.BuStepClone.Location = new System.Drawing.Point(689, 2);
            this.BuStepClone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuStepClone.Name = "BuStepClone";
            this.BuStepClone.Size = new System.Drawing.Size(41, 40);
            this.BuStepClone.TabIndex = 6;
            this.ToMain.SetToolTip(this.BuStepClone, "Дублировать выделенный шаг [CTRL+D]");
            this.BuStepClone.UseVisualStyleBackColor = true;
            this.BuStepClone.Click += new System.EventHandler(this.BuStepClone_Click);
            // 
            // TrSteps
            // 
            this.TrSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrSteps.ContextMenuStrip = this.MeNodes;
            this.TrSteps.HideSelection = false;
            this.TrSteps.ImageIndex = 0;
            this.TrSteps.ImageList = this.ImTree;
            this.TrSteps.Location = new System.Drawing.Point(4, 3);
            this.TrSteps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrSteps.Name = "TrSteps";
            this.TrSteps.SelectedImageIndex = 0;
            this.TrSteps.Size = new System.Drawing.Size(632, 342);
            this.TrSteps.TabIndex = 2;
            this.TrSteps.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TrSteps_ChangeExpanded);
            this.TrSteps.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TrSteps_ChangeExpanded);
            this.TrSteps.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TrSteps_NodeMouseClick);
            this.TrSteps.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TrSteps_KeyUp);
            // 
            // MeNodes
            // 
            this.MeNodes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выставитьСтатусToolStripMenuItem});
            this.MeNodes.Name = "MeNodes";
            this.MeNodes.Size = new System.Drawing.Size(169, 26);
            // 
            // выставитьСтатусToolStripMenuItem
            // 
            this.выставитьСтатусToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNotStarted,
            this.ToolStripMenuItemPassed,
            this.ToolStripMenuItemError,
            this.ToolStripMenuItemIgnoredError,
            this.ToolStripMenuItemSkipped,
            this.ToolStripMenuItemStarted});
            this.выставитьСтатусToolStripMenuItem.Name = "выставитьСтатусToolStripMenuItem";
            this.выставитьСтатусToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.выставитьСтатусToolStripMenuItem.Text = "Выставить статус";
            // 
            // ToolStripMenuItemNotStarted
            // 
            this.ToolStripMenuItemNotStarted.Name = "ToolStripMenuItemNotStarted";
            this.ToolStripMenuItemNotStarted.Size = new System.Drawing.Size(236, 22);
            this.ToolStripMenuItemNotStarted.Tag = "NotStarted";
            this.ToolStripMenuItemNotStarted.Text = "Не начат";
            this.ToolStripMenuItemNotStarted.Click += new System.EventHandler(this.MeNodesItem_Click);
            // 
            // ToolStripMenuItemPassed
            // 
            this.ToolStripMenuItemPassed.Name = "ToolStripMenuItemPassed";
            this.ToolStripMenuItemPassed.Size = new System.Drawing.Size(236, 22);
            this.ToolStripMenuItemPassed.Tag = "Passed";
            this.ToolStripMenuItemPassed.Text = "Пройден";
            this.ToolStripMenuItemPassed.Click += new System.EventHandler(this.MeNodesItem_Click);
            // 
            // ToolStripMenuItemError
            // 
            this.ToolStripMenuItemError.Name = "ToolStripMenuItemError";
            this.ToolStripMenuItemError.Size = new System.Drawing.Size(236, 22);
            this.ToolStripMenuItemError.Tag = "Error";
            this.ToolStripMenuItemError.Text = "Ошибка";
            this.ToolStripMenuItemError.Click += new System.EventHandler(this.MeNodesItem_Click);
            // 
            // ToolStripMenuItemIgnoredError
            // 
            this.ToolStripMenuItemIgnoredError.Name = "ToolStripMenuItemIgnoredError";
            this.ToolStripMenuItemIgnoredError.Size = new System.Drawing.Size(236, 22);
            this.ToolStripMenuItemIgnoredError.Tag = "IgnoredError";
            this.ToolStripMenuItemIgnoredError.Text = "Проигнорированная ошибка";
            this.ToolStripMenuItemIgnoredError.Click += new System.EventHandler(this.MeNodesItem_Click);
            // 
            // ToolStripMenuItemSkipped
            // 
            this.ToolStripMenuItemSkipped.Name = "ToolStripMenuItemSkipped";
            this.ToolStripMenuItemSkipped.Size = new System.Drawing.Size(236, 22);
            this.ToolStripMenuItemSkipped.Tag = "Skipped";
            this.ToolStripMenuItemSkipped.Text = "Скипнут";
            this.ToolStripMenuItemSkipped.Click += new System.EventHandler(this.MeNodesItem_Click);
            // 
            // ToolStripMenuItemStarted
            // 
            this.ToolStripMenuItemStarted.Name = "ToolStripMenuItemStarted";
            this.ToolStripMenuItemStarted.Size = new System.Drawing.Size(236, 22);
            this.ToolStripMenuItemStarted.Tag = "Started";
            this.ToolStripMenuItemStarted.Text = "Начат";
            this.ToolStripMenuItemStarted.Click += new System.EventHandler(this.MeNodesItem_Click);
            // 
            // ImTree
            // 
            this.ImTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImTree.ImageStream")));
            this.ImTree.TransparentColor = System.Drawing.Color.Transparent;
            this.ImTree.Images.SetKeyName(0, "icons8-right-16.png");
            this.ImTree.Images.SetKeyName(1, "icons8-folder-16.png");
            this.ImTree.Images.SetKeyName(2, "icons8-find-16.png");
            this.ImTree.Images.SetKeyName(3, "icons8-click-16.png");
            this.ImTree.Images.SetKeyName(4, "icons8-edit-16.png");
            this.ImTree.Images.SetKeyName(5, "icons8-check-16.png");
            this.ImTree.Images.SetKeyName(6, "icons8-lightning-bolt-16.png");
            this.ImTree.Images.SetKeyName(7, "icons8-save-16.png");
            this.ImTree.Images.SetKeyName(8, "icons8-stopwatch-16.png");
            this.ImTree.Images.SetKeyName(9, "icons8-open-16.png");
            this.ImTree.Images.SetKeyName(10, "icons8-user-16.png");
            // 
            // BuFontDecrease
            // 
            this.BuFontDecrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuFontDecrease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuFontDecrease.ImageIndex = 10;
            this.BuFontDecrease.ImageList = this.ImButtons;
            this.BuFontDecrease.Location = new System.Drawing.Point(689, 306);
            this.BuFontDecrease.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuFontDecrease.Name = "BuFontDecrease";
            this.BuFontDecrease.Size = new System.Drawing.Size(41, 40);
            this.BuFontDecrease.TabIndex = 14;
            this.ToMain.SetToolTip(this.BuFontDecrease, "Уменьшить размер текста в дереве");
            this.BuFontDecrease.UseVisualStyleBackColor = true;
            this.BuFontDecrease.Click += new System.EventHandler(this.BuFontDecrease_Click);
            // 
            // BuFontIncrease
            // 
            this.BuFontIncrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuFontIncrease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuFontIncrease.ImageIndex = 11;
            this.BuFontIncrease.ImageList = this.ImButtons;
            this.BuFontIncrease.Location = new System.Drawing.Point(643, 306);
            this.BuFontIncrease.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuFontIncrease.Name = "BuFontIncrease";
            this.BuFontIncrease.Size = new System.Drawing.Size(41, 40);
            this.BuFontIncrease.TabIndex = 13;
            this.ToMain.SetToolTip(this.BuFontIncrease, "Увеличить размер текста в дереве");
            this.BuFontIncrease.UseVisualStyleBackColor = true;
            this.BuFontIncrease.Click += new System.EventHandler(this.BuFontIncrease_Click);
            // 
            // BuStepDown
            // 
            this.BuStepDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuStepDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuStepDown.ImageIndex = 7;
            this.BuStepDown.ImageList = this.ImButtons;
            this.BuStepDown.Location = new System.Drawing.Point(643, 92);
            this.BuStepDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuStepDown.Name = "BuStepDown";
            this.BuStepDown.Size = new System.Drawing.Size(41, 40);
            this.BuStepDown.TabIndex = 7;
            this.ToMain.SetToolTip(this.BuStepDown, "Переместить шаг ниже [CTRL+Down]");
            this.BuStepDown.UseVisualStyleBackColor = true;
            this.BuStepDown.Click += new System.EventHandler(this.BuStepDown_Click);
            // 
            // BuStepReloadTree
            // 
            this.BuStepReloadTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuStepReloadTree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuStepReloadTree.ImageIndex = 6;
            this.BuStepReloadTree.ImageList = this.ImButtons;
            this.BuStepReloadTree.Location = new System.Drawing.Point(643, 261);
            this.BuStepReloadTree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuStepReloadTree.Name = "BuStepReloadTree";
            this.BuStepReloadTree.Size = new System.Drawing.Size(41, 40);
            this.BuStepReloadTree.TabIndex = 10;
            this.ToMain.SetToolTip(this.BuStepReloadTree, "Обновить дерево [CTRL+R]");
            this.BuStepReloadTree.UseVisualStyleBackColor = true;
            this.BuStepReloadTree.Click += new System.EventHandler(this.BuStepReloadTree_Click);
            // 
            // BuStepUp
            // 
            this.BuStepUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuStepUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuStepUp.ImageIndex = 8;
            this.BuStepUp.ImageList = this.ImButtons;
            this.BuStepUp.Location = new System.Drawing.Point(643, 47);
            this.BuStepUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuStepUp.Name = "BuStepUp";
            this.BuStepUp.Size = new System.Drawing.Size(41, 40);
            this.BuStepUp.TabIndex = 8;
            this.ToMain.SetToolTip(this.BuStepUp, "Переместить шаг выше [CTRL+Up]");
            this.BuStepUp.UseVisualStyleBackColor = true;
            this.BuStepUp.Click += new System.EventHandler(this.BuStepUp_Click);
            // 
            // BuStepPaste
            // 
            this.BuStepPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuStepPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuStepPaste.ImageIndex = 5;
            this.BuStepPaste.ImageList = this.ImButtons;
            this.BuStepPaste.Location = new System.Drawing.Point(689, 137);
            this.BuStepPaste.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuStepPaste.Name = "BuStepPaste";
            this.BuStepPaste.Size = new System.Drawing.Size(41, 40);
            this.BuStepPaste.TabIndex = 12;
            this.ToMain.SetToolTip(this.BuStepPaste, "Вставить шаг [CTRL+V]");
            this.BuStepPaste.UseVisualStyleBackColor = true;
            this.BuStepPaste.Click += new System.EventHandler(this.BuStepPaste_Click);
            // 
            // BuStepClearFocus
            // 
            this.BuStepClearFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuStepClearFocus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuStepClearFocus.ImageIndex = 1;
            this.BuStepClearFocus.ImageList = this.ImButtons;
            this.BuStepClearFocus.Location = new System.Drawing.Point(689, 92);
            this.BuStepClearFocus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuStepClearFocus.Name = "BuStepClearFocus";
            this.BuStepClearFocus.Size = new System.Drawing.Size(41, 40);
            this.BuStepClearFocus.TabIndex = 9;
            this.ToMain.SetToolTip(this.BuStepClearFocus, "Сбросить фокус с шага [Escape]");
            this.BuStepClearFocus.UseVisualStyleBackColor = true;
            this.BuStepClearFocus.Click += new System.EventHandler(this.BuStepClearFocus_Click);
            // 
            // BuStepCopy
            // 
            this.BuStepCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuStepCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuStepCopy.ImageIndex = 2;
            this.BuStepCopy.ImageList = this.ImButtons;
            this.BuStepCopy.Location = new System.Drawing.Point(643, 137);
            this.BuStepCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuStepCopy.Name = "BuStepCopy";
            this.BuStepCopy.Size = new System.Drawing.Size(41, 40);
            this.BuStepCopy.TabIndex = 11;
            this.ToMain.SetToolTip(this.BuStepCopy, "Скопировать шаг [CTRL+C]");
            this.BuStepCopy.UseVisualStyleBackColor = true;
            this.BuStepCopy.Click += new System.EventHandler(this.BuStepCopy_Click);
            // 
            // PaMiddleDownDown
            // 
            this.PaMiddleDownDown.Controls.Add(this.PaMiddleDownDownLeft);
            this.PaMiddleDownDown.Controls.Add(this.SpMiddleDownDownRight);
            this.PaMiddleDownDown.Controls.Add(this.PaMiddleDownDownRight);
            this.PaMiddleDownDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaMiddleDownDown.Location = new System.Drawing.Point(4, 371);
            this.PaMiddleDownDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PaMiddleDownDown.Name = "PaMiddleDownDown";
            this.PaMiddleDownDown.Size = new System.Drawing.Size(734, 230);
            this.PaMiddleDownDown.TabIndex = 15;
            // 
            // PaMiddleDownDownLeft
            // 
            this.PaMiddleDownDownLeft.Controls.Add(this.groupBox3);
            this.PaMiddleDownDownLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaMiddleDownDownLeft.Location = new System.Drawing.Point(0, 0);
            this.PaMiddleDownDownLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PaMiddleDownDownLeft.Name = "PaMiddleDownDownLeft";
            this.PaMiddleDownDownLeft.Size = new System.Drawing.Size(497, 230);
            this.PaMiddleDownDownLeft.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ChSkipIfElementNotFound);
            this.groupBox3.Controls.Add(this.ChStepScrollTo);
            this.groupBox3.Controls.Add(this.ChStepIgnoreParent);
            this.groupBox3.Controls.Add(this.CoStepSelectorType);
            this.groupBox3.Controls.Add(this.CoStepTypeGroup);
            this.groupBox3.Controls.Add(this.ChStepIsEnabled);
            this.groupBox3.Controls.Add(this.TeStepParameter);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.ChStepIgnoreError);
            this.groupBox3.Controls.Add(this.TeStepValue);
            this.groupBox3.Controls.Add(this.LaStepValue);
            this.groupBox3.Controls.Add(this.NuStepWait);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TeStepSelector);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.CoStepType);
            this.groupBox3.Controls.Add(this.TeStepName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(497, 230);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры шага";
            // 
            // ChSkipIfElementNotFound
            // 
            this.ChSkipIfElementNotFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChSkipIfElementNotFound.AutoSize = true;
            this.ChSkipIfElementNotFound.Location = new System.Drawing.Point(250, 22);
            this.ChSkipIfElementNotFound.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChSkipIfElementNotFound.Name = "ChSkipIfElementNotFound";
            this.ChSkipIfElementNotFound.Size = new System.Drawing.Size(162, 21);
            this.ChSkipIfElementNotFound.TabIndex = 22;
            this.ChSkipIfElementNotFound.Tag = "SkipIfElementNotFound";
            this.ChSkipIfElementNotFound.Text = "Скип, если не найдено";
            this.ToMain.SetToolTip(this.ChSkipIfElementNotFound, "Пропустить шаг, если элемент не найден");
            this.ChSkipIfElementNotFound.UseVisualStyleBackColor = true;
            this.ChSkipIfElementNotFound.Visible = false;
            this.ChSkipIfElementNotFound.CheckedChanged += new System.EventHandler(this.ChStepParameterChanged);
            // 
            // ChStepScrollTo
            // 
            this.ChStepScrollTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChStepScrollTo.AutoSize = true;
            this.ChStepScrollTo.Location = new System.Drawing.Point(416, 22);
            this.ChStepScrollTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChStepScrollTo.Name = "ChStepScrollTo";
            this.ChStepScrollTo.Size = new System.Drawing.Size(69, 21);
            this.ChStepScrollTo.TabIndex = 21;
            this.ChStepScrollTo.Tag = "ScrollTo";
            this.ChStepScrollTo.Text = "Скролл";
            this.ToMain.SetToolTip(this.ChStepScrollTo, "При нахождении элемента прокрутить страницу до него (иногда может вызывать пробле" +
        "мы с всплывающими меню)");
            this.ChStepScrollTo.UseVisualStyleBackColor = true;
            this.ChStepScrollTo.Visible = false;
            this.ChStepScrollTo.CheckedChanged += new System.EventHandler(this.ChStepParameterChanged);
            // 
            // ChStepIgnoreParent
            // 
            this.ChStepIgnoreParent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChStepIgnoreParent.AutoSize = true;
            this.ChStepIgnoreParent.Location = new System.Drawing.Point(316, 140);
            this.ChStepIgnoreParent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChStepIgnoreParent.Name = "ChStepIgnoreParent";
            this.ChStepIgnoreParent.Size = new System.Drawing.Size(169, 21);
            this.ChStepIgnoreParent.TabIndex = 20;
            this.ChStepIgnoreParent.Tag = "IgnoreParent";
            this.ChStepIgnoreParent.Text = "Игнорировать родителя";
            this.ToMain.SetToolTip(this.ChStepIgnoreParent, "Если установлено, при поиске элемента, родитель будет игнорироваться и поиск буде" +
        "т по всему документу");
            this.ChStepIgnoreParent.UseVisualStyleBackColor = true;
            this.ChStepIgnoreParent.Visible = false;
            this.ChStepIgnoreParent.CheckedChanged += new System.EventHandler(this.ChStepParameterChanged);
            // 
            // CoStepSelectorType
            // 
            this.CoStepSelectorType.FormattingEnabled = true;
            this.CoStepSelectorType.Location = new System.Drawing.Point(80, 110);
            this.CoStepSelectorType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CoStepSelectorType.Name = "CoStepSelectorType";
            this.CoStepSelectorType.Size = new System.Drawing.Size(76, 23);
            this.CoStepSelectorType.TabIndex = 19;
            this.CoStepSelectorType.Tag = "SelectorType";
            this.CoStepSelectorType.Text = "PartLink";
            this.ToMain.SetToolTip(this.CoStepSelectorType, "Способ поиска элемента");
            this.CoStepSelectorType.Visible = false;
            this.CoStepSelectorType.SelectedIndexChanged += new System.EventHandler(this.ChStepParameterChanged);
            // 
            // CoStepTypeGroup
            // 
            this.CoStepTypeGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoStepTypeGroup.FormattingEnabled = true;
            this.CoStepTypeGroup.Items.AddRange(new object[] {
            "Группа шагов",
            "Ожидать нахождения элемента",
            "Кликнуть",
            "Проверить значение",
            "Проверка нахождения элемента",
            "Ждать время"});
            this.CoStepTypeGroup.Location = new System.Drawing.Point(80, 48);
            this.CoStepTypeGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CoStepTypeGroup.Name = "CoStepTypeGroup";
            this.CoStepTypeGroup.Size = new System.Drawing.Size(238, 23);
            this.CoStepTypeGroup.TabIndex = 18;
            this.ToMain.SetToolTip(this.CoStepTypeGroup, "Группа действий");
            this.CoStepTypeGroup.SelectedIndexChanged += new System.EventHandler(this.CoStepTypeGroup_SelectedIndexChanged);
            // 
            // ChStepIsEnabled
            // 
            this.ChStepIsEnabled.AutoSize = true;
            this.ChStepIsEnabled.Location = new System.Drawing.Point(10, 22);
            this.ChStepIsEnabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChStepIsEnabled.Name = "ChStepIsEnabled";
            this.ChStepIsEnabled.Size = new System.Drawing.Size(76, 21);
            this.ChStepIsEnabled.TabIndex = 17;
            this.ChStepIsEnabled.Tag = "Enabled";
            this.ChStepIsEnabled.Text = "Активен";
            this.ToMain.SetToolTip(this.ChStepIsEnabled, "Если элемент деактивирован, то он и его дочерние элементы не будут выполняться");
            this.ChStepIsEnabled.UseVisualStyleBackColor = true;
            this.ChStepIsEnabled.CheckedChanged += new System.EventHandler(this.ChStepParameterChanged);
            // 
            // TeStepParameter
            // 
            this.TeStepParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeStepParameter.Location = new System.Drawing.Point(164, 200);
            this.TeStepParameter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TeStepParameter.Name = "TeStepParameter";
            this.TeStepParameter.Size = new System.Drawing.Size(321, 24);
            this.TeStepParameter.TabIndex = 16;
            this.TeStepParameter.Tag = "Parameter";
            this.ToMain.SetToolTip(this.TeStepParameter, "Название параметра (без %)");
            this.TeStepParameter.Visible = false;
            this.TeStepParameter.TextChanged += new System.EventHandler(this.ChStepParameterChanged);
            this.TeStepParameter.Leave += new System.EventHandler(this.Control_FocusLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Параметр";
            // 
            // ChStepIgnoreError
            // 
            this.ChStepIgnoreError.AutoSize = true;
            this.ChStepIgnoreError.Location = new System.Drawing.Point(97, 22);
            this.ChStepIgnoreError.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChStepIgnoreError.Name = "ChStepIgnoreError";
            this.ChStepIgnoreError.Size = new System.Drawing.Size(158, 21);
            this.ChStepIgnoreError.TabIndex = 14;
            this.ChStepIgnoreError.Tag = "IgnoreError";
            this.ChStepIgnoreError.Text = "Игнорировать ошибку";
            this.ToMain.SetToolTip(this.ChStepIgnoreError, "Если стоит игнорирование ошибки - выполнение теста не прервется, а пункт будет по" +
        "мечен желтым, вместо красного");
            this.ChStepIgnoreError.UseVisualStyleBackColor = true;
            this.ChStepIgnoreError.Visible = false;
            this.ChStepIgnoreError.CheckedChanged += new System.EventHandler(this.ChStepParameterChanged);
            // 
            // TeStepValue
            // 
            this.TeStepValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeStepValue.Location = new System.Drawing.Point(164, 170);
            this.TeStepValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TeStepValue.Name = "TeStepValue";
            this.TeStepValue.Size = new System.Drawing.Size(321, 24);
            this.TeStepValue.TabIndex = 11;
            this.TeStepValue.Tag = "Value";
            this.ToMain.SetToolTip(this.TeStepValue, "Значение, которое надо установить или проверить (также выполняет роль второго пар" +
        "аметра для сравнения двух параметров)");
            this.TeStepValue.Visible = false;
            this.TeStepValue.TextChanged += new System.EventHandler(this.ChStepParameterChanged);
            this.TeStepValue.Leave += new System.EventHandler(this.Control_FocusLeave);
            // 
            // LaStepValue
            // 
            this.LaStepValue.AutoSize = true;
            this.LaStepValue.Location = new System.Drawing.Point(7, 173);
            this.LaStepValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LaStepValue.Name = "LaStepValue";
            this.LaStepValue.Size = new System.Drawing.Size(65, 17);
            this.LaStepValue.TabIndex = 10;
            this.LaStepValue.Text = "Значение";
            // 
            // NuStepWait
            // 
            this.NuStepWait.DecimalPlaces = 3;
            this.NuStepWait.Location = new System.Drawing.Point(164, 140);
            this.NuStepWait.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NuStepWait.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.NuStepWait.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.NuStepWait.Name = "NuStepWait";
            this.NuStepWait.Size = new System.Drawing.Size(92, 24);
            this.NuStepWait.TabIndex = 9;
            this.NuStepWait.Tag = "SecondsToWait";
            this.ToMain.SetToolTip(this.NuStepWait, "Время поиска элемента");
            this.NuStepWait.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NuStepWait.Visible = false;
            this.NuStepWait.ValueChanged += new System.EventHandler(this.ChStepParameterChanged);
            this.NuStepWait.Leave += new System.EventHandler(this.Control_FocusLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Время ожидания (сек)";
            // 
            // TeStepSelector
            // 
            this.TeStepSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeStepSelector.Location = new System.Drawing.Point(164, 110);
            this.TeStepSelector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TeStepSelector.Name = "TeStepSelector";
            this.TeStepSelector.Size = new System.Drawing.Size(321, 24);
            this.TeStepSelector.TabIndex = 7;
            this.TeStepSelector.Tag = "Selector";
            this.ToMain.SetToolTip(this.TeStepSelector, "Адрес элемента");
            this.TeStepSelector.Visible = false;
            this.TeStepSelector.TextChanged += new System.EventHandler(this.ChStepParameterChanged);
            this.TeStepSelector.Leave += new System.EventHandler(this.Control_FocusLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Селектор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тип";
            // 
            // CoStepType
            // 
            this.CoStepType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CoStepType.FormattingEnabled = true;
            this.CoStepType.Items.AddRange(new object[] {
            "Группа шагов",
            "Ожидать нахождения элемента",
            "Кликнуть",
            "Проверить значение",
            "Проверка нахождения элемента",
            "Ждать время"});
            this.CoStepType.Location = new System.Drawing.Point(326, 48);
            this.CoStepType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CoStepType.Name = "CoStepType";
            this.CoStepType.Size = new System.Drawing.Size(159, 23);
            this.CoStepType.TabIndex = 4;
            this.ToMain.SetToolTip(this.CoStepType, "Действие");
            this.CoStepType.SelectedIndexChanged += new System.EventHandler(this.CoStepType_SelectedIndexChanged);
            // 
            // TeStepName
            // 
            this.TeStepName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeStepName.Location = new System.Drawing.Point(80, 80);
            this.TeStepName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TeStepName.Name = "TeStepName";
            this.TeStepName.Size = new System.Drawing.Size(405, 24);
            this.TeStepName.TabIndex = 3;
            this.TeStepName.Tag = "Name";
            this.TeStepName.Text = "Name";
            this.ToMain.SetToolTip(this.TeStepName, "Название действия для отображения в дереве");
            this.TeStepName.TextChanged += new System.EventHandler(this.ChStepParameterChanged);
            this.TeStepName.Leave += new System.EventHandler(this.Control_FocusLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // SpMiddleDownDownRight
            // 
            this.SpMiddleDownDownRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.SpMiddleDownDownRight.Location = new System.Drawing.Point(497, 0);
            this.SpMiddleDownDownRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SpMiddleDownDownRight.Name = "SpMiddleDownDownRight";
            this.SpMiddleDownDownRight.Size = new System.Drawing.Size(4, 230);
            this.SpMiddleDownDownRight.TabIndex = 6;
            this.SpMiddleDownDownRight.TabStop = false;
            // 
            // PaMiddleDownDownRight
            // 
            this.PaMiddleDownDownRight.Controls.Add(this.groupBox4);
            this.PaMiddleDownDownRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PaMiddleDownDownRight.Location = new System.Drawing.Point(501, 0);
            this.PaMiddleDownDownRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PaMiddleDownDownRight.Name = "PaMiddleDownDownRight";
            this.PaMiddleDownDownRight.Size = new System.Drawing.Size(233, 230);
            this.PaMiddleDownDownRight.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RiLog);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(233, 230);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Лог шага";
            // 
            // RiLog
            // 
            this.RiLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RiLog.Location = new System.Drawing.Point(7, 22);
            this.RiLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RiLog.Name = "RiLog";
            this.RiLog.Size = new System.Drawing.Size(219, 200);
            this.RiLog.TabIndex = 0;
            this.RiLog.Text = "";
            // 
            // TeTestName
            // 
            this.TeTestName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeTestName.Location = new System.Drawing.Point(80, 22);
            this.TeTestName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TeTestName.Name = "TeTestName";
            this.TeTestName.Size = new System.Drawing.Size(433, 24);
            this.TeTestName.TabIndex = 1;
            this.TeTestName.TextChanged += new System.EventHandler(this.TeTestName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // GrTestParameters
            // 
            this.GrTestParameters.Controls.Add(this.BuTestParametersUp);
            this.GrTestParameters.Controls.Add(this.BuTestParametersDown);
            this.GrTestParameters.Controls.Add(this.ChTestRegenerateParameters);
            this.GrTestParameters.Controls.Add(this.BuTestGenerateParameters);
            this.GrTestParameters.Controls.Add(this.DaTestParameters);
            this.GrTestParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrTestParameters.Enabled = false;
            this.GrTestParameters.Location = new System.Drawing.Point(0, 0);
            this.GrTestParameters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrTestParameters.Name = "GrTestParameters";
            this.GrTestParameters.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrTestParameters.Size = new System.Drawing.Size(358, 222);
            this.GrTestParameters.TabIndex = 13;
            this.GrTestParameters.TabStop = false;
            this.GrTestParameters.Text = "Параметры теста";
            // 
            // BuTestParametersUp
            // 
            this.BuTestParametersUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuTestParametersUp.ImageIndex = 8;
            this.BuTestParametersUp.ImageList = this.ImButtons;
            this.BuTestParametersUp.Location = new System.Drawing.Point(212, 176);
            this.BuTestParametersUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuTestParametersUp.Name = "BuTestParametersUp";
            this.BuTestParametersUp.Size = new System.Drawing.Size(41, 40);
            this.BuTestParametersUp.TabIndex = 10;
            this.ToMain.SetToolTip(this.BuTestParametersUp, "Передвинуть строку с параметром теста выше");
            this.BuTestParametersUp.UseVisualStyleBackColor = true;
            this.BuTestParametersUp.Click += new System.EventHandler(this.BuTestParametersUp_Click);
            // 
            // BuTestParametersDown
            // 
            this.BuTestParametersDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuTestParametersDown.ImageIndex = 7;
            this.BuTestParametersDown.ImageList = this.ImButtons;
            this.BuTestParametersDown.Location = new System.Drawing.Point(261, 176);
            this.BuTestParametersDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuTestParametersDown.Name = "BuTestParametersDown";
            this.BuTestParametersDown.Size = new System.Drawing.Size(41, 40);
            this.BuTestParametersDown.TabIndex = 9;
            this.ToMain.SetToolTip(this.BuTestParametersDown, "Передвинуть строку с параметром теста ниже");
            this.BuTestParametersDown.UseVisualStyleBackColor = true;
            this.BuTestParametersDown.Click += new System.EventHandler(this.BuTestParametersDown_Click);
            // 
            // ChTestRegenerateParameters
            // 
            this.ChTestRegenerateParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChTestRegenerateParameters.AutoSize = true;
            this.ChTestRegenerateParameters.Location = new System.Drawing.Point(7, 195);
            this.ChTestRegenerateParameters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChTestRegenerateParameters.Name = "ChTestRegenerateParameters";
            this.ChTestRegenerateParameters.Size = new System.Drawing.Size(117, 21);
            this.ChTestRegenerateParameters.TabIndex = 6;
            this.ChTestRegenerateParameters.Text = "Автогенерация";
            this.ToMain.SetToolTip(this.ChTestRegenerateParameters, "Генерировать параметры теста автоматически при запуске автотеста");
            this.ChTestRegenerateParameters.UseVisualStyleBackColor = true;
            this.ChTestRegenerateParameters.CheckedChanged += new System.EventHandler(this.ChTestRegenerateParameters_CheckedChanged);
            // 
            // BuTestGenerateParameters
            // 
            this.BuTestGenerateParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuTestGenerateParameters.ImageIndex = 6;
            this.BuTestGenerateParameters.ImageList = this.ImButtons;
            this.BuTestGenerateParameters.Location = new System.Drawing.Point(310, 176);
            this.BuTestGenerateParameters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuTestGenerateParameters.Name = "BuTestGenerateParameters";
            this.BuTestGenerateParameters.Size = new System.Drawing.Size(41, 40);
            this.BuTestGenerateParameters.TabIndex = 5;
            this.ToMain.SetToolTip(this.BuTestGenerateParameters, "Перегенерировать параметры теста");
            this.BuTestGenerateParameters.UseVisualStyleBackColor = true;
            this.BuTestGenerateParameters.Click += new System.EventHandler(this.BuTestGenerateParameters_Click);
            // 
            // DaTestParameters
            // 
            this.DaTestParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DaTestParameters.BackgroundColor = System.Drawing.Color.White;
            this.DaTestParameters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DaTestParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaTestParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoTestParameterName,
            this.CoTestParametersPattern,
            this.CoTestParameterValue});
            this.DaTestParameters.EnableHeadersVisualStyles = false;
            this.DaTestParameters.Location = new System.Drawing.Point(7, 18);
            this.DaTestParameters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DaTestParameters.Name = "DaTestParameters";
            this.DaTestParameters.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DaTestParameters.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DaTestParameters.Size = new System.Drawing.Size(344, 152);
            this.DaTestParameters.TabIndex = 0;
            this.DaTestParameters.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaTestParameters_CellEndEdit);
            this.DaTestParameters.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DaTestParameters_RowsRemoved);
            // 
            // CoTestParameterName
            // 
            this.CoTestParameterName.HeaderText = "Название";
            this.CoTestParameterName.Name = "CoTestParameterName";
            this.CoTestParameterName.Width = 80;
            // 
            // CoTestParametersPattern
            // 
            this.CoTestParametersPattern.HeaderText = "Шаблон/Значение";
            this.CoTestParametersPattern.Name = "CoTestParametersPattern";
            this.CoTestParametersPattern.Width = 110;
            // 
            // CoTestParameterValue
            // 
            this.CoTestParameterValue.HeaderText = "Итог";
            this.CoTestParameterValue.Name = "CoTestParameterValue";
            this.CoTestParameterValue.ReadOnly = true;
            this.CoTestParameterValue.Width = 110;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BuProjectParametersUp);
            this.groupBox5.Controls.Add(this.BuProjectParametersDown);
            this.groupBox5.Controls.Add(this.ChProjectRegenerateParameters);
            this.groupBox5.Controls.Add(this.BuProjectGenerateParameters);
            this.groupBox5.Controls.Add(this.DaProjectParameters);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(358, 432);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Параметры проекта";
            // 
            // BuProjectParametersUp
            // 
            this.BuProjectParametersUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuProjectParametersUp.ImageIndex = 8;
            this.BuProjectParametersUp.ImageList = this.ImButtons;
            this.BuProjectParametersUp.Location = new System.Drawing.Point(212, 386);
            this.BuProjectParametersUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuProjectParametersUp.Name = "BuProjectParametersUp";
            this.BuProjectParametersUp.Size = new System.Drawing.Size(41, 40);
            this.BuProjectParametersUp.TabIndex = 8;
            this.ToMain.SetToolTip(this.BuProjectParametersUp, "Передвинуть строку с параметром проекта выше");
            this.BuProjectParametersUp.UseVisualStyleBackColor = true;
            this.BuProjectParametersUp.Click += new System.EventHandler(this.BuProjectParametersUp_Click);
            // 
            // BuProjectParametersDown
            // 
            this.BuProjectParametersDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuProjectParametersDown.ImageIndex = 7;
            this.BuProjectParametersDown.ImageList = this.ImButtons;
            this.BuProjectParametersDown.Location = new System.Drawing.Point(261, 386);
            this.BuProjectParametersDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuProjectParametersDown.Name = "BuProjectParametersDown";
            this.BuProjectParametersDown.Size = new System.Drawing.Size(41, 40);
            this.BuProjectParametersDown.TabIndex = 7;
            this.ToMain.SetToolTip(this.BuProjectParametersDown, "Передвинуть строку с параметром проекта ниже");
            this.BuProjectParametersDown.UseVisualStyleBackColor = true;
            this.BuProjectParametersDown.Click += new System.EventHandler(this.BuProjectParametersDown_Click);
            // 
            // ChProjectRegenerateParameters
            // 
            this.ChProjectRegenerateParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChProjectRegenerateParameters.AutoSize = true;
            this.ChProjectRegenerateParameters.Location = new System.Drawing.Point(7, 405);
            this.ChProjectRegenerateParameters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChProjectRegenerateParameters.Name = "ChProjectRegenerateParameters";
            this.ChProjectRegenerateParameters.Size = new System.Drawing.Size(117, 21);
            this.ChProjectRegenerateParameters.TabIndex = 6;
            this.ChProjectRegenerateParameters.Text = "Автогенерация";
            this.ToMain.SetToolTip(this.ChProjectRegenerateParameters, "Генерировать параметры проекта автоматически при запуске автотеста");
            this.ChProjectRegenerateParameters.UseVisualStyleBackColor = true;
            this.ChProjectRegenerateParameters.CheckedChanged += new System.EventHandler(this.ChProjectRegenerateParameters_CheckedChanged);
            // 
            // BuProjectGenerateParameters
            // 
            this.BuProjectGenerateParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuProjectGenerateParameters.ImageIndex = 6;
            this.BuProjectGenerateParameters.ImageList = this.ImButtons;
            this.BuProjectGenerateParameters.Location = new System.Drawing.Point(310, 386);
            this.BuProjectGenerateParameters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuProjectGenerateParameters.Name = "BuProjectGenerateParameters";
            this.BuProjectGenerateParameters.Size = new System.Drawing.Size(41, 40);
            this.BuProjectGenerateParameters.TabIndex = 5;
            this.ToMain.SetToolTip(this.BuProjectGenerateParameters, "Перегенерировать параметры проекта");
            this.BuProjectGenerateParameters.UseVisualStyleBackColor = true;
            this.BuProjectGenerateParameters.Click += new System.EventHandler(this.BuProjectGenerateParameters_Click);
            // 
            // DaProjectParameters
            // 
            this.DaProjectParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DaProjectParameters.BackgroundColor = System.Drawing.Color.White;
            this.DaProjectParameters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DaProjectParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaProjectParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.DaProjectParameters.EnableHeadersVisualStyles = false;
            this.DaProjectParameters.Location = new System.Drawing.Point(7, 18);
            this.DaProjectParameters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DaProjectParameters.Name = "DaProjectParameters";
            this.DaProjectParameters.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DaProjectParameters.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DaProjectParameters.Size = new System.Drawing.Size(344, 362);
            this.DaProjectParameters.TabIndex = 0;
            this.DaProjectParameters.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaProjectParameters_CellEndEdit);
            this.DaProjectParameters.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DaProjectParameters_RowsRemoved);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Шаблон/Значение";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Итог";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // GrTestSettings
            // 
            this.GrTestSettings.Controls.Add(this.ChTestRunAfterPrevious);
            this.GrTestSettings.Controls.Add(this.TeTestName);
            this.GrTestSettings.Controls.Add(this.label1);
            this.GrTestSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrTestSettings.Enabled = false;
            this.GrTestSettings.Location = new System.Drawing.Point(4, 0);
            this.GrTestSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrTestSettings.Name = "GrTestSettings";
            this.GrTestSettings.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrTestSettings.Size = new System.Drawing.Size(742, 53);
            this.GrTestSettings.TabIndex = 15;
            this.GrTestSettings.TabStop = false;
            this.GrTestSettings.Text = "Настройки теста";
            // 
            // ChTestRunAfterPrevious
            // 
            this.ChTestRunAfterPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChTestRunAfterPrevious.AutoSize = true;
            this.ChTestRunAfterPrevious.Location = new System.Drawing.Point(529, 24);
            this.ChTestRunAfterPrevious.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChTestRunAfterPrevious.Name = "ChTestRunAfterPrevious";
            this.ChTestRunAfterPrevious.Size = new System.Drawing.Size(207, 21);
            this.ChTestRunAfterPrevious.TabIndex = 2;
            this.ChTestRunAfterPrevious.Text = "Запускать после предыдущего";
            this.ChTestRunAfterPrevious.UseVisualStyleBackColor = true;
            this.ChTestRunAfterPrevious.CheckedChanged += new System.EventHandler(this.ChTestRunAfterPrevious_CheckedChanged);
            // 
            // PaRight
            // 
            this.PaRight.Controls.Add(this.PaRightUp);
            this.PaRight.Controls.Add(this.SpRightDown);
            this.PaRight.Controls.Add(this.PaRightDown);
            this.PaRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PaRight.Location = new System.Drawing.Point(1028, 24);
            this.PaRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PaRight.Name = "PaRight";
            this.PaRight.Size = new System.Drawing.Size(358, 657);
            this.PaRight.TabIndex = 17;
            // 
            // PaRightUp
            // 
            this.PaRightUp.Controls.Add(this.groupBox5);
            this.PaRightUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaRightUp.Location = new System.Drawing.Point(0, 0);
            this.PaRightUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PaRightUp.Name = "PaRightUp";
            this.PaRightUp.Size = new System.Drawing.Size(358, 432);
            this.PaRightUp.TabIndex = 17;
            // 
            // SpRightDown
            // 
            this.SpRightDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SpRightDown.Location = new System.Drawing.Point(0, 432);
            this.SpRightDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SpRightDown.Name = "SpRightDown";
            this.SpRightDown.Size = new System.Drawing.Size(358, 3);
            this.SpRightDown.TabIndex = 16;
            this.SpRightDown.TabStop = false;
            // 
            // PaRightDown
            // 
            this.PaRightDown.Controls.Add(this.GrTestParameters);
            this.PaRightDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaRightDown.Location = new System.Drawing.Point(0, 435);
            this.PaRightDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PaRightDown.Name = "PaRightDown";
            this.PaRightDown.Size = new System.Drawing.Size(358, 222);
            this.PaRightDown.TabIndex = 15;
            // 
            // PaMiddle
            // 
            this.PaMiddle.Controls.Add(this.PaMIddleDown);
            this.PaMiddle.Controls.Add(this.PaMiddleUp);
            this.PaMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaMiddle.Location = new System.Drawing.Point(278, 24);
            this.PaMiddle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PaMiddle.Name = "PaMiddle";
            this.PaMiddle.Size = new System.Drawing.Size(746, 657);
            this.PaMiddle.TabIndex = 2;
            // 
            // PaMIddleDown
            // 
            this.PaMIddleDown.Controls.Add(this.GrTestSteps);
            this.PaMIddleDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaMIddleDown.Location = new System.Drawing.Point(0, 53);
            this.PaMIddleDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PaMIddleDown.Name = "PaMIddleDown";
            this.PaMIddleDown.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.PaMIddleDown.Size = new System.Drawing.Size(746, 604);
            this.PaMIddleDown.TabIndex = 17;
            // 
            // PaMiddleUp
            // 
            this.PaMiddleUp.Controls.Add(this.GrTestSettings);
            this.PaMiddleUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaMiddleUp.Location = new System.Drawing.Point(0, 0);
            this.PaMiddleUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PaMiddleUp.Name = "PaMiddleUp";
            this.PaMiddleUp.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.PaMiddleUp.Size = new System.Drawing.Size(746, 53);
            this.PaMiddleUp.TabIndex = 16;
            // 
            // SpRight
            // 
            this.SpRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.SpRight.Location = new System.Drawing.Point(1024, 24);
            this.SpRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SpRight.Name = "SpRight";
            this.SpRight.Size = new System.Drawing.Size(4, 657);
            this.SpRight.TabIndex = 21;
            this.SpRight.TabStop = false;
            // 
            // PaLeft
            // 
            this.PaLeft.Controls.Add(this.groupBox1);
            this.PaLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PaLeft.Location = new System.Drawing.Point(0, 24);
            this.PaLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PaLeft.Name = "PaLeft";
            this.PaLeft.Size = new System.Drawing.Size(278, 657);
            this.PaLeft.TabIndex = 22;
            // 
            // SpLeft
            // 
            this.SpLeft.Location = new System.Drawing.Point(278, 24);
            this.SpLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SpLeft.Name = "SpLeft";
            this.SpLeft.Size = new System.Drawing.Size(4, 657);
            this.SpLeft.TabIndex = 23;
            this.SpLeft.TabStop = false;
            // 
            // BuBoosty
            // 
            this.BuBoosty.Name = "BuBoosty";
            this.BuBoosty.Size = new System.Drawing.Size(208, 22);
            this.BuBoosty.Text = "Boosty";
            this.BuBoosty.Click += new System.EventHandler(this.BuBoosty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 681);
            this.Controls.Add(this.SpLeft);
            this.Controls.Add(this.PaMiddle);
            this.Controls.Add(this.PaLeft);
            this.Controls.Add(this.SpRight);
            this.Controls.Add(this.PaRight);
            this.Controls.Add(this.MeMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MeMain;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.Text = "Selenium Autotest IDE by alextrof94";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MeMain.ResumeLayout(false);
            this.MeMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuSlowModeMs)).EndInit();
            this.GrTestSteps.ResumeLayout(false);
            this.PaMiddleDownMiddle.ResumeLayout(false);
            this.MeNodes.ResumeLayout(false);
            this.PaMiddleDownDown.ResumeLayout(false);
            this.PaMiddleDownDownLeft.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuStepWait)).EndInit();
            this.PaMiddleDownDownRight.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.GrTestParameters.ResumeLayout(false);
            this.GrTestParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaTestParameters)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaProjectParameters)).EndInit();
            this.GrTestSettings.ResumeLayout(false);
            this.GrTestSettings.PerformLayout();
            this.PaRight.ResumeLayout(false);
            this.PaRightUp.ResumeLayout(false);
            this.PaRightDown.ResumeLayout(false);
            this.PaMiddle.ResumeLayout(false);
            this.PaMIddleDown.ResumeLayout(false);
            this.PaMiddleUp.ResumeLayout(false);
            this.PaLeft.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MeMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem BuFileSave;
        private System.Windows.Forms.ListBox LiTests;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BuTestDelete;
        private System.Windows.Forms.Button BuTestAdd;
        private System.Windows.Forms.Button BuTestRun;
        private System.Windows.Forms.GroupBox GrTestSteps;
        private System.Windows.Forms.TreeView TrSteps;
        private System.Windows.Forms.TextBox TeTestName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CoStepType;
        private System.Windows.Forms.TextBox TeStepName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BuTestClone;
        private System.Windows.Forms.Button BuStepDelete;
        private System.Windows.Forms.Button BuStepAdd;
        private System.Windows.Forms.Button BuStepClone;
        private System.Windows.Forms.ToolStripMenuItem BuFileImport;
        private System.Windows.Forms.TextBox TeStepSelector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NuStepWait;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TeStepValue;
        private System.Windows.Forms.Label LaStepValue;
        private System.Windows.Forms.RichTextBox RiLog;
        private System.Windows.Forms.Button BuStepUp;
        private System.Windows.Forms.Button BuStepDown;
        private System.Windows.Forms.Button BuTestStop;
        private System.Windows.Forms.Button BuStepClearFocus;
        private System.Windows.Forms.Button BuStepReloadTree;
        private System.Windows.Forms.Label LaTestTime;
        private System.Windows.Forms.ImageList ImTree;
        private System.Windows.Forms.Button BuStepPaste;
        private System.Windows.Forms.Button BuStepCopy;
        private System.Windows.Forms.CheckBox ChStepIgnoreError;
        private System.Windows.Forms.ToolStripMenuItem BuFileOpenLast;
        private System.Windows.Forms.GroupBox GrTestParameters;
        private System.Windows.Forms.DataGridView DaTestParameters;
        private System.Windows.Forms.Button BuTestGenerateParameters;
        private System.Windows.Forms.CheckBox ChTestRegenerateParameters;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox ChProjectRegenerateParameters;
        private System.Windows.Forms.Button BuProjectGenerateParameters;
        private System.Windows.Forms.DataGridView DaProjectParameters;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoTestParameterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoTestParametersPattern;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoTestParameterValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox GrTestSettings;
        private System.Windows.Forms.CheckBox ChTestRunAfterPrevious;
        private System.Windows.Forms.TextBox TeStepParameter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip ToMain;
        private System.Windows.Forms.ImageList ImButtons;
        private System.Windows.Forms.Button BuFontDecrease;
        private System.Windows.Forms.Button BuFontIncrease;
        private System.Windows.Forms.Button BuTestDown;
        private System.Windows.Forms.Button BuTestUp;
        private System.Windows.Forms.ToolStripMenuItem инфоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuCantDownloadDriverHelp;
        private System.Windows.Forms.Label LaRunTime;
        private System.Windows.Forms.CheckBox ChStepIsEnabled;
        private System.Windows.Forms.CheckBox ChSlowMode;
        private System.Windows.Forms.CheckBox ChSelectFoundElements;
        private System.Windows.Forms.ToolStripMenuItem BuTestParametersHelp;
        private System.Windows.Forms.Panel PaRight;
        private System.Windows.Forms.Panel PaMiddle;
        private System.Windows.Forms.Panel PaMiddleDownDown;
        private System.Windows.Forms.Panel PaMiddleDownMiddle;
        private System.Windows.Forms.ComboBox CoStepTypeGroup;
        private System.Windows.Forms.ComboBox CoStepSelectorType;
        private System.Windows.Forms.Splitter SpRight;
        private System.Windows.Forms.Panel PaLeft;
        private System.Windows.Forms.Panel PaRightUp;
        private System.Windows.Forms.Splitter SpRightDown;
        private System.Windows.Forms.Panel PaRightDown;
        private System.Windows.Forms.Panel PaMiddleUp;
        private System.Windows.Forms.Splitter SpLeft;
        private System.Windows.Forms.Panel PaMIddleDown;
        private System.Windows.Forms.Panel PaMiddleDownDownLeft;
        private System.Windows.Forms.Splitter SpMiddleDownDownRight;
        private System.Windows.Forms.Panel PaMiddleDownDownRight;
        private System.Windows.Forms.Button BuTestRunStepMode;
        private System.Windows.Forms.Button BuTestStepModePrev;
        private System.Windows.Forms.ToolStripMenuItem BuXpathHelp;
        private System.Windows.Forms.ToolStripMenuItem BuAbout;
        private System.Windows.Forms.ToolStripMenuItem BuGithub;
        private System.Windows.Forms.ToolStripMenuItem BuDonate;
        private System.Windows.Forms.Button BuTestParametersUp;
        private System.Windows.Forms.Button BuTestParametersDown;
        private System.Windows.Forms.Button BuProjectParametersUp;
        private System.Windows.Forms.Button BuProjectParametersDown;
        private System.Windows.Forms.CheckBox ChStepIgnoreParent;
        private System.Windows.Forms.CheckBox ChStepScrollTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NuSlowModeMs;
        private System.Windows.Forms.Button BuPauseStepMode;
        private System.Windows.Forms.CheckBox ChWaitPageLoad;
        private System.Windows.Forms.CheckBox ChSkipIfElementNotFound;
        private System.Windows.Forms.ContextMenuStrip MeNodes;
        private System.Windows.Forms.ToolStripMenuItem выставитьСтатусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNotStarted;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStarted;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPassed;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemError;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemIgnoredError;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSkipped;
        private System.Windows.Forms.ToolStripMenuItem BuBoosty;
    }
}

