﻿namespace Secretariat_Soft.S_Forms;

partial class Out_Letters_De
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
        main_gbox = new GroupBox();
        letter_type_comboBox1 = new ComboBox();
        out_letters_bindingSource1 = new BindingSource(components);
        letters1 = new DataSet.Letters();
        today_resDate_btn = new Button();
        today_regDate_Btn = new Button();
        page_count_NC = new NumericUpDown();
        priority_CB = new ComboBox();
        sent_date_masked_TB = new MaskedTextBox();
        sent_time_masked_TB = new MaskedTextBox();
        reg_date_masked_TB = new MaskedTextBox();
        summary_TB = new TextBox();
        ref_doc_TB = new TextBox();
        group_TB = new TextBox();
        sending_Method_TB = new TextBox();
        recipient_TB = new TextBox();
        sender_TB = new TextBox();
        letter_number_TB = new TextBox();
        subject_TB = new TextBox();
        sys_id_LBL = new Label();
        label17 = new Label();
        label16 = new Label();
        label15 = new Label();
        label14 = new Label();
        label13 = new Label();
        label12 = new Label();
        label11 = new Label();
        label10 = new Label();
        label9 = new Label();
        label8 = new Label();
        label7 = new Label();
        label5 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        Top_Toolstrip = new ToolStrip();
        de_add_butt = new ToolStripButton();
        toolStripSeparator4 = new ToolStripSeparator();
        de_edit_butt = new ToolStripButton();
        toolStripSeparator1 = new ToolStripSeparator();
        de_delete_butt = new ToolStripButton();
        toolStripSeparator2 = new ToolStripSeparator();
        de_save_butt = new ToolStripButton();
        toolStripSeparator5 = new ToolStripSeparator();
        toolStripSeparator3 = new ToolStripSeparator();
        de_print_butt = new ToolStripButton();
        toolStripSeparator6 = new ToolStripSeparator();
        de_cancel_butt = new ToolStripButton();
        toolStripSeparator7 = new ToolStripSeparator();
        system_time_lbl = new Label();
        panel1 = new Panel();
        label6 = new Label();
        system_date_lbl = new Label();
        label4 = new Label();
        user_id_lbl = new Label();
        userId_lbl = new Label();
        user_name_lbl = new Label();
        userName_lbl = new Label();
        id_label7 = new Label();
        sa_Out_LettersTableAdapter1 = new DataSet.LettersTableAdapters.Sa_Out_LettersTableAdapter();
        main_gbox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)out_letters_bindingSource1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)letters1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)page_count_NC).BeginInit();
        Top_Toolstrip.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // main_gbox
        // 
        main_gbox.BackColor = SystemColors.MenuBar;
        main_gbox.Controls.Add(letter_type_comboBox1);
        main_gbox.Controls.Add(today_resDate_btn);
        main_gbox.Controls.Add(today_regDate_Btn);
        main_gbox.Controls.Add(page_count_NC);
        main_gbox.Controls.Add(priority_CB);
        main_gbox.Controls.Add(sent_date_masked_TB);
        main_gbox.Controls.Add(sent_time_masked_TB);
        main_gbox.Controls.Add(reg_date_masked_TB);
        main_gbox.Controls.Add(summary_TB);
        main_gbox.Controls.Add(ref_doc_TB);
        main_gbox.Controls.Add(group_TB);
        main_gbox.Controls.Add(sending_Method_TB);
        main_gbox.Controls.Add(recipient_TB);
        main_gbox.Controls.Add(sender_TB);
        main_gbox.Controls.Add(letter_number_TB);
        main_gbox.Controls.Add(subject_TB);
        main_gbox.Controls.Add(sys_id_LBL);
        main_gbox.Controls.Add(label17);
        main_gbox.Controls.Add(label16);
        main_gbox.Controls.Add(label15);
        main_gbox.Controls.Add(label14);
        main_gbox.Controls.Add(label13);
        main_gbox.Controls.Add(label12);
        main_gbox.Controls.Add(label11);
        main_gbox.Controls.Add(label10);
        main_gbox.Controls.Add(label9);
        main_gbox.Controls.Add(label8);
        main_gbox.Controls.Add(label7);
        main_gbox.Controls.Add(label5);
        main_gbox.Controls.Add(label3);
        main_gbox.Controls.Add(label2);
        main_gbox.Controls.Add(label1);
        main_gbox.Location = new Point(12, 73);
        main_gbox.Name = "main_gbox";
        main_gbox.Size = new Size(701, 553);
        main_gbox.TabIndex = 6;
        main_gbox.TabStop = false;
        main_gbox.Text = "Info";
        // 
        // letter_type_comboBox1
        // 
        letter_type_comboBox1.DataBindings.Add(new Binding("Text", out_letters_bindingSource1, "LetterType", true));
        letter_type_comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        letter_type_comboBox1.FormattingEnabled = true;
        letter_type_comboBox1.Items.AddRange(new object[] { "Internal", "External", "Informative", "Other" });
        letter_type_comboBox1.Location = new Point(134, 222);
        letter_type_comboBox1.Name = "letter_type_comboBox1";
        letter_type_comboBox1.Size = new Size(239, 25);
        letter_type_comboBox1.TabIndex = 9;
        // 
        // out_letters_bindingSource1
        // 
        out_letters_bindingSource1.DataMember = "Sa_Out_Letters";
        out_letters_bindingSource1.DataSource = letters1;
        // 
        // letters1
        // 
        letters1.DataSetName = "Letters";
        letters1.Namespace = "http://tempuri.org/Letters.xsd";
        letters1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        // 
        // today_resDate_btn
        // 
        today_resDate_btn.Location = new Point(399, 193);
        today_resDate_btn.Name = "today_resDate_btn";
        today_resDate_btn.Size = new Size(75, 25);
        today_resDate_btn.TabIndex = 7;
        today_resDate_btn.Text = "Today";
        today_resDate_btn.UseVisualStyleBackColor = true;
        today_resDate_btn.Click += today_resDate_btn_Click;
        // 
        // today_regDate_Btn
        // 
        today_regDate_Btn.Location = new Point(399, 99);
        today_regDate_Btn.Name = "today_regDate_Btn";
        today_regDate_Btn.Size = new Size(75, 25);
        today_regDate_Btn.TabIndex = 6;
        today_regDate_Btn.Text = "Today";
        today_regDate_Btn.UseVisualStyleBackColor = true;
        today_regDate_Btn.Click += today_regDate_Btn_Click;
        // 
        // page_count_NC
        // 
        page_count_NC.DataBindings.Add(new Binding("Value", out_letters_bindingSource1, "PageCount", true));
        page_count_NC.Location = new Point(134, 401);
        page_count_NC.Maximum = new decimal(new int[] { 25000, 0, 0, 0 });
        page_count_NC.Name = "page_count_NC";
        page_count_NC.Size = new Size(239, 25);
        page_count_NC.TabIndex = 5;
        // 
        // priority_CB
        // 
        priority_CB.DataBindings.Add(new Binding("Text", out_letters_bindingSource1, "Priority", true));
        priority_CB.DropDownStyle = ComboBoxStyle.DropDownList;
        priority_CB.FormattingEnabled = true;
        priority_CB.Items.AddRange(new object[] { "Low", "Normal", "High" });
        priority_CB.Location = new Point(134, 369);
        priority_CB.Name = "priority_CB";
        priority_CB.Size = new Size(239, 25);
        priority_CB.TabIndex = 4;
        // 
        // sent_date_masked_TB
        // 
        sent_date_masked_TB.CausesValidation = false;
        sent_date_masked_TB.CutCopyMaskFormat = MaskFormat.IncludePromptAndLiterals;
        sent_date_masked_TB.DataBindings.Add(new Binding("Text", out_letters_bindingSource1, "SentDate", true, DataSourceUpdateMode.OnValidation, "__-__-____"));
        sent_date_masked_TB.Location = new Point(134, 193);
        sent_date_masked_TB.Mask = "00/00/0000";
        sent_date_masked_TB.Name = "sent_date_masked_TB";
        sent_date_masked_TB.Size = new Size(239, 25);
        sent_date_masked_TB.TabIndex = 3;
        sent_date_masked_TB.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        sent_date_masked_TB.ValidatingType = typeof(DateTime);
        // 
        // sent_time_masked_TB
        // 
        sent_time_masked_TB.DataBindings.Add(new Binding("Text", out_letters_bindingSource1, "Sent_Time", true));
        sent_time_masked_TB.Location = new Point(134, 162);
        sent_time_masked_TB.Name = "sent_time_masked_TB";
        sent_time_masked_TB.Size = new Size(239, 25);
        sent_time_masked_TB.TabIndex = 3;
        // 
        // reg_date_masked_TB
        // 
        reg_date_masked_TB.CausesValidation = false;
        reg_date_masked_TB.CutCopyMaskFormat = MaskFormat.IncludePromptAndLiterals;
        reg_date_masked_TB.DataBindings.Add(new Binding("Text", out_letters_bindingSource1, "RegDate", true, DataSourceUpdateMode.OnValidation, "__-__-____"));
        reg_date_masked_TB.Location = new Point(134, 99);
        reg_date_masked_TB.Mask = "00/00/0000";
        reg_date_masked_TB.Name = "reg_date_masked_TB";
        reg_date_masked_TB.Size = new Size(239, 25);
        reg_date_masked_TB.TabIndex = 3;
        reg_date_masked_TB.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        reg_date_masked_TB.ValidatingType = typeof(DateTime);
        // 
        // summary_TB
        // 
        summary_TB.DataBindings.Add(new Binding("Text", out_letters_bindingSource1, "DocSummary", true));
        summary_TB.Location = new Point(134, 465);
        summary_TB.Multiline = true;
        summary_TB.Name = "summary_TB";
        summary_TB.ScrollBars = ScrollBars.Vertical;
        summary_TB.Size = new Size(524, 64);
        summary_TB.TabIndex = 2;
        // 
        // ref_doc_TB
        // 
        ref_doc_TB.DataBindings.Add(new Binding("Text", out_letters_bindingSource1, "Ref_Doc", true));
        ref_doc_TB.Location = new Point(134, 435);
        ref_doc_TB.Name = "ref_doc_TB";
        ref_doc_TB.Size = new Size(524, 25);
        ref_doc_TB.TabIndex = 2;
        // 
        // group_TB
        // 
        group_TB.DataBindings.Add(new Binding("Text", out_letters_bindingSource1, "GroupName", true));
        group_TB.Location = new Point(134, 339);
        group_TB.Name = "group_TB";
        group_TB.Size = new Size(239, 25);
        group_TB.TabIndex = 2;
        // 
        // sending_Method_TB
        // 
        sending_Method_TB.DataBindings.Add(new Binding("Text", out_letters_bindingSource1, "Sending_Method", true));
        sending_Method_TB.Location = new Point(134, 309);
        sending_Method_TB.Name = "sending_Method_TB";
        sending_Method_TB.Size = new Size(239, 25);
        sending_Method_TB.TabIndex = 2;
        // 
        // recipient_TB
        // 
        recipient_TB.DataBindings.Add(new Binding("Text", out_letters_bindingSource1, "Recipient", true));
        recipient_TB.Location = new Point(134, 280);
        recipient_TB.Name = "recipient_TB";
        recipient_TB.Size = new Size(239, 25);
        recipient_TB.TabIndex = 2;
        // 
        // sender_TB
        // 
        sender_TB.DataBindings.Add(new Binding("Text", out_letters_bindingSource1, "Sender", true));
        sender_TB.Location = new Point(134, 251);
        sender_TB.Name = "sender_TB";
        sender_TB.Size = new Size(239, 25);
        sender_TB.TabIndex = 2;
        // 
        // letter_number_TB
        // 
        letter_number_TB.DataBindings.Add(new Binding("Text", out_letters_bindingSource1, "LetterNumber", true));
        letter_number_TB.Location = new Point(134, 129);
        letter_number_TB.Name = "letter_number_TB";
        letter_number_TB.Size = new Size(239, 25);
        letter_number_TB.TabIndex = 2;
        // 
        // subject_TB
        // 
        subject_TB.DataBindings.Add(new Binding("Text", out_letters_bindingSource1, "Subject", true));
        subject_TB.Location = new Point(134, 66);
        subject_TB.Name = "subject_TB";
        subject_TB.Size = new Size(524, 25);
        subject_TB.TabIndex = 2;
        // 
        // sys_id_LBL
        // 
        sys_id_LBL.BorderStyle = BorderStyle.FixedSingle;
        sys_id_LBL.DataBindings.Add(new Binding("Text", out_letters_bindingSource1, "ID", true));
        sys_id_LBL.Location = new Point(134, 34);
        sys_id_LBL.Name = "sys_id_LBL";
        sys_id_LBL.Size = new Size(239, 25);
        sys_id_LBL.TabIndex = 1;
        sys_id_LBL.Text = "-";
        sys_id_LBL.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label17
        // 
        label17.AutoSize = true;
        label17.Location = new Point(20, 467);
        label17.Name = "label17";
        label17.Size = new Size(65, 17);
        label17.TabIndex = 0;
        label17.Text = "Summary:";
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Location = new Point(20, 437);
        label16.Name = "label16";
        label16.Size = new Size(57, 17);
        label16.TabIndex = 0;
        label16.Text = "Ref Doc:";
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new Point(20, 404);
        label15.Name = "label15";
        label15.Size = new Size(78, 17);
        label15.TabIndex = 0;
        label15.Text = "Page Count:";
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(20, 374);
        label14.Name = "label14";
        label14.Size = new Size(52, 17);
        label14.TabIndex = 0;
        label14.Text = "Priority:";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(20, 344);
        label13.Name = "label13";
        label13.Size = new Size(48, 17);
        label13.TabIndex = 0;
        label13.Text = "Group:";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(20, 314);
        label12.Name = "label12";
        label12.Size = new Size(108, 17);
        label12.TabIndex = 0;
        label12.Text = "Sending Method:";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(20, 285);
        label11.Name = "label11";
        label11.Size = new Size(64, 17);
        label11.TabIndex = 0;
        label11.Text = "Recipient:";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(20, 256);
        label10.Name = "label10";
        label10.Size = new Size(52, 17);
        label10.TabIndex = 0;
        label10.Text = "Sender:";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(20, 226);
        label9.Name = "label9";
        label9.Size = new Size(75, 17);
        label9.TabIndex = 0;
        label9.Text = "Letter Type:";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(20, 197);
        label8.Name = "label8";
        label8.Size = new Size(67, 17);
        label8.TabIndex = 0;
        label8.Text = "Sent Date:";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(20, 164);
        label7.Name = "label7";
        label7.Size = new Size(68, 17);
        label7.TabIndex = 0;
        label7.Text = "Sent Time:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(20, 133);
        label5.Name = "label5";
        label5.Size = new Size(96, 17);
        label5.TabIndex = 0;
        label5.Text = "Letter Number:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(20, 101);
        label3.Name = "label3";
        label3.Size = new Size(65, 17);
        label3.TabIndex = 0;
        label3.Text = "Reg Date:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(20, 70);
        label2.Name = "label2";
        label2.Size = new Size(53, 17);
        label2.TabIndex = 0;
        label2.Text = "Subject:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(20, 41);
        label1.Name = "label1";
        label1.Size = new Size(68, 17);
        label1.TabIndex = 0;
        label1.Text = "System ID:";
        // 
        // Top_Toolstrip
        // 
        Top_Toolstrip.AutoSize = false;
        Top_Toolstrip.BackColor = SystemColors.MenuBar;
        Top_Toolstrip.Items.AddRange(new ToolStripItem[] { de_add_butt, toolStripSeparator4, de_edit_butt, toolStripSeparator1, de_delete_butt, toolStripSeparator2, de_save_butt, toolStripSeparator5, toolStripSeparator3, de_print_butt, toolStripSeparator6, de_cancel_butt, toolStripSeparator7 });
        Top_Toolstrip.Location = new Point(0, 0);
        Top_Toolstrip.Name = "Top_Toolstrip";
        Top_Toolstrip.Size = new Size(722, 70);
        Top_Toolstrip.TabIndex = 4;
        Top_Toolstrip.Text = "toolStrip1";
        // 
        // de_add_butt
        // 
        de_add_butt.BackColor = Color.WhiteSmoke;
        de_add_butt.BackgroundImageLayout = ImageLayout.Stretch;
        de_add_butt.Checked = true;
        de_add_butt.CheckState = CheckState.Indeterminate;
        de_add_butt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        de_add_butt.Image = Properties.Resources.de_new_butt;
        de_add_butt.ImageScaling = ToolStripItemImageScaling.None;
        de_add_butt.ImageTransparentColor = Color.Magenta;
        de_add_butt.Name = "de_add_butt";
        de_add_butt.Size = new Size(86, 67);
        de_add_butt.Text = "Add New F2";
        de_add_butt.TextAlign = ContentAlignment.BottomCenter;
        de_add_butt.TextImageRelation = TextImageRelation.ImageAboveText;
        de_add_butt.Click += de_add_butt_Click;
        // 
        // toolStripSeparator4
        // 
        toolStripSeparator4.Name = "toolStripSeparator4";
        toolStripSeparator4.Size = new Size(6, 70);
        // 
        // de_edit_butt
        // 
        de_edit_butt.AutoSize = false;
        de_edit_butt.BackColor = Color.WhiteSmoke;
        de_edit_butt.BackgroundImageLayout = ImageLayout.Stretch;
        de_edit_butt.Checked = true;
        de_edit_butt.CheckState = CheckState.Indeterminate;
        de_edit_butt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        de_edit_butt.Image = Properties.Resources.de_edit_butt;
        de_edit_butt.ImageScaling = ToolStripItemImageScaling.None;
        de_edit_butt.ImageTransparentColor = Color.Magenta;
        de_edit_butt.Name = "de_edit_butt";
        de_edit_butt.Size = new Size(86, 67);
        de_edit_butt.Text = "Edit F3";
        de_edit_butt.TextAlign = ContentAlignment.BottomCenter;
        de_edit_butt.TextImageRelation = TextImageRelation.ImageAboveText;
        de_edit_butt.Click += de_edit_butt_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(6, 70);
        // 
        // de_delete_butt
        // 
        de_delete_butt.AutoSize = false;
        de_delete_butt.BackColor = Color.White;
        de_delete_butt.BackgroundImageLayout = ImageLayout.Stretch;
        de_delete_butt.Checked = true;
        de_delete_butt.CheckState = CheckState.Indeterminate;
        de_delete_butt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        de_delete_butt.Image = Properties.Resources.de_delete_butt;
        de_delete_butt.ImageScaling = ToolStripItemImageScaling.None;
        de_delete_butt.ImageTransparentColor = Color.Magenta;
        de_delete_butt.Name = "de_delete_butt";
        de_delete_butt.Size = new Size(86, 67);
        de_delete_butt.Text = "Delete F4";
        de_delete_butt.TextAlign = ContentAlignment.BottomCenter;
        de_delete_butt.TextImageRelation = TextImageRelation.ImageAboveText;
        de_delete_butt.Click += de_delete_butt_Click;
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(6, 70);
        // 
        // de_save_butt
        // 
        de_save_butt.AutoSize = false;
        de_save_butt.BackColor = Color.WhiteSmoke;
        de_save_butt.BackgroundImageLayout = ImageLayout.Stretch;
        de_save_butt.Checked = true;
        de_save_butt.CheckState = CheckState.Indeterminate;
        de_save_butt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        de_save_butt.Image = Properties.Resources.de_save_butt;
        de_save_butt.ImageScaling = ToolStripItemImageScaling.None;
        de_save_butt.ImageTransparentColor = Color.Magenta;
        de_save_butt.Name = "de_save_butt";
        de_save_butt.Size = new Size(86, 67);
        de_save_butt.Text = "Save F5";
        de_save_butt.TextAlign = ContentAlignment.BottomCenter;
        de_save_butt.TextImageRelation = TextImageRelation.ImageAboveText;
        de_save_butt.Click += de_save_butt_Click;
        // 
        // toolStripSeparator5
        // 
        toolStripSeparator5.Name = "toolStripSeparator5";
        toolStripSeparator5.Size = new Size(6, 70);
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Alignment = ToolStripItemAlignment.Right;
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new Size(6, 70);
        // 
        // de_print_butt
        // 
        de_print_butt.Alignment = ToolStripItemAlignment.Right;
        de_print_butt.AutoSize = false;
        de_print_butt.BackColor = Color.WhiteSmoke;
        de_print_butt.BackgroundImageLayout = ImageLayout.Stretch;
        de_print_butt.Checked = true;
        de_print_butt.CheckState = CheckState.Indeterminate;
        de_print_butt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        de_print_butt.Image = Properties.Resources.de_print_butt;
        de_print_butt.ImageScaling = ToolStripItemImageScaling.None;
        de_print_butt.ImageTransparentColor = Color.Magenta;
        de_print_butt.Name = "de_print_butt";
        de_print_butt.Size = new Size(86, 67);
        de_print_butt.Text = "Print F9";
        de_print_butt.TextAlign = ContentAlignment.BottomCenter;
        de_print_butt.TextImageRelation = TextImageRelation.ImageAboveText;
        de_print_butt.ToolTipText = "Print F9";
        de_print_butt.Click += de_print_butt_Click;
        // 
        // toolStripSeparator6
        // 
        toolStripSeparator6.Alignment = ToolStripItemAlignment.Right;
        toolStripSeparator6.Name = "toolStripSeparator6";
        toolStripSeparator6.Size = new Size(6, 70);
        // 
        // de_cancel_butt
        // 
        de_cancel_butt.AutoSize = false;
        de_cancel_butt.BackColor = Color.WhiteSmoke;
        de_cancel_butt.BackgroundImageLayout = ImageLayout.Stretch;
        de_cancel_butt.Checked = true;
        de_cancel_butt.CheckState = CheckState.Indeterminate;
        de_cancel_butt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        de_cancel_butt.Image = Properties.Resources.de_button_cancel24;
        de_cancel_butt.ImageScaling = ToolStripItemImageScaling.None;
        de_cancel_butt.ImageTransparentColor = Color.Magenta;
        de_cancel_butt.Name = "de_cancel_butt";
        de_cancel_butt.Size = new Size(86, 67);
        de_cancel_butt.Text = "Cancel F6";
        de_cancel_butt.TextAlign = ContentAlignment.BottomCenter;
        de_cancel_butt.TextImageRelation = TextImageRelation.ImageAboveText;
        de_cancel_butt.Click += de_cancel_butt_Click;
        // 
        // toolStripSeparator7
        // 
        toolStripSeparator7.Name = "toolStripSeparator7";
        toolStripSeparator7.Size = new Size(6, 70);
        // 
        // system_time_lbl
        // 
        system_time_lbl.DataBindings.Add(new Binding("Text", out_letters_bindingSource1, "SysTime", true));
        system_time_lbl.ForeColor = Color.FromArgb(192, 0, 0);
        system_time_lbl.Location = new Point(617, 8);
        system_time_lbl.Name = "system_time_lbl";
        system_time_lbl.Size = new Size(95, 17);
        system_time_lbl.TabIndex = 7;
        system_time_lbl.Text = "-";
        // 
        // panel1
        // 
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Controls.Add(system_time_lbl);
        panel1.Controls.Add(label6);
        panel1.Controls.Add(system_date_lbl);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(user_id_lbl);
        panel1.Controls.Add(userId_lbl);
        panel1.Controls.Add(user_name_lbl);
        panel1.Controls.Add(userName_lbl);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 640);
        panel1.Name = "panel1";
        panel1.Size = new Size(722, 35);
        panel1.TabIndex = 5;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(528, 8);
        label6.Name = "label6";
        label6.Size = new Size(84, 17);
        label6.TabIndex = 6;
        label6.Text = "System Time:";
        // 
        // system_date_lbl
        // 
        system_date_lbl.DataBindings.Add(new Binding("Text", out_letters_bindingSource1, "SysDate", true));
        system_date_lbl.ForeColor = Color.FromArgb(192, 0, 0);
        system_date_lbl.Location = new Point(419, 8);
        system_date_lbl.Name = "system_date_lbl";
        system_date_lbl.Size = new Size(103, 17);
        system_date_lbl.TabIndex = 5;
        system_date_lbl.Text = "-";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(330, 8);
        label4.Name = "label4";
        label4.Size = new Size(83, 17);
        label4.TabIndex = 4;
        label4.Text = "System Date:";
        // 
        // user_id_lbl
        // 
        user_id_lbl.DataBindings.Add(new Binding("Text", out_letters_bindingSource1, "UserId", true));
        user_id_lbl.ForeColor = Color.FromArgb(192, 0, 0);
        user_id_lbl.Location = new Point(253, 8);
        user_id_lbl.Name = "user_id_lbl";
        user_id_lbl.Size = new Size(56, 17);
        user_id_lbl.TabIndex = 3;
        user_id_lbl.Text = "-";
        // 
        // userId_lbl
        // 
        userId_lbl.AutoSize = true;
        userId_lbl.Location = new Point(194, 8);
        userId_lbl.Name = "userId_lbl";
        userId_lbl.Size = new Size(53, 17);
        userId_lbl.TabIndex = 2;
        userId_lbl.Text = "User Id:";
        // 
        // user_name_lbl
        // 
        user_name_lbl.DataBindings.Add(new Binding("Text", out_letters_bindingSource1, "UserName", true));
        user_name_lbl.ForeColor = Color.FromArgb(192, 0, 0);
        user_name_lbl.Location = new Point(94, 8);
        user_name_lbl.Name = "user_name_lbl";
        user_name_lbl.Size = new Size(93, 17);
        user_name_lbl.TabIndex = 1;
        user_name_lbl.Text = "-";
        // 
        // userName_lbl
        // 
        userName_lbl.AutoSize = true;
        userName_lbl.Location = new Point(11, 8);
        userName_lbl.Name = "userName_lbl";
        userName_lbl.Size = new Size(77, 17);
        userName_lbl.TabIndex = 0;
        userName_lbl.Text = "User Name:";
        // 
        // id_label7
        // 
        id_label7.AutoSize = true;
        id_label7.Location = new Point(845, 147);
        id_label7.Name = "id_label7";
        id_label7.Size = new Size(43, 17);
        id_label7.TabIndex = 12;
        id_label7.Text = "label3";
        // 
        // sa_Out_LettersTableAdapter1
        // 
        sa_Out_LettersTableAdapter1.ClearBeforeFill = true;
        // 
        // Out_Letters_De
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.MenuBar;
        ClientSize = new Size(722, 675);
        Controls.Add(id_label7);
        Controls.Add(main_gbox);
        Controls.Add(Top_Toolstrip);
        Controls.Add(panel1);
        Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        KeyPreview = true;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Out_Letters_De";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Outgoing Letters Data Entry";
        Load += Out_Letters_De_Load;
        KeyDown += Out_Letters_De_KeyDown;
        main_gbox.ResumeLayout(false);
        main_gbox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)out_letters_bindingSource1).EndInit();
        ((System.ComponentModel.ISupportInitialize)letters1).EndInit();
        ((System.ComponentModel.ISupportInitialize)page_count_NC).EndInit();
        Top_Toolstrip.ResumeLayout(false);
        Top_Toolstrip.PerformLayout();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox main_gbox;
    private Button today_resDate_btn;
    private Button today_regDate_Btn;
    private NumericUpDown page_count_NC;
    private BindingSource out_letters_bindingSource1;
    private DataSet.Letters letters1;
    private ComboBox priority_CB;
    private MaskedTextBox sent_date_masked_TB;
    private MaskedTextBox sent_time_masked_TB;
    private MaskedTextBox reg_date_masked_TB;
    private TextBox summary_TB;
    private TextBox ref_doc_TB;
    private TextBox group_TB;
    private TextBox sending_Method_TB;
    private TextBox recipient_TB;
    private TextBox sender_TB;
    private TextBox letter_number_TB;
    private TextBox subject_TB;
    private Label sys_id_LBL;
    private Label label17;
    private Label label16;
    private Label label15;
    private Label label14;
    private Label label13;
    private Label label12;
    private Label label11;
    private Label label10;
    private Label label9;
    private Label label8;
    private Label label7;
    private Label label5;
    private Label label3;
    private Label label2;
    private Label label1;
    private ToolStrip Top_Toolstrip;
    public ToolStripButton de_add_butt;
    private ToolStripSeparator toolStripSeparator4;
    public ToolStripButton de_edit_butt;
    private ToolStripSeparator toolStripSeparator1;
    public ToolStripButton de_delete_butt;
    private ToolStripSeparator toolStripSeparator2;
    public ToolStripButton de_save_butt;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripSeparator toolStripSeparator3;
    public ToolStripButton de_print_butt;
    private ToolStripSeparator toolStripSeparator6;
    public ToolStripButton de_cancel_butt;
    private ToolStripSeparator toolStripSeparator7;
    private Label system_time_lbl;
    private Panel panel1;
    private Label label6;
    private Label system_date_lbl;
    private Label label4;
    private Label user_id_lbl;
    private Label userId_lbl;
    private Label user_name_lbl;
    private Label userName_lbl;
    public Label id_label7;
    private ComboBox letter_type_comboBox1;
    private DataSet.LettersTableAdapters.Sa_Out_LettersTableAdapter sa_Out_LettersTableAdapter1;
}