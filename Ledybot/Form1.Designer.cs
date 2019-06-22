namespace Ledybot
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.lv_log = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Trainer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NickName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pkmnSent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.page = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Export = new System.Windows.Forms.Button();
            this.cb_Blacklist = new System.Windows.Forms.CheckBox();
            this.tc_Control = new System.Windows.Forms.TabControl();
            this.tp_GTS = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_tradeCooldown = new System.Windows.Forms.TextBox();
            this.cb_Tradequeue = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_Reddit = new System.Windows.Forms.CheckBox();
            this.tb_thread = new System.Windows.Forms.TextBox();
            this.combo_levelrange = new System.Windows.Forms.ComboBox();
            this.combo_gender = new System.Windows.Forms.ComboBox();
            this.combo_pkmnList = new System.Windows.Forms.ComboBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Banlist = new System.Windows.Forms.Button();
            this.btn_ShowPaths = new System.Windows.Forms.Button();
            this.tp_tradeErrors = new System.Windows.Forms.TabPage();
            this.lv_failedList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tp_Injection = new System.Windows.Forms.TabPage();
            this.btn_WCDelete = new System.Windows.Forms.Button();
            this.btn_WCInject = new System.Windows.Forms.Button();
            this.nud_SlotWCInjection = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_BrowseWCInject = new System.Windows.Forms.Button();
            this.tb_WCInjection = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.nud_CountInjection = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Inject = new System.Windows.Forms.Button();
            this.nud_SlotInjection = new System.Windows.Forms.NumericUpDown();
            this.nud_BoxInjection = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_BrowseInject = new System.Windows.Forms.Button();
            this.tb_FileInjection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tp_Breeding = new System.Windows.Forms.TabPage();
            this.btn_EggStop = new System.Windows.Forms.Button();
            this.btn_EggStart = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_EggAvailable = new System.Windows.Forms.Button();
            this.tb_Settings = new System.Windows.Forms.TabPage();
            this.cb_UseLedySync = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_LedySyncPort = new System.Windows.Forms.TextBox();
            this.tb_LedySyncIP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_consoleName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_waittime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_frontfpo = new System.Windows.Forms.RadioButton();
            this.rb_front = new System.Windows.Forms.RadioButton();
            this.rb_back = new System.Windows.Forms.RadioButton();
            this.nud_DefaultCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Subreddit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gb_connectionBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_apiPort = new System.Windows.Forms.TextBox();
            this.tb_apiIP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_removeConnection = new System.Windows.Forms.Button();
            this.lv_ServerList = new System.Windows.Forms.ListView();
            this.col_hostname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_connectionStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_Console = new System.Windows.Forms.TabPage();
            this.btn_SendCommand = new System.Windows.Forms.Button();
            this.tb_ConsoleCommand = new System.Windows.Forms.TextBox();
            this.rtb_Console = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fcList = new System.Windows.Forms.TabPage();
            this.lv_fc = new System.Windows.Forms.ListView();
            this.cl_FC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ofd_Injection = new System.Windows.Forms.OpenFileDialog();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.disconnectTimer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ofd_WCInjection = new System.Windows.Forms.OpenFileDialog();
            this.rt_status = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_x = new System.Windows.Forms.Button();
            this.btn_y = new System.Windows.Forms.Button();
            this.btn_a = new System.Windows.Forms.Button();
            this.btn_b = new System.Windows.Forms.Button();
            this.btn_lBump = new System.Windows.Forms.Button();
            this.btn_rBump = new System.Windows.Forms.Button();
            this.btnButtonStart = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.tc_Control.SuspendLayout();
            this.tp_GTS.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tp_tradeErrors.SuspendLayout();
            this.tp_Injection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SlotWCInjection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CountInjection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SlotInjection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BoxInjection)).BeginInit();
            this.tp_Breeding.SuspendLayout();
            this.tb_Settings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_DefaultCount)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.gb_connectionBox.SuspendLayout();
            this.tb_Console.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.fcList.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_IP
            // 
            this.tb_IP.Location = new System.Drawing.Point(13, 13);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(100, 20);
            this.tb_IP.TabIndex = 0;
            this.tb_IP.Text = "192.168.1.19";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(119, 13);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 20);
            this.btn_Connect.TabIndex = 5;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Deposited Pokemon:";
            // 
            // btn_Start
            // 
            this.btn_Start.Enabled = false;
            this.btn_Start.Location = new System.Drawing.Point(3, 45);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(58, 23);
            this.btn_Start.TabIndex = 16;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Location = new System.Drawing.Point(67, 45);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(58, 23);
            this.btn_Stop.TabIndex = 17;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // lv_log
            // 
            this.lv_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Trainer,
            this.NickName,
            this.Country,
            this.subRegion,
            this.pkmnSent,
            this.FC,
            this.page,
            this.index});
            this.lv_log.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lv_log.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_log.HideSelection = false;
            this.lv_log.Location = new System.Drawing.Point(6, 153);
            this.lv_log.Name = "lv_log";
            this.lv_log.Size = new System.Drawing.Size(353, 282);
            this.lv_log.TabIndex = 18;
            this.lv_log.UseCompatibleStateImageBehavior = false;
            this.lv_log.View = System.Windows.Forms.View.Details;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 55;
            // 
            // Trainer
            // 
            this.Trainer.Text = "Trainer";
            this.Trainer.Width = 73;
            // 
            // NickName
            // 
            this.NickName.Text = "Name";
            this.NickName.Width = 49;
            // 
            // Country
            // 
            this.Country.Text = "Country";
            // 
            // subRegion
            // 
            this.subRegion.Text = "Sub Region";
            // 
            // pkmnSent
            // 
            this.pkmnSent.Text = "Pokemon Sent";
            this.pkmnSent.Width = 62;
            // 
            // FC
            // 
            this.FC.Text = "FC";
            this.FC.Width = 110;
            // 
            // page
            // 
            this.page.Text = "Page";
            // 
            // index
            // 
            this.index.Text = "Index";
            // 
            // btn_Export
            // 
            this.btn_Export.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Export.Location = new System.Drawing.Point(6, 441);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(354, 23);
            this.btn_Export.TabIndex = 19;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // cb_Blacklist
            // 
            this.cb_Blacklist.AutoSize = true;
            this.cb_Blacklist.Location = new System.Drawing.Point(276, 22);
            this.cb_Blacklist.Name = "cb_Blacklist";
            this.cb_Blacklist.Size = new System.Drawing.Size(72, 17);
            this.cb_Blacklist.TabIndex = 20;
            this.cb_Blacklist.Text = "Black List";
            this.cb_Blacklist.UseVisualStyleBackColor = true;
            // 
            // tc_Control
            // 
            this.tc_Control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_Control.Controls.Add(this.tp_GTS);
            this.tc_Control.Controls.Add(this.tp_tradeErrors);
            this.tc_Control.Controls.Add(this.tp_Injection);
            this.tc_Control.Controls.Add(this.tp_Breeding);
            this.tc_Control.Controls.Add(this.tb_Settings);
            this.tc_Control.Controls.Add(this.tabPage1);
            this.tc_Control.Controls.Add(this.tb_Console);
            this.tc_Control.Controls.Add(this.tabPage2);
            this.tc_Control.Controls.Add(this.fcList);
            this.tc_Control.Location = new System.Drawing.Point(1, 33);
            this.tc_Control.Name = "tc_Control";
            this.tc_Control.SelectedIndex = 0;
            this.tc_Control.Size = new System.Drawing.Size(377, 562);
            this.tc_Control.TabIndex = 28;
            // 
            // tp_GTS
            // 
            this.tp_GTS.AllowDrop = true;
            this.tp_GTS.Controls.Add(this.label15);
            this.tp_GTS.Controls.Add(this.tb_tradeCooldown);
            this.tp_GTS.Controls.Add(this.cb_Tradequeue);
            this.tp_GTS.Controls.Add(this.groupBox3);
            this.tp_GTS.Controls.Add(this.combo_levelrange);
            this.tp_GTS.Controls.Add(this.combo_gender);
            this.tp_GTS.Controls.Add(this.combo_pkmnList);
            this.tp_GTS.Controls.Add(this.btn_Clear);
            this.tp_GTS.Controls.Add(this.btn_Import);
            this.tp_GTS.Controls.Add(this.btn_Banlist);
            this.tp_GTS.Controls.Add(this.btn_ShowPaths);
            this.tp_GTS.Controls.Add(this.label1);
            this.tp_GTS.Controls.Add(this.btn_Start);
            this.tp_GTS.Controls.Add(this.cb_Blacklist);
            this.tp_GTS.Controls.Add(this.btn_Stop);
            this.tp_GTS.Controls.Add(this.btn_Export);
            this.tp_GTS.Controls.Add(this.lv_log);
            this.tp_GTS.Location = new System.Drawing.Point(4, 22);
            this.tp_GTS.Name = "tp_GTS";
            this.tp_GTS.Padding = new System.Windows.Forms.Padding(3);
            this.tp_GTS.Size = new System.Drawing.Size(369, 536);
            this.tp_GTS.TabIndex = 0;
            this.tp_GTS.Text = "GTS";
            this.tp_GTS.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(122, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Trade Cooldown (minutes)";
            // 
            // tb_tradeCooldown
            // 
            this.tb_tradeCooldown.Location = new System.Drawing.Point(258, 130);
            this.tb_tradeCooldown.Name = "tb_tradeCooldown";
            this.tb_tradeCooldown.Size = new System.Drawing.Size(76, 20);
            this.tb_tradeCooldown.TabIndex = 39;
            this.tb_tradeCooldown.TextChanged += new System.EventHandler(this.tb_tradeCooldown_TextChanged);
            // 
            // cb_Tradequeue
            // 
            this.cb_Tradequeue.AccessibleName = "TradeQueue";
            this.cb_Tradequeue.AutoSize = true;
            this.cb_Tradequeue.Location = new System.Drawing.Point(5, 130);
            this.cb_Tradequeue.Name = "cb_Tradequeue";
            this.cb_Tradequeue.Size = new System.Drawing.Size(86, 17);
            this.cb_Tradequeue.TabIndex = 38;
            this.cb_Tradequeue.Text = "TradeQueue";
            this.cb_Tradequeue.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_Reddit);
            this.groupBox3.Controls.Add(this.tb_thread);
            this.groupBox3.Location = new System.Drawing.Point(158, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 46);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reddit";
            // 
            // cb_Reddit
            // 
            this.cb_Reddit.AutoSize = true;
            this.cb_Reddit.Location = new System.Drawing.Point(6, 19);
            this.cb_Reddit.Name = "cb_Reddit";
            this.cb_Reddit.Size = new System.Drawing.Size(88, 17);
            this.cb_Reddit.TabIndex = 30;
            this.cb_Reddit.Text = "Use FC Flairs";
            this.cb_Reddit.UseVisualStyleBackColor = true;
            // 
            // tb_thread
            // 
            this.tb_thread.Location = new System.Drawing.Point(100, 16);
            this.tb_thread.Name = "tb_thread";
            this.tb_thread.Size = new System.Drawing.Size(76, 20);
            this.tb_thread.TabIndex = 31;
            // 
            // combo_levelrange
            // 
            this.combo_levelrange.FormattingEnabled = true;
            this.combo_levelrange.Items.AddRange(new object[] {
            "  Any",
            "01 - 10",
            "11 - 20",
            "21 - 30",
            "31 - 40",
            "41 - 50",
            "51 - 60",
            "61 - 70",
            "71 - 80",
            "81 - 90",
            "91 - 100 "});
            this.combo_levelrange.Location = new System.Drawing.Point(195, 18);
            this.combo_levelrange.Name = "combo_levelrange";
            this.combo_levelrange.Size = new System.Drawing.Size(75, 21);
            this.combo_levelrange.TabIndex = 35;
            // 
            // combo_gender
            // 
            this.combo_gender.FormattingEnabled = true;
            this.combo_gender.Items.AddRange(new object[] {
            "Any",
            "Male",
            "Female"});
            this.combo_gender.Location = new System.Drawing.Point(125, 18);
            this.combo_gender.Name = "combo_gender";
            this.combo_gender.Size = new System.Drawing.Size(64, 21);
            this.combo_gender.TabIndex = 34;
            // 
            // combo_pkmnList
            // 
            this.combo_pkmnList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_pkmnList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_pkmnList.FormattingEnabled = true;
            this.combo_pkmnList.Location = new System.Drawing.Point(5, 19);
            this.combo_pkmnList.Name = "combo_pkmnList";
            this.combo_pkmnList.Size = new System.Drawing.Size(113, 21);
            this.combo_pkmnList.TabIndex = 30;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.Location = new System.Drawing.Point(6, 499);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(354, 23);
            this.btn_Clear.TabIndex = 33;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Import.Location = new System.Drawing.Point(6, 470);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(354, 23);
            this.btn_Import.TabIndex = 32;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Banlist
            // 
            this.btn_Banlist.Location = new System.Drawing.Point(3, 87);
            this.btn_Banlist.Name = "btn_Banlist";
            this.btn_Banlist.Size = new System.Drawing.Size(149, 23);
            this.btn_Banlist.TabIndex = 29;
            this.btn_Banlist.Text = "Banned FCs";
            this.btn_Banlist.UseVisualStyleBackColor = true;
            this.btn_Banlist.Click += new System.EventHandler(this.btn_Banlist_Click);
            // 
            // btn_ShowPaths
            // 
            this.btn_ShowPaths.Location = new System.Drawing.Point(131, 45);
            this.btn_ShowPaths.Name = "btn_ShowPaths";
            this.btn_ShowPaths.Size = new System.Drawing.Size(217, 23);
            this.btn_ShowPaths.TabIndex = 28;
            this.btn_ShowPaths.Text = "Giveaway Details";
            this.btn_ShowPaths.UseVisualStyleBackColor = true;
            this.btn_ShowPaths.Click += new System.EventHandler(this.btn_ShowPaths_Click);
            // 
            // tp_tradeErrors
            // 
            this.tp_tradeErrors.Controls.Add(this.lv_failedList);
            this.tp_tradeErrors.Location = new System.Drawing.Point(4, 22);
            this.tp_tradeErrors.Name = "tp_tradeErrors";
            this.tp_tradeErrors.Padding = new System.Windows.Forms.Padding(3);
            this.tp_tradeErrors.Size = new System.Drawing.Size(369, 536);
            this.tp_tradeErrors.TabIndex = 7;
            this.tp_tradeErrors.Text = "Trade Errors";
            this.tp_tradeErrors.UseVisualStyleBackColor = true;
            // 
            // lv_failedList
            // 
            this.lv_failedList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_failedList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lv_failedList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lv_failedList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_failedList.HideSelection = false;
            this.lv_failedList.Location = new System.Drawing.Point(8, 6);
            this.lv_failedList.Name = "lv_failedList";
            this.lv_failedList.Size = new System.Drawing.Size(353, 517);
            this.lv_failedList.TabIndex = 19;
            this.lv_failedList.UseCompatibleStateImageBehavior = false;
            this.lv_failedList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Trainer";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 49;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Country";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sub Region";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Pokemon Sent";
            this.columnHeader6.Width = 62;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "FC";
            this.columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Page";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Index";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Fail Reason";
            this.columnHeader10.Width = 1000;
            // 
            // tp_Injection
            // 
            this.tp_Injection.AllowDrop = true;
            this.tp_Injection.Controls.Add(this.btn_WCDelete);
            this.tp_Injection.Controls.Add(this.btn_WCInject);
            this.tp_Injection.Controls.Add(this.nud_SlotWCInjection);
            this.tp_Injection.Controls.Add(this.label7);
            this.tp_Injection.Controls.Add(this.btn_BrowseWCInject);
            this.tp_Injection.Controls.Add(this.tb_WCInjection);
            this.tp_Injection.Controls.Add(this.label12);
            this.tp_Injection.Controls.Add(this.btn_Delete);
            this.tp_Injection.Controls.Add(this.nud_CountInjection);
            this.tp_Injection.Controls.Add(this.label10);
            this.tp_Injection.Controls.Add(this.btn_Inject);
            this.tp_Injection.Controls.Add(this.nud_SlotInjection);
            this.tp_Injection.Controls.Add(this.nud_BoxInjection);
            this.tp_Injection.Controls.Add(this.label9);
            this.tp_Injection.Controls.Add(this.label3);
            this.tp_Injection.Controls.Add(this.btn_BrowseInject);
            this.tp_Injection.Controls.Add(this.tb_FileInjection);
            this.tp_Injection.Controls.Add(this.label2);
            this.tp_Injection.Location = new System.Drawing.Point(4, 22);
            this.tp_Injection.Name = "tp_Injection";
            this.tp_Injection.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Injection.Size = new System.Drawing.Size(369, 536);
            this.tp_Injection.TabIndex = 1;
            this.tp_Injection.Text = "Injection";
            this.tp_Injection.UseVisualStyleBackColor = true;
            this.tp_Injection.DragDrop += new System.Windows.Forms.DragEventHandler(this.tp_Injection_DragDrop);
            this.tp_Injection.DragEnter += new System.Windows.Forms.DragEventHandler(this.tp_Injection_DragEnter);
            // 
            // btn_WCDelete
            // 
            this.btn_WCDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_WCDelete.Enabled = false;
            this.btn_WCDelete.Location = new System.Drawing.Point(6, 258);
            this.btn_WCDelete.Name = "btn_WCDelete";
            this.btn_WCDelete.Size = new System.Drawing.Size(354, 23);
            this.btn_WCDelete.TabIndex = 21;
            this.btn_WCDelete.Text = "Delete";
            this.btn_WCDelete.UseVisualStyleBackColor = true;
            this.btn_WCDelete.Click += new System.EventHandler(this.btn_WCDelete_Click);
            // 
            // btn_WCInject
            // 
            this.btn_WCInject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_WCInject.Enabled = false;
            this.btn_WCInject.Location = new System.Drawing.Point(6, 229);
            this.btn_WCInject.Name = "btn_WCInject";
            this.btn_WCInject.Size = new System.Drawing.Size(354, 23);
            this.btn_WCInject.TabIndex = 18;
            this.btn_WCInject.Text = "Inject";
            this.btn_WCInject.UseVisualStyleBackColor = true;
            this.btn_WCInject.Click += new System.EventHandler(this.btn_WCInject_Click);
            // 
            // nud_SlotWCInjection
            // 
            this.nud_SlotWCInjection.Location = new System.Drawing.Point(8, 202);
            this.nud_SlotWCInjection.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.nud_SlotWCInjection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_SlotWCInjection.Name = "nud_SlotWCInjection";
            this.nud_SlotWCInjection.Size = new System.Drawing.Size(38, 20);
            this.nud_SlotWCInjection.TabIndex = 17;
            this.nud_SlotWCInjection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_SlotWCInjection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Slot:";
            // 
            // btn_BrowseWCInject
            // 
            this.btn_BrowseWCInject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BrowseWCInject.Location = new System.Drawing.Point(290, 162);
            this.btn_BrowseWCInject.Name = "btn_BrowseWCInject";
            this.btn_BrowseWCInject.Size = new System.Drawing.Size(75, 20);
            this.btn_BrowseWCInject.TabIndex = 13;
            this.btn_BrowseWCInject.Text = "Browse";
            this.btn_BrowseWCInject.UseVisualStyleBackColor = true;
            this.btn_BrowseWCInject.Click += new System.EventHandler(this.btn_BrowseWCInject_Click);
            // 
            // tb_WCInjection
            // 
            this.tb_WCInjection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_WCInjection.Location = new System.Drawing.Point(6, 162);
            this.tb_WCInjection.Name = "tb_WCInjection";
            this.tb_WCInjection.ReadOnly = true;
            this.tb_WCInjection.Size = new System.Drawing.Size(279, 20);
            this.tb_WCInjection.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "WC:";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(7, 120);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(354, 23);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // nud_CountInjection
            // 
            this.nud_CountInjection.Location = new System.Drawing.Point(95, 64);
            this.nud_CountInjection.Maximum = new decimal(new int[] {
            960,
            0,
            0,
            0});
            this.nud_CountInjection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_CountInjection.Name = "nud_CountInjection";
            this.nud_CountInjection.Size = new System.Drawing.Size(38, 20);
            this.nud_CountInjection.TabIndex = 9;
            this.nud_CountInjection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_CountInjection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Count:";
            // 
            // btn_Inject
            // 
            this.btn_Inject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Inject.Enabled = false;
            this.btn_Inject.Location = new System.Drawing.Point(7, 91);
            this.btn_Inject.Name = "btn_Inject";
            this.btn_Inject.Size = new System.Drawing.Size(354, 23);
            this.btn_Inject.TabIndex = 7;
            this.btn_Inject.Text = "Inject";
            this.btn_Inject.UseVisualStyleBackColor = true;
            this.btn_Inject.Click += new System.EventHandler(this.btn_Inject_Click);
            // 
            // nud_SlotInjection
            // 
            this.nud_SlotInjection.Location = new System.Drawing.Point(51, 64);
            this.nud_SlotInjection.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nud_SlotInjection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_SlotInjection.Name = "nud_SlotInjection";
            this.nud_SlotInjection.Size = new System.Drawing.Size(38, 20);
            this.nud_SlotInjection.TabIndex = 6;
            this.nud_SlotInjection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_SlotInjection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_SlotInjection.ValueChanged += new System.EventHandler(this.nud_SlotInjection_ValueChanged);
            // 
            // nud_BoxInjection
            // 
            this.nud_BoxInjection.Location = new System.Drawing.Point(7, 64);
            this.nud_BoxInjection.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nud_BoxInjection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_BoxInjection.Name = "nud_BoxInjection";
            this.nud_BoxInjection.Size = new System.Drawing.Size(38, 20);
            this.nud_BoxInjection.TabIndex = 5;
            this.nud_BoxInjection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_BoxInjection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_BoxInjection.ValueChanged += new System.EventHandler(this.nud_BoxInjection_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Slot:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Box:";
            // 
            // btn_BrowseInject
            // 
            this.btn_BrowseInject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BrowseInject.Location = new System.Drawing.Point(291, 24);
            this.btn_BrowseInject.Name = "btn_BrowseInject";
            this.btn_BrowseInject.Size = new System.Drawing.Size(75, 20);
            this.btn_BrowseInject.TabIndex = 2;
            this.btn_BrowseInject.Text = "Browse";
            this.btn_BrowseInject.UseVisualStyleBackColor = true;
            this.btn_BrowseInject.Click += new System.EventHandler(this.btn_BrowseInject_Click);
            // 
            // tb_FileInjection
            // 
            this.tb_FileInjection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_FileInjection.Location = new System.Drawing.Point(7, 24);
            this.tb_FileInjection.Name = "tb_FileInjection";
            this.tb_FileInjection.ReadOnly = true;
            this.tb_FileInjection.Size = new System.Drawing.Size(279, 20);
            this.tb_FileInjection.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "File:";
            // 
            // tp_Breeding
            // 
            this.tp_Breeding.Controls.Add(this.btn_EggStop);
            this.tp_Breeding.Controls.Add(this.btn_EggStart);
            this.tp_Breeding.Controls.Add(this.label11);
            this.tp_Breeding.Controls.Add(this.btn_EggAvailable);
            this.tp_Breeding.Location = new System.Drawing.Point(4, 22);
            this.tp_Breeding.Name = "tp_Breeding";
            this.tp_Breeding.Size = new System.Drawing.Size(369, 536);
            this.tp_Breeding.TabIndex = 2;
            this.tp_Breeding.Text = "Breeding";
            this.tp_Breeding.UseVisualStyleBackColor = true;
            // 
            // btn_EggStop
            // 
            this.btn_EggStop.Enabled = false;
            this.btn_EggStop.Location = new System.Drawing.Point(203, 30);
            this.btn_EggStop.Name = "btn_EggStop";
            this.btn_EggStop.Size = new System.Drawing.Size(75, 23);
            this.btn_EggStop.TabIndex = 3;
            this.btn_EggStop.Text = "Stop";
            this.btn_EggStop.UseVisualStyleBackColor = true;
            this.btn_EggStop.Click += new System.EventHandler(this.btn_EggStop_Click);
            // 
            // btn_EggStart
            // 
            this.btn_EggStart.Enabled = false;
            this.btn_EggStart.Location = new System.Drawing.Point(122, 30);
            this.btn_EggStart.Name = "btn_EggStart";
            this.btn_EggStart.Size = new System.Drawing.Size(75, 23);
            this.btn_EggStart.TabIndex = 2;
            this.btn_EggStart.Text = "Start";
            this.btn_EggStart.UseVisualStyleBackColor = true;
            this.btn_EggStart.Click += new System.EventHandler(this.btn_EggStart_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Egg Always Available:";
            // 
            // btn_EggAvailable
            // 
            this.btn_EggAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EggAvailable.Enabled = false;
            this.btn_EggAvailable.Location = new System.Drawing.Point(8, 4);
            this.btn_EggAvailable.Name = "btn_EggAvailable";
            this.btn_EggAvailable.Size = new System.Drawing.Size(353, 23);
            this.btn_EggAvailable.TabIndex = 0;
            this.btn_EggAvailable.Text = "Egg Available";
            this.btn_EggAvailable.UseVisualStyleBackColor = true;
            this.btn_EggAvailable.Click += new System.EventHandler(this.btn_EggAvailable_Click);
            // 
            // tb_Settings
            // 
            this.tb_Settings.Controls.Add(this.cb_UseLedySync);
            this.tb_Settings.Controls.Add(this.groupBox2);
            this.tb_Settings.Controls.Add(this.tb_waittime);
            this.tb_Settings.Controls.Add(this.label6);
            this.tb_Settings.Controls.Add(this.groupBox1);
            this.tb_Settings.Controls.Add(this.nud_DefaultCount);
            this.tb_Settings.Controls.Add(this.label5);
            this.tb_Settings.Controls.Add(this.tb_Subreddit);
            this.tb_Settings.Controls.Add(this.label4);
            this.tb_Settings.Location = new System.Drawing.Point(4, 22);
            this.tb_Settings.Name = "tb_Settings";
            this.tb_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Settings.Size = new System.Drawing.Size(369, 536);
            this.tb_Settings.TabIndex = 3;
            this.tb_Settings.Text = "Settings";
            this.tb_Settings.UseVisualStyleBackColor = true;
            // 
            // cb_UseLedySync
            // 
            this.cb_UseLedySync.AutoSize = true;
            this.cb_UseLedySync.Location = new System.Drawing.Point(12, 173);
            this.cb_UseLedySync.Name = "cb_UseLedySync";
            this.cb_UseLedySync.Size = new System.Drawing.Size(95, 17);
            this.cb_UseLedySync.TabIndex = 10;
            this.cb_UseLedySync.Text = "Use LedySync";
            this.cb_UseLedySync.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tb_LedySyncPort);
            this.groupBox2.Controls.Add(this.tb_LedySyncIP);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_consoleName);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(10, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 102);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LedySync Settings";
            // 
            // tb_LedySyncPort
            // 
            this.tb_LedySyncPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_LedySyncPort.Location = new System.Drawing.Point(92, 43);
            this.tb_LedySyncPort.Name = "tb_LedySyncPort";
            this.tb_LedySyncPort.Size = new System.Drawing.Size(252, 20);
            this.tb_LedySyncPort.TabIndex = 10;
            this.tb_LedySyncPort.Text = "3000";
            // 
            // tb_LedySyncIP
            // 
            this.tb_LedySyncIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_LedySyncIP.Location = new System.Drawing.Point(92, 17);
            this.tb_LedySyncIP.Name = "tb_LedySyncIP";
            this.tb_LedySyncIP.Size = new System.Drawing.Size(252, 20);
            this.tb_LedySyncIP.TabIndex = 9;
            this.tb_LedySyncIP.Text = "127.0.0.1";
            this.tb_LedySyncIP.TextChanged += new System.EventHandler(this.tb_LedySyncIP_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Console Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "LedySync Port:";
            // 
            // tb_consoleName
            // 
            this.tb_consoleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_consoleName.Location = new System.Drawing.Point(92, 69);
            this.tb_consoleName.Name = "tb_consoleName";
            this.tb_consoleName.Size = new System.Drawing.Size(252, 20);
            this.tb_consoleName.TabIndex = 8;
            this.tb_consoleName.Text = "Ledybot";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "LedySync IP:";
            // 
            // tb_waittime
            // 
            this.tb_waittime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_waittime.Location = new System.Drawing.Point(131, 148);
            this.tb_waittime.Name = "tb_waittime";
            this.tb_waittime.Size = new System.Drawing.Size(229, 20);
            this.tb_waittime.TabIndex = 6;
            this.tb_waittime.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "extra waittime (for o3ds):";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rb_frontfpo);
            this.groupBox1.Controls.Add(this.rb_front);
            this.groupBox1.Controls.Add(this.rb_back);
            this.groupBox1.Location = new System.Drawing.Point(10, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 94);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trade direction";
            // 
            // rb_frontfpo
            // 
            this.rb_frontfpo.AutoSize = true;
            this.rb_frontfpo.Location = new System.Drawing.Point(6, 43);
            this.rb_frontfpo.Name = "rb_frontfpo";
            this.rb_frontfpo.Size = new System.Drawing.Size(164, 17);
            this.rb_frontfpo.TabIndex = 2;
            this.rb_frontfpo.TabStop = true;
            this.rb_frontfpo.Text = "from the back (first page only)";
            this.rb_frontfpo.UseVisualStyleBackColor = true;
            // 
            // rb_front
            // 
            this.rb_front.AutoSize = true;
            this.rb_front.Location = new System.Drawing.Point(6, 66);
            this.rb_front.Name = "rb_front";
            this.rb_front.Size = new System.Drawing.Size(87, 17);
            this.rb_front.TabIndex = 1;
            this.rb_front.Text = "from the front";
            this.rb_front.UseVisualStyleBackColor = true;
            // 
            // rb_back
            // 
            this.rb_back.AutoSize = true;
            this.rb_back.Checked = true;
            this.rb_back.Location = new System.Drawing.Point(7, 20);
            this.rb_back.Name = "rb_back";
            this.rb_back.Size = new System.Drawing.Size(90, 17);
            this.rb_back.TabIndex = 0;
            this.rb_back.TabStop = true;
            this.rb_back.Text = "from the back";
            this.rb_back.UseVisualStyleBackColor = true;
            // 
            // nud_DefaultCount
            // 
            this.nud_DefaultCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_DefaultCount.Location = new System.Drawing.Point(241, 32);
            this.nud_DefaultCount.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud_DefaultCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nud_DefaultCount.Name = "nud_DefaultCount";
            this.nud_DefaultCount.Size = new System.Drawing.Size(120, 20);
            this.nud_DefaultCount.TabIndex = 3;
            this.nud_DefaultCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_DefaultCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Default Count:";
            // 
            // tb_Subreddit
            // 
            this.tb_Subreddit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Subreddit.Location = new System.Drawing.Point(68, 6);
            this.tb_Subreddit.Name = "tb_Subreddit";
            this.tb_Subreddit.Size = new System.Drawing.Size(293, 20);
            this.tb_Subreddit.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Subreddit:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gb_connectionBox);
            this.tabPage1.Controls.Add(this.btn_removeConnection);
            this.tabPage1.Controls.Add(this.lv_ServerList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(369, 536);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "API Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gb_connectionBox
            // 
            this.gb_connectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_connectionBox.Controls.Add(this.button1);
            this.gb_connectionBox.Controls.Add(this.tb_apiPort);
            this.gb_connectionBox.Controls.Add(this.tb_apiIP);
            this.gb_connectionBox.Controls.Add(this.label16);
            this.gb_connectionBox.Controls.Add(this.label17);
            this.gb_connectionBox.Location = new System.Drawing.Point(176, 440);
            this.gb_connectionBox.Name = "gb_connectionBox";
            this.gb_connectionBox.Size = new System.Drawing.Size(197, 93);
            this.gb_connectionBox.TabIndex = 21;
            this.gb_connectionBox.TabStop = false;
            this.gb_connectionBox.Text = "New Connection Settings";
            this.gb_connectionBox.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Connection";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tb_apiPort
            // 
            this.tb_apiPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_apiPort.Location = new System.Drawing.Point(42, 43);
            this.tb_apiPort.Name = "tb_apiPort";
            this.tb_apiPort.Size = new System.Drawing.Size(148, 20);
            this.tb_apiPort.TabIndex = 10;
            this.tb_apiPort.Text = "10000";
            // 
            // tb_apiIP
            // 
            this.tb_apiIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_apiIP.Location = new System.Drawing.Point(42, 17);
            this.tb_apiIP.Name = "tb_apiIP";
            this.tb_apiIP.Size = new System.Drawing.Size(149, 20);
            this.tb_apiIP.TabIndex = 9;
            this.tb_apiIP.Text = "127.0.0.1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Port:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "IP:";
            // 
            // btn_removeConnection
            // 
            this.btn_removeConnection.Location = new System.Drawing.Point(33, 460);
            this.btn_removeConnection.Name = "btn_removeConnection";
            this.btn_removeConnection.Size = new System.Drawing.Size(102, 50);
            this.btn_removeConnection.TabIndex = 20;
            this.btn_removeConnection.Text = "Remove Checked Connections";
            this.btn_removeConnection.UseVisualStyleBackColor = true;
            this.btn_removeConnection.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // lv_ServerList
            // 
            this.lv_ServerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_ServerList.CheckBoxes = true;
            this.lv_ServerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_hostname,
            this.col_port,
            this.col_connectionStatus});
            this.lv_ServerList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lv_ServerList.FullRowSelect = true;
            this.lv_ServerList.GridLines = true;
            this.lv_ServerList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_ServerList.HideSelection = false;
            this.lv_ServerList.Location = new System.Drawing.Point(8, 6);
            this.lv_ServerList.Name = "lv_ServerList";
            this.lv_ServerList.Size = new System.Drawing.Size(353, 428);
            this.lv_ServerList.TabIndex = 19;
            this.lv_ServerList.UseCompatibleStateImageBehavior = false;
            this.lv_ServerList.View = System.Windows.Forms.View.Details;
            // 
            // col_hostname
            // 
            this.col_hostname.Text = "Hostname";
            this.col_hostname.Width = 150;
            // 
            // col_port
            // 
            this.col_port.Text = "Port";
            this.col_port.Width = 80;
            // 
            // col_connectionStatus
            // 
            this.col_connectionStatus.Text = "Connection Status";
            this.col_connectionStatus.Width = 120;
            // 
            // tb_Console
            // 
            this.tb_Console.Controls.Add(this.btn_SendCommand);
            this.tb_Console.Controls.Add(this.tb_ConsoleCommand);
            this.tb_Console.Controls.Add(this.rtb_Console);
            this.tb_Console.Location = new System.Drawing.Point(4, 22);
            this.tb_Console.Name = "tb_Console";
            this.tb_Console.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Console.Size = new System.Drawing.Size(369, 536);
            this.tb_Console.TabIndex = 4;
            this.tb_Console.Text = "Console";
            this.tb_Console.UseVisualStyleBackColor = true;
            // 
            // btn_SendCommand
            // 
            this.btn_SendCommand.Location = new System.Drawing.Point(291, 501);
            this.btn_SendCommand.Name = "btn_SendCommand";
            this.btn_SendCommand.Size = new System.Drawing.Size(75, 20);
            this.btn_SendCommand.TabIndex = 2;
            this.btn_SendCommand.Text = "Send";
            this.btn_SendCommand.UseVisualStyleBackColor = true;
            this.btn_SendCommand.Click += new System.EventHandler(this.btn_SendCommand_Click);
            // 
            // tb_ConsoleCommand
            // 
            this.tb_ConsoleCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ConsoleCommand.Location = new System.Drawing.Point(4, 501);
            this.tb_ConsoleCommand.Name = "tb_ConsoleCommand";
            this.tb_ConsoleCommand.Size = new System.Drawing.Size(281, 20);
            this.tb_ConsoleCommand.TabIndex = 1;
            this.tb_ConsoleCommand.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_ConsoleCommand_KeyUp);
            // 
            // rtb_Console
            // 
            this.rtb_Console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_Console.Location = new System.Drawing.Point(4, 4);
            this.rtb_Console.Name = "rtb_Console";
            this.rtb_Console.ReadOnly = true;
            this.rtb_Console.Size = new System.Drawing.Size(362, 490);
            this.rtb_Console.TabIndex = 0;
            this.rtb_Console.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(369, 536);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Special Buttons";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(8, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 115);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Special Buttons";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Power (Long)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Power (Short)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // fcList
            // 
            this.fcList.AccessibleName = "";
            this.fcList.Controls.Add(this.lv_fc);
            this.fcList.Location = new System.Drawing.Point(4, 22);
            this.fcList.Name = "fcList";
            this.fcList.Padding = new System.Windows.Forms.Padding(3);
            this.fcList.Size = new System.Drawing.Size(369, 536);
            this.fcList.TabIndex = 8;
            this.fcList.Text = "FC List";
            this.fcList.UseVisualStyleBackColor = true;
            // 
            // lv_fc
            // 
            this.lv_fc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_FC});
            this.lv_fc.HideSelection = false;
            this.lv_fc.Location = new System.Drawing.Point(8, 6);
            this.lv_fc.Name = "lv_fc";
            this.lv_fc.Size = new System.Drawing.Size(358, 524);
            this.lv_fc.TabIndex = 0;
            this.lv_fc.UseCompatibleStateImageBehavior = false;
            this.lv_fc.View = System.Windows.Forms.View.Details;
            // 
            // cl_FC
            // 
            this.cl_FC.Text = "FC";
            this.cl_FC.Width = 100;
            // 
            // ofd_Injection
            // 
            this.ofd_Injection.FileName = "Pokemon.pk7";
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(200, 13);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(75, 20);
            this.btn_Disconnect.TabIndex = 29;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // disconnectTimer
            // 
            this.disconnectTimer.Tick += new System.EventHandler(this.disconnectTimer_Tick);
            // 
            // ofd_WCInjection
            // 
            this.ofd_WCInjection.FileName = "WC.wc7";
            // 
            // rt_status
            // 
            this.rt_status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rt_status.BackColor = System.Drawing.SystemColors.Control;
            this.rt_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rt_status.Location = new System.Drawing.Point(5, 597);
            this.rt_status.Multiline = false;
            this.rt_status.Name = "rt_status";
            this.rt_status.ReadOnly = true;
            this.rt_status.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rt_status.Size = new System.Drawing.Size(369, 22);
            this.rt_status.TabIndex = 30;
            this.rt_status.Text = "Bot Status: ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_select);
            this.groupBox5.Controls.Add(this.btnButtonStart);
            this.groupBox5.Controls.Add(this.btn_rBump);
            this.groupBox5.Controls.Add(this.btn_lBump);
            this.groupBox5.Controls.Add(this.btn_b);
            this.groupBox5.Controls.Add(this.btn_a);
            this.groupBox5.Controls.Add(this.btn_y);
            this.groupBox5.Controls.Add(this.btn_x);
            this.groupBox5.Controls.Add(this.btn_down);
            this.groupBox5.Controls.Add(this.btn_right);
            this.groupBox5.Controls.Add(this.btn_left);
            this.groupBox5.Controls.Add(this.btn_up);
            this.groupBox5.Location = new System.Drawing.Point(4, 125);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(362, 266);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "3DS Buttons";
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(42, 71);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 0;
            this.btn_up.Text = "Up";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(6, 105);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(75, 23);
            this.btn_left.TabIndex = 1;
            this.btn_left.Text = "Left";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(87, 105);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(75, 23);
            this.btn_right.TabIndex = 2;
            this.btn_right.Text = "Right";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(42, 135);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 23);
            this.btn_down.TabIndex = 3;
            this.btn_down.Text = "Down";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_x
            // 
            this.btn_x.Location = new System.Drawing.Point(212, 76);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(75, 23);
            this.btn_x.TabIndex = 4;
            this.btn_x.Text = "X";
            this.btn_x.UseVisualStyleBackColor = true;
            this.btn_x.Click += new System.EventHandler(this.btn_x_Click);
            // 
            // btn_y
            // 
            this.btn_y.Location = new System.Drawing.Point(169, 105);
            this.btn_y.Name = "btn_y";
            this.btn_y.Size = new System.Drawing.Size(75, 23);
            this.btn_y.TabIndex = 5;
            this.btn_y.Text = "Y";
            this.btn_y.UseVisualStyleBackColor = true;
            this.btn_y.Click += new System.EventHandler(this.btn_y_Click);
            // 
            // btn_a
            // 
            this.btn_a.Location = new System.Drawing.Point(251, 104);
            this.btn_a.Name = "btn_a";
            this.btn_a.Size = new System.Drawing.Size(75, 23);
            this.btn_a.TabIndex = 6;
            this.btn_a.Text = "A";
            this.btn_a.UseVisualStyleBackColor = true;
            this.btn_a.Click += new System.EventHandler(this.btn_a_Click);
            // 
            // btn_b
            // 
            this.btn_b.Location = new System.Drawing.Point(212, 135);
            this.btn_b.Name = "btn_b";
            this.btn_b.Size = new System.Drawing.Size(75, 23);
            this.btn_b.TabIndex = 7;
            this.btn_b.Text = "B";
            this.btn_b.UseVisualStyleBackColor = true;
            this.btn_b.Click += new System.EventHandler(this.btn_b_Click);
            // 
            // btn_lBump
            // 
            this.btn_lBump.Location = new System.Drawing.Point(29, 19);
            this.btn_lBump.Name = "btn_lBump";
            this.btn_lBump.Size = new System.Drawing.Size(75, 23);
            this.btn_lBump.TabIndex = 8;
            this.btn_lBump.Text = "Left Bumper";
            this.btn_lBump.UseVisualStyleBackColor = true;
            this.btn_lBump.Click += new System.EventHandler(this.btn_lBump_Click);
            // 
            // btn_rBump
            // 
            this.btn_rBump.Location = new System.Drawing.Point(242, 19);
            this.btn_rBump.Name = "btn_rBump";
            this.btn_rBump.Size = new System.Drawing.Size(84, 23);
            this.btn_rBump.TabIndex = 9;
            this.btn_rBump.Text = "Right Bumper";
            this.btn_rBump.UseVisualStyleBackColor = true;
            this.btn_rBump.Click += new System.EventHandler(this.btn_rBump_Click);
            // 
            // btnButtonStart
            // 
            this.btnButtonStart.Location = new System.Drawing.Point(130, 189);
            this.btnButtonStart.Name = "btnButtonStart";
            this.btnButtonStart.Size = new System.Drawing.Size(75, 23);
            this.btnButtonStart.TabIndex = 10;
            this.btnButtonStart.Text = "Start";
            this.btnButtonStart.UseVisualStyleBackColor = true;
            this.btnButtonStart.Click += new System.EventHandler(this.btnButtonStart_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(130, 218);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 11;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 620);
            this.Controls.Add(this.rt_status);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.tc_Control);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.tb_IP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Ledybot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tc_Control.ResumeLayout(false);
            this.tp_GTS.ResumeLayout(false);
            this.tp_GTS.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tp_tradeErrors.ResumeLayout(false);
            this.tp_Injection.ResumeLayout(false);
            this.tp_Injection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SlotWCInjection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CountInjection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SlotInjection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BoxInjection)).EndInit();
            this.tp_Breeding.ResumeLayout(false);
            this.tp_Breeding.PerformLayout();
            this.tb_Settings.ResumeLayout(false);
            this.tb_Settings.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_DefaultCount)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.gb_connectionBox.ResumeLayout(false);
            this.gb_connectionBox.PerformLayout();
            this.tb_Console.ResumeLayout(false);
            this.tb_Console.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.fcList.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.ListView lv_log;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Trainer;
        private System.Windows.Forms.ColumnHeader NickName;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.CheckBox cb_Blacklist;
        private System.Windows.Forms.TabControl tc_Control;
        private System.Windows.Forms.TabPage tp_GTS;
        private System.Windows.Forms.TabPage tp_Injection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Inject;
        private System.Windows.Forms.NumericUpDown nud_SlotInjection;
        private System.Windows.Forms.NumericUpDown nud_BoxInjection;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_BrowseInject;
        private System.Windows.Forms.TextBox tb_FileInjection;
        private System.Windows.Forms.OpenFileDialog ofd_Injection;
        private System.Windows.Forms.NumericUpDown nud_CountInjection;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TabPage tp_Breeding;
        private System.Windows.Forms.Button btn_EggAvailable;
        private System.Windows.Forms.Button btn_EggStart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_EggStop;
        private System.Windows.Forms.Timer disconnectTimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ColumnHeader FC;
        private System.Windows.Forms.Button btn_ShowPaths;
        private System.Windows.Forms.Button btn_Banlist;
        private System.Windows.Forms.CheckBox cb_Reddit;
        private System.Windows.Forms.TextBox tb_thread;
        private System.Windows.Forms.ColumnHeader pkmnSent;
        private System.Windows.Forms.TabPage tb_Settings;
        private System.Windows.Forms.TextBox tb_Subreddit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_DefaultCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ColumnHeader Country;
        private System.Windows.Forms.ColumnHeader subRegion;
        private System.Windows.Forms.Button btn_WCDelete;
        private System.Windows.Forms.Button btn_WCInject;
        private System.Windows.Forms.NumericUpDown nud_SlotWCInjection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_BrowseWCInject;
        private System.Windows.Forms.TextBox tb_WCInjection;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog ofd_WCInjection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_front;
        private System.Windows.Forms.RadioButton rb_back;
        private System.Windows.Forms.TextBox tb_waittime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_consoleName;
        private System.Windows.Forms.CheckBox cb_UseLedySync;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_LedySyncPort;
        private System.Windows.Forms.TextBox tb_LedySyncIP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rb_frontfpo;
        private System.Windows.Forms.ComboBox combo_pkmnList;
        private System.Windows.Forms.RichTextBox rt_status;
        private System.Windows.Forms.ColumnHeader page;
        private System.Windows.Forms.ColumnHeader index;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combo_levelrange;
        private System.Windows.Forms.ComboBox combo_gender;
        private System.Windows.Forms.TabPage tb_Console;
        private System.Windows.Forms.RichTextBox rtb_Console;
        private System.Windows.Forms.Button btn_SendCommand;
        private System.Windows.Forms.TextBox tb_ConsoleCommand;
        private System.Windows.Forms.CheckBox cb_Tradequeue;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lv_ServerList;
        private System.Windows.Forms.Button btn_removeConnection;
        private System.Windows.Forms.ColumnHeader col_hostname;
        private System.Windows.Forms.ColumnHeader col_port;
        private System.Windows.Forms.ColumnHeader col_connectionStatus;
        private System.Windows.Forms.GroupBox gb_connectionBox;
        private System.Windows.Forms.TextBox tb_apiPort;
        private System.Windows.Forms.TextBox tb_apiIP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_tradeCooldown;
        private System.Windows.Forms.TabPage tp_tradeErrors;
        private System.Windows.Forms.ListView lv_failedList;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TabPage fcList;
        private System.Windows.Forms.ListView lv_fc;
        private System.Windows.Forms.ColumnHeader cl_FC;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_b;
        private System.Windows.Forms.Button btn_a;
        private System.Windows.Forms.Button btn_y;
        private System.Windows.Forms.Button btn_x;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btnButtonStart;
        private System.Windows.Forms.Button btn_rBump;
        private System.Windows.Forms.Button btn_lBump;
    }
}

