namespace Secretariat_Soft;

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
        components = new System.ComponentModel.Container();
        TreeNode treeNode1 = new TreeNode("Incoming Letters");
        TreeNode treeNode2 = new TreeNode("Outgoing Letters");
        TreeNode treeNode3 = new TreeNode("My Letters", new TreeNode[] { treeNode1, treeNode2 });
        TreeNode treeNode4 = new TreeNode("All Folders", 2, 2, new TreeNode[] { treeNode3 });
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        top_panel = new Panel();
        help_button = new Button();
        tools_button = new Button();
        report_button = new Button();
        data_entry_button = new Button();
        min_button = new Button();
        close_button = new Button();
        side_panel = new Panel();
        user_name_lbl = new Label();
        user_image = new PictureBox();
        analogClock1 = new AnalogClock.AnalogClock();
        panel1 = new Panel();
        day_in_week_lbl = new Label();
        day_month_lbl = new Label();
        month_name_lbl = new Label();
        year_num_lbl = new Label();
        bottom_panel = new Panel();
        calculator_button = new Button();
        background_button = new Button();
        timer1 = new System.Windows.Forms.Timer(components);
        tree_panel = new Panel();
        collapse_btn = new Button();
        expand_btn = new Button();
        main_treeView = new TreeView();
        imageList1 = new ImageList(components);
        toold_cm = new ContextMenuStrip(components);
        usersToolStripMenuItem = new ToolStripMenuItem();
        backupDataToolStripMenuItem = new ToolStripMenuItem();
        restoreDataToolStripMenuItem = new ToolStripMenuItem();
        reports_cm = new ContextMenuStrip(components);
        in_toolStripMenuItem2 = new ToolStripMenuItem();
        out_toolStripMenuItem3 = new ToolStripMenuItem();
        help_cm = new ContextMenuStrip(components);
        help_toolStripMenuItem1 = new ToolStripMenuItem();
        about_toolStripMenuItem2 = new ToolStripMenuItem();
        bg_selector_panel2 = new Panel();
        bg6_radioButton5 = new RadioButton();
        bg5_radioButton6 = new RadioButton();
        bg4_radioButton7 = new RadioButton();
        bg3_radioButton4 = new RadioButton();
        bg2_radioButton3 = new RadioButton();
        bg1_radioButton3 = new RadioButton();
        groupBox1 = new GroupBox();
        browsw_radioButton2 = new RadioButton();
        select_radioButton1 = new RadioButton();
        top_panel.SuspendLayout();
        side_panel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)user_image).BeginInit();
        panel1.SuspendLayout();
        bottom_panel.SuspendLayout();
        tree_panel.SuspendLayout();
        toold_cm.SuspendLayout();
        reports_cm.SuspendLayout();
        help_cm.SuspendLayout();
        bg_selector_panel2.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // top_panel
        // 
        top_panel.Controls.Add(help_button);
        top_panel.Controls.Add(tools_button);
        top_panel.Controls.Add(report_button);
        top_panel.Controls.Add(data_entry_button);
        top_panel.Controls.Add(min_button);
        top_panel.Controls.Add(close_button);
        top_panel.Dock = DockStyle.Top;
        top_panel.Location = new Point(233, 0);
        top_panel.MinimumSize = new Size(791, 85);
        top_panel.Name = "top_panel";
        top_panel.Size = new Size(903, 91);
        top_panel.TabIndex = 1;
        // 
        // help_button
        // 
        help_button.Cursor = Cursors.Hand;
        help_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        help_button.Image = Properties.Resources.top_help_button;
        help_button.ImageAlign = ContentAlignment.TopCenter;
        help_button.Location = new Point(448, 3);
        help_button.Name = "help_button";
        help_button.Size = new Size(144, 84);
        help_button.TabIndex = 5;
        help_button.Text = "Help F5";
        help_button.TextAlign = ContentAlignment.BottomCenter;
        help_button.TextImageRelation = TextImageRelation.ImageAboveText;
        help_button.UseVisualStyleBackColor = true;
        help_button.Click += help_button_Click;
        // 
        // tools_button
        // 
        tools_button.Cursor = Cursors.Hand;
        tools_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        tools_button.Image = Properties.Resources.top_tools_button;
        tools_button.ImageAlign = ContentAlignment.TopCenter;
        tools_button.Location = new Point(301, 3);
        tools_button.Name = "tools_button";
        tools_button.Size = new Size(144, 84);
        tools_button.TabIndex = 4;
        tools_button.Text = "Tools F4";
        tools_button.TextAlign = ContentAlignment.BottomCenter;
        tools_button.TextImageRelation = TextImageRelation.ImageAboveText;
        tools_button.UseVisualStyleBackColor = true;
        tools_button.Click += tools_button_Click;
        // 
        // report_button
        // 
        report_button.Cursor = Cursors.Hand;
        report_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        report_button.Image = Properties.Resources.top_report_button;
        report_button.ImageAlign = ContentAlignment.TopCenter;
        report_button.Location = new Point(154, 3);
        report_button.Name = "report_button";
        report_button.Size = new Size(144, 84);
        report_button.TabIndex = 3;
        report_button.Text = "Reports F3";
        report_button.TextAlign = ContentAlignment.BottomCenter;
        report_button.TextImageRelation = TextImageRelation.ImageAboveText;
        report_button.UseVisualStyleBackColor = true;
        report_button.Click += report_button_Click;
        // 
        // data_entry_button
        // 
        data_entry_button.Cursor = Cursors.Hand;
        data_entry_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        data_entry_button.Image = Properties.Resources.top_input_button;
        data_entry_button.ImageAlign = ContentAlignment.TopCenter;
        data_entry_button.Location = new Point(6, 3);
        data_entry_button.Name = "data_entry_button";
        data_entry_button.Size = new Size(144, 84);
        data_entry_button.TabIndex = 2;
        data_entry_button.Text = "Data Entry F2";
        data_entry_button.TextAlign = ContentAlignment.BottomCenter;
        data_entry_button.TextImageRelation = TextImageRelation.ImageAboveText;
        data_entry_button.UseVisualStyleBackColor = true;
        data_entry_button.Click += data_entry_button_Click;
        // 
        // min_button
        // 
        min_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        min_button.BackgroundImage = Properties.Resources.min_button;
        min_button.BackgroundImageLayout = ImageLayout.Center;
        min_button.Cursor = Cursors.Hand;
        min_button.Location = new Point(834, 3);
        min_button.Name = "min_button";
        min_button.Size = new Size(30, 34);
        min_button.TabIndex = 1;
        min_button.UseVisualStyleBackColor = true;
        min_button.Click += min_button_Click;
        // 
        // close_button
        // 
        close_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        close_button.BackgroundImage = Properties.Resources.close_button;
        close_button.BackgroundImageLayout = ImageLayout.Center;
        close_button.Cursor = Cursors.Hand;
        close_button.Location = new Point(870, 3);
        close_button.Name = "close_button";
        close_button.Size = new Size(30, 34);
        close_button.TabIndex = 0;
        close_button.UseVisualStyleBackColor = true;
        close_button.Click += close_button_Click;
        // 
        // side_panel
        // 
        side_panel.BackColor = Color.Gainsboro;
        side_panel.Controls.Add(user_name_lbl);
        side_panel.Controls.Add(user_image);
        side_panel.Controls.Add(analogClock1);
        side_panel.Controls.Add(panel1);
        side_panel.Dock = DockStyle.Left;
        side_panel.Location = new Point(0, 0);
        side_panel.MinimumSize = new Size(180, 825);
        side_panel.Name = "side_panel";
        side_panel.Size = new Size(233, 870);
        side_panel.TabIndex = 0;
        // 
        // user_name_lbl
        // 
        user_name_lbl.BorderStyle = BorderStyle.FixedSingle;
        user_name_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        user_name_lbl.Location = new Point(26, 764);
        user_name_lbl.Name = "user_name_lbl";
        user_name_lbl.Size = new Size(184, 34);
        user_name_lbl.TabIndex = 3;
        user_name_lbl.Text = "User Name";
        user_name_lbl.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // user_image
        // 
        user_image.BorderStyle = BorderStyle.FixedSingle;
        user_image.Image = Properties.Resources.default_user;
        user_image.InitialImage = Properties.Resources.default_user;
        user_image.Location = new Point(26, 564);
        user_image.Name = "user_image";
        user_image.Size = new Size(184, 196);
        user_image.SizeMode = PictureBoxSizeMode.Zoom;
        user_image.TabIndex = 2;
        user_image.TabStop = false;
        // 
        // analogClock1
        // 
        analogClock1.DrawHourHand = true;
        analogClock1.DrawHourHandShadow = true;
        analogClock1.DrawMinuteHand = true;
        analogClock1.DrawMinuteHandShadow = true;
        analogClock1.DrawSecondHand = true;
        analogClock1.DropShadowColor = Color.Black;
        analogClock1.DropShadowOffset = new Point(0, 0);
        analogClock1.FaceColorHigh = Color.RoyalBlue;
        analogClock1.FaceColorLow = Color.SkyBlue;
        analogClock1.FaceGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
        analogClock1.FaceImage = null;
        analogClock1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
        analogClock1.HourHandColor = Color.Gainsboro;
        analogClock1.HourHandDropShadowColor = Color.Gray;
        analogClock1.Location = new Point(9, 12);
        analogClock1.MinuteHandColor = Color.WhiteSmoke;
        analogClock1.MinuteHandDropShadowColor = Color.Gray;
        analogClock1.MinuteHandTickStyle = AnalogClock.TickStyle.Normal;
        analogClock1.Name = "analogClock1";
        analogClock1.NumeralColor = Color.WhiteSmoke;
        analogClock1.RimColorHigh = Color.RoyalBlue;
        analogClock1.RimColorLow = Color.SkyBlue;
        analogClock1.RimGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
        analogClock1.SecondHandColor = Color.Tomato;
        analogClock1.SecondHandDropShadowColor = Color.Gray;
        analogClock1.SecondHandEndCap = System.Drawing.Drawing2D.LineCap.Round;
        analogClock1.SecondHandTickStyle = AnalogClock.TickStyle.Normal;
        analogClock1.Size = new Size(210, 210);
        analogClock1.TabIndex = 1;
        analogClock1.Time = new DateTime(0L);
        // 
        // panel1
        // 
        panel1.BackgroundImage = Properties.Resources.calendar;
        panel1.BackgroundImageLayout = ImageLayout.Zoom;
        panel1.Controls.Add(day_in_week_lbl);
        panel1.Controls.Add(day_month_lbl);
        panel1.Controls.Add(month_name_lbl);
        panel1.Controls.Add(year_num_lbl);
        panel1.Location = new Point(3, 288);
        panel1.Name = "panel1";
        panel1.Size = new Size(230, 219);
        panel1.TabIndex = 0;
        // 
        // day_in_week_lbl
        // 
        day_in_week_lbl.BackColor = Color.Transparent;
        day_in_week_lbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        day_in_week_lbl.ForeColor = Color.Black;
        day_in_week_lbl.Location = new Point(23, 148);
        day_in_week_lbl.Name = "day_in_week_lbl";
        day_in_week_lbl.Size = new Size(184, 51);
        day_in_week_lbl.TabIndex = 3;
        day_in_week_lbl.Text = "Sunday";
        day_in_week_lbl.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // day_month_lbl
        // 
        day_month_lbl.BackColor = Color.Transparent;
        day_month_lbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
        day_month_lbl.ForeColor = Color.Black;
        day_month_lbl.Location = new Point(23, 97);
        day_month_lbl.Name = "day_month_lbl";
        day_month_lbl.Size = new Size(184, 51);
        day_month_lbl.TabIndex = 2;
        day_month_lbl.Text = "21";
        day_month_lbl.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // month_name_lbl
        // 
        month_name_lbl.AutoSize = true;
        month_name_lbl.BackColor = Color.Transparent;
        month_name_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        month_name_lbl.ForeColor = Color.White;
        month_name_lbl.Location = new Point(107, 26);
        month_name_lbl.Name = "month_name_lbl";
        month_name_lbl.Size = new Size(47, 21);
        month_name_lbl.TabIndex = 1;
        month_name_lbl.Text = "April";
        // 
        // year_num_lbl
        // 
        year_num_lbl.AutoSize = true;
        year_num_lbl.BackColor = Color.Transparent;
        year_num_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        year_num_lbl.ForeColor = Color.White;
        year_num_lbl.Location = new Point(40, 26);
        year_num_lbl.Name = "year_num_lbl";
        year_num_lbl.Size = new Size(46, 21);
        year_num_lbl.TabIndex = 0;
        year_num_lbl.Text = "2023";
        // 
        // bottom_panel
        // 
        bottom_panel.Controls.Add(calculator_button);
        bottom_panel.Controls.Add(background_button);
        bottom_panel.Dock = DockStyle.Bottom;
        bottom_panel.Location = new Point(233, 813);
        bottom_panel.MinimumSize = new Size(844, 45);
        bottom_panel.Name = "bottom_panel";
        bottom_panel.Size = new Size(903, 57);
        bottom_panel.TabIndex = 0;
        // 
        // calculator_button
        // 
        calculator_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        calculator_button.BackgroundImage = Properties.Resources.calculator;
        calculator_button.BackgroundImageLayout = ImageLayout.Zoom;
        calculator_button.Cursor = Cursors.Hand;
        calculator_button.Location = new Point(685, 5);
        calculator_button.Name = "calculator_button";
        calculator_button.Size = new Size(60, 50);
        calculator_button.TabIndex = 1;
        calculator_button.UseVisualStyleBackColor = true;
        // 
        // background_button
        // 
        background_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        background_button.Cursor = Cursors.Hand;
        background_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        background_button.Image = Properties.Resources.background;
        background_button.Location = new Point(751, 5);
        background_button.Name = "background_button";
        background_button.Size = new Size(140, 50);
        background_button.TabIndex = 0;
        background_button.Text = "Background";
        background_button.UseVisualStyleBackColor = true;
        background_button.Click += background_button_Click;
        // 
        // timer1
        // 
        timer1.Enabled = true;
        timer1.Tick += timer1_Tick;
        // 
        // tree_panel
        // 
        tree_panel.BorderStyle = BorderStyle.FixedSingle;
        tree_panel.Controls.Add(collapse_btn);
        tree_panel.Controls.Add(expand_btn);
        tree_panel.Controls.Add(main_treeView);
        tree_panel.Location = new Point(239, 97);
        tree_panel.Name = "tree_panel";
        tree_panel.Size = new Size(390, 494);
        tree_panel.TabIndex = 3;
        tree_panel.Visible = false;
        // 
        // collapse_btn
        // 
        collapse_btn.BackgroundImageLayout = ImageLayout.None;
        collapse_btn.Cursor = Cursors.Hand;
        collapse_btn.Image = Properties.Resources.collapse;
        collapse_btn.Location = new Point(352, 6);
        collapse_btn.Name = "collapse_btn";
        collapse_btn.Size = new Size(31, 34);
        collapse_btn.TabIndex = 2;
        collapse_btn.UseVisualStyleBackColor = true;
        collapse_btn.Click += collapse_btn_Click;
        // 
        // expand_btn
        // 
        expand_btn.BackgroundImageLayout = ImageLayout.None;
        expand_btn.Cursor = Cursors.Hand;
        expand_btn.Image = Properties.Resources.expand;
        expand_btn.Location = new Point(320, 6);
        expand_btn.Name = "expand_btn";
        expand_btn.Size = new Size(30, 34);
        expand_btn.TabIndex = 1;
        expand_btn.UseVisualStyleBackColor = true;
        expand_btn.Click += expand_btn_Click;
        // 
        // main_treeView
        // 
        main_treeView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        main_treeView.ImageIndex = 0;
        main_treeView.ImageList = imageList1;
        main_treeView.Indent = 35;
        main_treeView.ItemHeight = 35;
        main_treeView.Location = new Point(3, 6);
        main_treeView.Name = "main_treeView";
        treeNode1.ImageKey = "review.png";
        treeNode1.Name = "Incoming_Letters";
        treeNode1.SelectedImageIndex = 3;
        treeNode1.Text = "Incoming Letters";
        treeNode2.ImageKey = "kToolStripButton.png";
        treeNode2.Name = "Outgoing_Letters";
        treeNode2.SelectedImageIndex = 1;
        treeNode2.Text = "Outgoing Letters";
        treeNode3.Name = "My_Letters";
        treeNode3.SelectedImageIndex = 0;
        treeNode3.Text = "My Letters";
        treeNode4.ImageIndex = 2;
        treeNode4.Name = "All_Folders";
        treeNode4.SelectedImageIndex = 2;
        treeNode4.Text = "All Folders";
        main_treeView.Nodes.AddRange(new TreeNode[] { treeNode4 });
        main_treeView.SelectedImageIndex = 0;
        main_treeView.Size = new Size(382, 482);
        main_treeView.TabIndex = 0;
        main_treeView.MouseDoubleClick += main_treeView_MouseDoubleClick;
        // 
        // imageList1
        // 
        imageList1.ColorDepth = ColorDepth.Depth32Bit;
        imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
        imageList1.TransparentColor = Color.Transparent;
        imageList1.Images.SetKeyName(0, "dep_1.png");
        imageList1.Images.SetKeyName(1, "kToolStripButton.png");
        imageList1.Images.SetKeyName(2, "radMenuItem2.png");
        imageList1.Images.SetKeyName(3, "review.png");
        // 
        // toold_cm
        // 
        toold_cm.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        toold_cm.Items.AddRange(new ToolStripItem[] { usersToolStripMenuItem, backupDataToolStripMenuItem, restoreDataToolStripMenuItem });
        toold_cm.Name = "toold_cm";
        toold_cm.Size = new Size(161, 94);
        // 
        // usersToolStripMenuItem
        // 
        usersToolStripMenuItem.Image = Properties.Resources.user_cms;
        usersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
        usersToolStripMenuItem.Name = "usersToolStripMenuItem";
        usersToolStripMenuItem.Size = new Size(160, 30);
        usersToolStripMenuItem.Text = "Users";
        usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
        // 
        // backupDataToolStripMenuItem
        // 
        backupDataToolStripMenuItem.Image = Properties.Resources.backup_cms;
        backupDataToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
        backupDataToolStripMenuItem.Name = "backupDataToolStripMenuItem";
        backupDataToolStripMenuItem.Size = new Size(160, 30);
        backupDataToolStripMenuItem.Text = "Backup Data";
        backupDataToolStripMenuItem.Click += backupDataToolStripMenuItem_Click;
        // 
        // restoreDataToolStripMenuItem
        // 
        restoreDataToolStripMenuItem.Image = Properties.Resources.restore_cms;
        restoreDataToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
        restoreDataToolStripMenuItem.Name = "restoreDataToolStripMenuItem";
        restoreDataToolStripMenuItem.Size = new Size(160, 30);
        restoreDataToolStripMenuItem.Text = "Restore Data";
        restoreDataToolStripMenuItem.Click += restoreDataToolStripMenuItem_Click;
        // 
        // reports_cm
        // 
        reports_cm.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        reports_cm.Items.AddRange(new ToolStripItem[] { in_toolStripMenuItem2, out_toolStripMenuItem3 });
        reports_cm.Name = "toold_cm";
        reports_cm.Size = new Size(183, 64);
        // 
        // in_toolStripMenuItem2
        // 
        in_toolStripMenuItem2.Image = Properties.Resources.dep_1;
        in_toolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
        in_toolStripMenuItem2.Name = "in_toolStripMenuItem2";
        in_toolStripMenuItem2.Size = new Size(182, 30);
        in_toolStripMenuItem2.Text = "Incoming Letters";
        // 
        // out_toolStripMenuItem3
        // 
        out_toolStripMenuItem3.Image = Properties.Resources.kToolStripButton;
        out_toolStripMenuItem3.ImageScaling = ToolStripItemImageScaling.None;
        out_toolStripMenuItem3.Name = "out_toolStripMenuItem3";
        out_toolStripMenuItem3.Size = new Size(182, 30);
        out_toolStripMenuItem3.Text = "Outgoing Letters";
        // 
        // help_cm
        // 
        help_cm.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        help_cm.Items.AddRange(new ToolStripItem[] { help_toolStripMenuItem1, about_toolStripMenuItem2 });
        help_cm.Name = "toold_cm";
        help_cm.Size = new Size(120, 64);
        // 
        // help_toolStripMenuItem1
        // 
        help_toolStripMenuItem1.Image = Properties.Resources.review;
        help_toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
        help_toolStripMenuItem1.Name = "help_toolStripMenuItem1";
        help_toolStripMenuItem1.Size = new Size(119, 30);
        help_toolStripMenuItem1.Text = "Help";
        // 
        // about_toolStripMenuItem2
        // 
        about_toolStripMenuItem2.Image = Properties.Resources.radMenuItem2;
        about_toolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
        about_toolStripMenuItem2.Name = "about_toolStripMenuItem2";
        about_toolStripMenuItem2.Size = new Size(119, 30);
        about_toolStripMenuItem2.Text = "About";
        // 
        // bg_selector_panel2
        // 
        bg_selector_panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        bg_selector_panel2.BorderStyle = BorderStyle.FixedSingle;
        bg_selector_panel2.Controls.Add(bg6_radioButton5);
        bg_selector_panel2.Controls.Add(bg5_radioButton6);
        bg_selector_panel2.Controls.Add(bg4_radioButton7);
        bg_selector_panel2.Controls.Add(bg3_radioButton4);
        bg_selector_panel2.Controls.Add(bg2_radioButton3);
        bg_selector_panel2.Controls.Add(bg1_radioButton3);
        bg_selector_panel2.Controls.Add(groupBox1);
        bg_selector_panel2.Location = new Point(681, 436);
        bg_selector_panel2.Name = "bg_selector_panel2";
        bg_selector_panel2.Size = new Size(452, 371);
        bg_selector_panel2.TabIndex = 5;
        bg_selector_panel2.Visible = false;
        // 
        // bg6_radioButton5
        // 
        bg6_radioButton5.Appearance = Appearance.Button;
        bg6_radioButton5.BackgroundImageLayout = ImageLayout.Zoom;
        bg6_radioButton5.Cursor = Cursors.Hand;
        bg6_radioButton5.FlatAppearance.CheckedBackColor = Color.Gray;
        bg6_radioButton5.FlatAppearance.MouseOverBackColor = Color.LightGray;
        bg6_radioButton5.FlatStyle = FlatStyle.Flat;
        bg6_radioButton5.Location = new Point(9, 218);
        bg6_radioButton5.Name = "bg6_radioButton5";
        bg6_radioButton5.Size = new Size(134, 133);
        bg6_radioButton5.TabIndex = 6;
        bg6_radioButton5.TabStop = true;
        bg6_radioButton5.UseVisualStyleBackColor = false;
        // 
        // bg5_radioButton6
        // 
        bg5_radioButton6.Appearance = Appearance.Button;
        bg5_radioButton6.BackgroundImageLayout = ImageLayout.Zoom;
        bg5_radioButton6.Cursor = Cursors.Hand;
        bg5_radioButton6.FlatAppearance.CheckedBackColor = Color.Gray;
        bg5_radioButton6.FlatAppearance.MouseOverBackColor = Color.LightGray;
        bg5_radioButton6.FlatStyle = FlatStyle.Flat;
        bg5_radioButton6.Location = new Point(158, 218);
        bg5_radioButton6.Name = "bg5_radioButton6";
        bg5_radioButton6.Size = new Size(134, 133);
        bg5_radioButton6.TabIndex = 5;
        bg5_radioButton6.TabStop = true;
        bg5_radioButton6.UseVisualStyleBackColor = false;
        // 
        // bg4_radioButton7
        // 
        bg4_radioButton7.Appearance = Appearance.Button;
        bg4_radioButton7.BackgroundImageLayout = ImageLayout.Zoom;
        bg4_radioButton7.Cursor = Cursors.Hand;
        bg4_radioButton7.FlatAppearance.CheckedBackColor = Color.Gray;
        bg4_radioButton7.FlatAppearance.MouseOverBackColor = Color.LightGray;
        bg4_radioButton7.FlatStyle = FlatStyle.Flat;
        bg4_radioButton7.Location = new Point(308, 218);
        bg4_radioButton7.Name = "bg4_radioButton7";
        bg4_radioButton7.Size = new Size(134, 133);
        bg4_radioButton7.TabIndex = 4;
        bg4_radioButton7.TabStop = true;
        bg4_radioButton7.UseVisualStyleBackColor = false;
        // 
        // bg3_radioButton4
        // 
        bg3_radioButton4.Appearance = Appearance.Button;
        bg3_radioButton4.BackgroundImageLayout = ImageLayout.Zoom;
        bg3_radioButton4.Checked = true;
        bg3_radioButton4.Cursor = Cursors.Hand;
        bg3_radioButton4.FlatAppearance.CheckedBackColor = Color.Gray;
        bg3_radioButton4.FlatAppearance.MouseOverBackColor = Color.LightGray;
        bg3_radioButton4.FlatStyle = FlatStyle.Flat;
        bg3_radioButton4.Location = new Point(9, 73);
        bg3_radioButton4.Name = "bg3_radioButton4";
        bg3_radioButton4.Size = new Size(134, 133);
        bg3_radioButton4.TabIndex = 3;
        bg3_radioButton4.TabStop = true;
        bg3_radioButton4.UseVisualStyleBackColor = false;
        // 
        // bg2_radioButton3
        // 
        bg2_radioButton3.Appearance = Appearance.Button;
        bg2_radioButton3.BackgroundImageLayout = ImageLayout.Zoom;
        bg2_radioButton3.Cursor = Cursors.Hand;
        bg2_radioButton3.FlatAppearance.CheckedBackColor = Color.Gray;
        bg2_radioButton3.FlatAppearance.MouseOverBackColor = Color.LightGray;
        bg2_radioButton3.FlatStyle = FlatStyle.Flat;
        bg2_radioButton3.Location = new Point(158, 73);
        bg2_radioButton3.Name = "bg2_radioButton3";
        bg2_radioButton3.Size = new Size(134, 133);
        bg2_radioButton3.TabIndex = 2;
        bg2_radioButton3.TabStop = true;
        bg2_radioButton3.UseVisualStyleBackColor = false;
        // 
        // bg1_radioButton3
        // 
        bg1_radioButton3.Appearance = Appearance.Button;
        bg1_radioButton3.BackgroundImageLayout = ImageLayout.Zoom;
        bg1_radioButton3.Cursor = Cursors.Hand;
        bg1_radioButton3.FlatAppearance.CheckedBackColor = Color.Gray;
        bg1_radioButton3.FlatAppearance.MouseOverBackColor = Color.LightGray;
        bg1_radioButton3.FlatStyle = FlatStyle.Flat;
        bg1_radioButton3.Location = new Point(308, 73);
        bg1_radioButton3.Name = "bg1_radioButton3";
        bg1_radioButton3.Size = new Size(134, 133);
        bg1_radioButton3.TabIndex = 1;
        bg1_radioButton3.TabStop = true;
        bg1_radioButton3.UseVisualStyleBackColor = false;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(browsw_radioButton2);
        groupBox1.Controls.Add(select_radioButton1);
        groupBox1.Location = new Point(9, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(433, 59);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        // 
        // browsw_radioButton2
        // 
        browsw_radioButton2.AutoSize = true;
        browsw_radioButton2.Cursor = Cursors.Hand;
        browsw_radioButton2.Location = new Point(293, 22);
        browsw_radioButton2.Name = "browsw_radioButton2";
        browsw_radioButton2.Size = new Size(107, 21);
        browsw_radioButton2.TabIndex = 1;
        browsw_radioButton2.TabStop = true;
        browsw_radioButton2.Text = "Browse Mode";
        browsw_radioButton2.UseVisualStyleBackColor = true;
        // 
        // select_radioButton1
        // 
        select_radioButton1.AutoSize = true;
        select_radioButton1.Checked = true;
        select_radioButton1.Cursor = Cursors.Hand;
        select_radioButton1.Location = new Point(35, 22);
        select_radioButton1.Name = "select_radioButton1";
        select_radioButton1.Size = new Size(99, 21);
        select_radioButton1.TabIndex = 0;
        select_radioButton1.TabStop = true;
        select_radioButton1.Text = "Select Mode";
        select_radioButton1.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1136, 870);
        Controls.Add(bg_selector_panel2);
        Controls.Add(tree_panel);
        Controls.Add(bottom_panel);
        Controls.Add(top_panel);
        Controls.Add(side_panel);
        Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.None;
        IsMdiContainer = true;
        MinimizeBox = false;
        MinimumSize = new Size(1024, 870);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Main Form";
        WindowState = FormWindowState.Maximized;
        Load += MainForm_Load;
        top_panel.ResumeLayout(false);
        side_panel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)user_image).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        bottom_panel.ResumeLayout(false);
        tree_panel.ResumeLayout(false);
        toold_cm.ResumeLayout(false);
        reports_cm.ResumeLayout(false);
        help_cm.ResumeLayout(false);
        bg_selector_panel2.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel top_panel;
    private Panel side_panel;
    private Panel bottom_panel;
    private Button close_button;
    private Button min_button;
    private Button data_entry_button;
    private Button help_button;
    private Button tools_button;
    private Button report_button;
    private Button background_button;
    private Button calculator_button;
    private Panel panel1;
    private Label year_num_lbl;
    private Label day_month_lbl;
    private Label month_name_lbl;
    private Label day_in_week_lbl;
    private AnalogClock.AnalogClock analogClock1;
    private System.Windows.Forms.Timer timer1;
    private Label user_name_lbl;
    private PictureBox user_image;
    private Panel tree_panel;
    private TreeView main_treeView;
    private Button expand_btn;
    private Button collapse_btn;
    private ImageList imageList1;
    private ContextMenuStrip toold_cm;
    private ToolStripMenuItem usersToolStripMenuItem;
    private ToolStripMenuItem backupDataToolStripMenuItem;
    private ToolStripMenuItem restoreDataToolStripMenuItem;
    private ContextMenuStrip reports_cm;
    private ToolStripMenuItem in_toolStripMenuItem2;
    private ToolStripMenuItem out_toolStripMenuItem3;
    private ContextMenuStrip help_cm;
    private ToolStripMenuItem help_toolStripMenuItem1;
    private ToolStripMenuItem about_toolStripMenuItem2;
    private Panel bg_selector_panel2;
    private RadioButton bg1_radioButton3;
    private GroupBox groupBox1;
    private RadioButton browsw_radioButton2;
    private RadioButton select_radioButton1;
    private RadioButton bg6_radioButton5;
    private RadioButton bg5_radioButton6;
    private RadioButton bg4_radioButton7;
    private RadioButton bg3_radioButton4;
    private RadioButton bg2_radioButton3;
}