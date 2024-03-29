﻿namespace Secretariat_Soft.S_Forms;

partial class In_Letters_List
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        Top_Toolstrip = new ToolStrip();
        add_butt = new ToolStripButton();
        toolStripSeparator3 = new ToolStripSeparator();
        print_butt = new ToolStripDropDownButton();
        incomingLettersListToolStripMenuItem = new ToolStripMenuItem();
        incomingLetterDetailsToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        search_butt = new ToolStripButton();
        toolStripSeparator2 = new ToolStripSeparator();
        toolStripSeparator4 = new ToolStripSeparator();
        Bottom_ToolStrip = new ToolStrip();
        FirstButt = new ToolStripButton();
        SecondButt = new ToolStripButton();
        position_tbox = new ToolStripTextBox();
        total_records_lbl = new ToolStripLabel();
        ThirdButt = new ToolStripButton();
        FourthButt = new ToolStripButton();
        dataGridView1 = new DataGridView();
        iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        regDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        subjectDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        letterNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        letterTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        recivedDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        letterTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        senderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        recipientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        reciveMethodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        groupNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        priorityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        pageCountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        deadlineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        refDocDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        docSummaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        sysDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        sysTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        in_letters_bindingSource1 = new BindingSource(components);
        letters1 = new DataSet.Letters();
        sa_In_LettersTableAdapter1 = new DataSet.LettersTableAdapters.Sa_In_LettersTableAdapter();
        search_pannel2 = new Panel();
        search_date_butt = new Button();
        label2 = new Label();
        dateTimePicker2 = new DateTimePicker();
        dateTimePicker1 = new DateTimePicker();
        label1 = new Label();
        searc_subject_like_butt = new Button();
        search_subject_textbox = new TextBox();
        search_panel_butt = new Button();
        subject_like_lbl = new Label();
        search_textbox = new TextBox();
        search_id_lbl = new Label();
        search_pannel1 = new Panel();
        id_label = new Label();
        Top_Toolstrip.SuspendLayout();
        Bottom_ToolStrip.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)in_letters_bindingSource1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)letters1).BeginInit();
        search_pannel2.SuspendLayout();
        SuspendLayout();
        // 
        // Top_Toolstrip
        // 
        Top_Toolstrip.AutoSize = false;
        Top_Toolstrip.Items.AddRange(new ToolStripItem[] { add_butt, toolStripSeparator3, print_butt, toolStripSeparator1, search_butt, toolStripSeparator2, toolStripSeparator4 });
        Top_Toolstrip.Location = new Point(0, 0);
        Top_Toolstrip.Name = "Top_Toolstrip";
        Top_Toolstrip.Size = new Size(1175, 70);
        Top_Toolstrip.TabIndex = 0;
        Top_Toolstrip.Text = "toolStrip1";
        // 
        // add_butt
        // 
        add_butt.BackColor = Color.WhiteSmoke;
        add_butt.BackgroundImageLayout = ImageLayout.Stretch;
        add_butt.Checked = true;
        add_butt.CheckState = CheckState.Indeterminate;
        add_butt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        add_butt.Image = Properties.Resources.butt_edit;
        add_butt.ImageScaling = ToolStripItemImageScaling.None;
        add_butt.ImageTransparentColor = Color.Magenta;
        add_butt.Name = "add_butt";
        add_butt.Size = new Size(157, 67);
        add_butt.Text = "Add | Edit Document F2";
        add_butt.TextImageRelation = TextImageRelation.ImageAboveText;
        add_butt.Click += add_butt_Click;
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Alignment = ToolStripItemAlignment.Right;
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new Size(6, 70);
        // 
        // print_butt
        // 
        print_butt.Alignment = ToolStripItemAlignment.Right;
        print_butt.AutoSize = false;
        print_butt.BackColor = Color.WhiteSmoke;
        print_butt.BackgroundImageLayout = ImageLayout.Stretch;
        print_butt.DropDownItems.AddRange(new ToolStripItem[] { incomingLettersListToolStripMenuItem, incomingLetterDetailsToolStripMenuItem });
        print_butt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        print_butt.Image = Properties.Resources.butt_print;
        print_butt.ImageScaling = ToolStripItemImageScaling.None;
        print_butt.ImageTransparentColor = Color.Magenta;
        print_butt.Name = "print_butt";
        print_butt.Size = new Size(100, 67);
        print_butt.Text = "Print F4";
        print_butt.TextImageRelation = TextImageRelation.ImageAboveText;
        print_butt.Click += print_butt_Click;
        // 
        // incomingLettersListToolStripMenuItem
        // 
        incomingLettersListToolStripMenuItem.Name = "incomingLettersListToolStripMenuItem";
        incomingLettersListToolStripMenuItem.Size = new Size(216, 22);
        incomingLettersListToolStripMenuItem.Text = "Incoming Letters List";
        incomingLettersListToolStripMenuItem.Click += incomingLettersListToolStripMenuItem_Click;
        // 
        // incomingLetterDetailsToolStripMenuItem
        // 
        incomingLetterDetailsToolStripMenuItem.Name = "incomingLetterDetailsToolStripMenuItem";
        incomingLetterDetailsToolStripMenuItem.Size = new Size(216, 22);
        incomingLetterDetailsToolStripMenuItem.Text = "Incoming Letter Details";
        incomingLetterDetailsToolStripMenuItem.Click += incomingLetterDetailsToolStripMenuItem_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Alignment = ToolStripItemAlignment.Right;
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(6, 70);
        // 
        // search_butt
        // 
        search_butt.Alignment = ToolStripItemAlignment.Right;
        search_butt.AutoSize = false;
        search_butt.BackColor = Color.WhiteSmoke;
        search_butt.BackgroundImageLayout = ImageLayout.Stretch;
        search_butt.Checked = true;
        search_butt.CheckState = CheckState.Indeterminate;
        search_butt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        search_butt.Image = Properties.Resources.butt_search_2;
        search_butt.ImageScaling = ToolStripItemImageScaling.None;
        search_butt.ImageTransparentColor = Color.Magenta;
        search_butt.Name = "search_butt";
        search_butt.Size = new Size(100, 67);
        search_butt.Text = "Search F3";
        search_butt.TextImageRelation = TextImageRelation.ImageAboveText;
        search_butt.Click += search_butt_Click;
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Alignment = ToolStripItemAlignment.Right;
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(6, 70);
        // 
        // toolStripSeparator4
        // 
        toolStripSeparator4.Name = "toolStripSeparator4";
        toolStripSeparator4.Size = new Size(6, 70);
        // 
        // Bottom_ToolStrip
        // 
        Bottom_ToolStrip.AutoSize = false;
        Bottom_ToolStrip.BackgroundImage = Properties.Resources.bg;
        Bottom_ToolStrip.BackgroundImageLayout = ImageLayout.Stretch;
        Bottom_ToolStrip.Dock = DockStyle.Bottom;
        Bottom_ToolStrip.Items.AddRange(new ToolStripItem[] { FirstButt, SecondButt, position_tbox, total_records_lbl, ThirdButt, FourthButt });
        Bottom_ToolStrip.Location = new Point(0, 577);
        Bottom_ToolStrip.Name = "Bottom_ToolStrip";
        Bottom_ToolStrip.Size = new Size(1175, 50);
        Bottom_ToolStrip.TabIndex = 1;
        Bottom_ToolStrip.Text = "toolStrip2";
        // 
        // FirstButt
        // 
        FirstButt.AutoSize = false;
        FirstButt.DisplayStyle = ToolStripItemDisplayStyle.Image;
        FirstButt.Image = Properties.Resources.nav_first;
        FirstButt.ImageTransparentColor = Color.Magenta;
        FirstButt.Name = "FirstButt";
        FirstButt.Size = new Size(35, 35);
        FirstButt.Text = "toolStripButton1";
        FirstButt.Click += FirstButt_Click;
        // 
        // SecondButt
        // 
        SecondButt.AutoSize = false;
        SecondButt.DisplayStyle = ToolStripItemDisplayStyle.Image;
        SecondButt.Image = Properties.Resources.nav_previous;
        SecondButt.ImageTransparentColor = Color.Magenta;
        SecondButt.Name = "SecondButt";
        SecondButt.Size = new Size(35, 35);
        SecondButt.Text = "toolStripButton1";
        SecondButt.Click += SecondButt_Click;
        // 
        // position_tbox
        // 
        position_tbox.Name = "position_tbox";
        position_tbox.Size = new Size(50, 50);
        position_tbox.TextBoxTextAlign = HorizontalAlignment.Center;
        // 
        // total_records_lbl
        // 
        total_records_lbl.Name = "total_records_lbl";
        total_records_lbl.Size = new Size(13, 47);
        total_records_lbl.Text = "0";
        // 
        // ThirdButt
        // 
        ThirdButt.AutoSize = false;
        ThirdButt.DisplayStyle = ToolStripItemDisplayStyle.Image;
        ThirdButt.Image = Properties.Resources.nav_next;
        ThirdButt.ImageTransparentColor = Color.Magenta;
        ThirdButt.Name = "ThirdButt";
        ThirdButt.Size = new Size(35, 35);
        ThirdButt.Text = "toolStripButton1";
        ThirdButt.Click += ThirdButt_Click;
        // 
        // FourthButt
        // 
        FourthButt.AutoSize = false;
        FourthButt.DisplayStyle = ToolStripItemDisplayStyle.Image;
        FourthButt.Image = Properties.Resources.nav_last;
        FourthButt.ImageTransparentColor = Color.Magenta;
        FourthButt.Name = "FourthButt";
        FourthButt.Size = new Size(35, 35);
        FourthButt.Text = "toolStripButton1";
        FourthButt.Click += FourthButt_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.AllowUserToOrderColumns = true;
        dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
        dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dataGridView1.AutoGenerateColumns = false;
        dataGridView1.BackgroundColor = Color.WhiteSmoke;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, regDateDataGridViewTextBoxColumn, subjectDataGridViewTextBoxColumn, letterNumberDataGridViewTextBoxColumn, letterTimeDataGridViewTextBoxColumn, recivedDateDataGridViewTextBoxColumn, letterTypeDataGridViewTextBoxColumn, senderDataGridViewTextBoxColumn, recipientDataGridViewTextBoxColumn, reciveMethodDataGridViewTextBoxColumn, groupNameDataGridViewTextBoxColumn, priorityDataGridViewTextBoxColumn, pageCountDataGridViewTextBoxColumn, deadlineDataGridViewTextBoxColumn, refDocDataGridViewTextBoxColumn, docSummaryDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, userIdDataGridViewTextBoxColumn, sysDateDataGridViewTextBoxColumn, sysTimeDataGridViewTextBoxColumn });
        dataGridView1.DataSource = in_letters_bindingSource1;
        dataGridView1.Location = new Point(12, 71);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.RowHeadersWidth = 40;
        dataGridView1.RowTemplate.Height = 25;
        dataGridView1.Size = new Size(1153, 482);
        dataGridView1.TabIndex = 2;
        // 
        // iDDataGridViewTextBoxColumn
        // 
        iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
        iDDataGridViewTextBoxColumn.HeaderText = "ID";
        iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
        iDDataGridViewTextBoxColumn.ReadOnly = true;
        iDDataGridViewTextBoxColumn.Width = 70;
        // 
        // regDateDataGridViewTextBoxColumn
        // 
        regDateDataGridViewTextBoxColumn.DataPropertyName = "RegDate";
        regDateDataGridViewTextBoxColumn.HeaderText = "RegDate";
        regDateDataGridViewTextBoxColumn.Name = "regDateDataGridViewTextBoxColumn";
        regDateDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // subjectDataGridViewTextBoxColumn
        // 
        subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
        subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
        subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
        subjectDataGridViewTextBoxColumn.ReadOnly = true;
        subjectDataGridViewTextBoxColumn.Width = 125;
        // 
        // letterNumberDataGridViewTextBoxColumn
        // 
        letterNumberDataGridViewTextBoxColumn.DataPropertyName = "LetterNumber";
        letterNumberDataGridViewTextBoxColumn.HeaderText = "Letter Num";
        letterNumberDataGridViewTextBoxColumn.Name = "letterNumberDataGridViewTextBoxColumn";
        letterNumberDataGridViewTextBoxColumn.ReadOnly = true;
        letterNumberDataGridViewTextBoxColumn.Width = 125;
        // 
        // letterTimeDataGridViewTextBoxColumn
        // 
        letterTimeDataGridViewTextBoxColumn.DataPropertyName = "Letter_Time";
        letterTimeDataGridViewTextBoxColumn.HeaderText = "Letter Time";
        letterTimeDataGridViewTextBoxColumn.Name = "letterTimeDataGridViewTextBoxColumn";
        letterTimeDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // recivedDateDataGridViewTextBoxColumn
        // 
        recivedDateDataGridViewTextBoxColumn.DataPropertyName = "RecivedDate";
        recivedDateDataGridViewTextBoxColumn.HeaderText = "RecivedDate";
        recivedDateDataGridViewTextBoxColumn.Name = "recivedDateDataGridViewTextBoxColumn";
        recivedDateDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // letterTypeDataGridViewTextBoxColumn
        // 
        letterTypeDataGridViewTextBoxColumn.DataPropertyName = "LetterType";
        letterTypeDataGridViewTextBoxColumn.HeaderText = "LetterType";
        letterTypeDataGridViewTextBoxColumn.Name = "letterTypeDataGridViewTextBoxColumn";
        letterTypeDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // senderDataGridViewTextBoxColumn
        // 
        senderDataGridViewTextBoxColumn.DataPropertyName = "Sender";
        senderDataGridViewTextBoxColumn.HeaderText = "Sender";
        senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
        senderDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // recipientDataGridViewTextBoxColumn
        // 
        recipientDataGridViewTextBoxColumn.DataPropertyName = "Recipient";
        recipientDataGridViewTextBoxColumn.HeaderText = "Recipient";
        recipientDataGridViewTextBoxColumn.Name = "recipientDataGridViewTextBoxColumn";
        recipientDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // reciveMethodDataGridViewTextBoxColumn
        // 
        reciveMethodDataGridViewTextBoxColumn.DataPropertyName = "Recive_Method";
        reciveMethodDataGridViewTextBoxColumn.HeaderText = "Recive_Method";
        reciveMethodDataGridViewTextBoxColumn.Name = "reciveMethodDataGridViewTextBoxColumn";
        reciveMethodDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // groupNameDataGridViewTextBoxColumn
        // 
        groupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName";
        groupNameDataGridViewTextBoxColumn.HeaderText = "GroupName";
        groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
        groupNameDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // priorityDataGridViewTextBoxColumn
        // 
        priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
        priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
        priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
        priorityDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // pageCountDataGridViewTextBoxColumn
        // 
        pageCountDataGridViewTextBoxColumn.DataPropertyName = "PageCount";
        pageCountDataGridViewTextBoxColumn.HeaderText = "PageCount";
        pageCountDataGridViewTextBoxColumn.Name = "pageCountDataGridViewTextBoxColumn";
        pageCountDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // deadlineDataGridViewTextBoxColumn
        // 
        deadlineDataGridViewTextBoxColumn.DataPropertyName = "Deadline";
        deadlineDataGridViewTextBoxColumn.HeaderText = "Deadline";
        deadlineDataGridViewTextBoxColumn.Name = "deadlineDataGridViewTextBoxColumn";
        deadlineDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // refDocDataGridViewTextBoxColumn
        // 
        refDocDataGridViewTextBoxColumn.DataPropertyName = "Ref_Doc";
        refDocDataGridViewTextBoxColumn.HeaderText = "Ref_Doc";
        refDocDataGridViewTextBoxColumn.Name = "refDocDataGridViewTextBoxColumn";
        refDocDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // docSummaryDataGridViewTextBoxColumn
        // 
        docSummaryDataGridViewTextBoxColumn.DataPropertyName = "DocSummary";
        docSummaryDataGridViewTextBoxColumn.HeaderText = "DocSummary";
        docSummaryDataGridViewTextBoxColumn.Name = "docSummaryDataGridViewTextBoxColumn";
        docSummaryDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // userNameDataGridViewTextBoxColumn
        // 
        userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
        userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
        userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
        userNameDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // userIdDataGridViewTextBoxColumn
        // 
        userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
        userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
        userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
        userIdDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // sysDateDataGridViewTextBoxColumn
        // 
        sysDateDataGridViewTextBoxColumn.DataPropertyName = "SysDate";
        sysDateDataGridViewTextBoxColumn.HeaderText = "SysDate";
        sysDateDataGridViewTextBoxColumn.Name = "sysDateDataGridViewTextBoxColumn";
        sysDateDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // sysTimeDataGridViewTextBoxColumn
        // 
        sysTimeDataGridViewTextBoxColumn.DataPropertyName = "SysTime";
        sysTimeDataGridViewTextBoxColumn.HeaderText = "SysTime";
        sysTimeDataGridViewTextBoxColumn.Name = "sysTimeDataGridViewTextBoxColumn";
        sysTimeDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // in_letters_bindingSource1
        // 
        in_letters_bindingSource1.DataMember = "Sa_In_Letters";
        in_letters_bindingSource1.DataSource = letters1;
        // 
        // letters1
        // 
        letters1.DataSetName = "Letters";
        letters1.Namespace = "http://tempuri.org/Letters.xsd";
        letters1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        // 
        // sa_In_LettersTableAdapter1
        // 
        sa_In_LettersTableAdapter1.ClearBeforeFill = true;
        // 
        // search_pannel2
        // 
        search_pannel2.BackColor = Color.Gainsboro;
        search_pannel2.Controls.Add(search_date_butt);
        search_pannel2.Controls.Add(label2);
        search_pannel2.Controls.Add(dateTimePicker2);
        search_pannel2.Controls.Add(dateTimePicker1);
        search_pannel2.Controls.Add(label1);
        search_pannel2.Controls.Add(searc_subject_like_butt);
        search_pannel2.Controls.Add(search_subject_textbox);
        search_pannel2.Controls.Add(search_panel_butt);
        search_pannel2.Controls.Add(subject_like_lbl);
        search_pannel2.Controls.Add(search_textbox);
        search_pannel2.Controls.Add(search_id_lbl);
        search_pannel2.Location = new Point(595, 107);
        search_pannel2.Name = "search_pannel2";
        search_pannel2.Size = new Size(461, 221);
        search_pannel2.TabIndex = 3;
        search_pannel2.Visible = false;
        // 
        // search_date_butt
        // 
        search_date_butt.Cursor = Cursors.Hand;
        search_date_butt.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        search_date_butt.Image = Properties.Resources.butt_search;
        search_date_butt.Location = new Point(317, 164);
        search_date_butt.Name = "search_date_butt";
        search_date_butt.Size = new Size(131, 31);
        search_date_butt.TabIndex = 9;
        search_date_butt.Text = "Search";
        search_date_butt.TextImageRelation = TextImageRelation.ImageBeforeText;
        search_date_butt.UseVisualStyleBackColor = true;
        search_date_butt.Click += search_date_butt_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        label2.Location = new Point(141, 174);
        label2.Name = "label2";
        label2.Size = new Size(30, 16);
        label2.TabIndex = 8;
        label2.Text = "To:";
        // 
        // dateTimePicker2
        // 
        dateTimePicker2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        dateTimePicker2.Format = DateTimePickerFormat.Short;
        dateTimePicker2.Location = new Point(173, 170);
        dateTimePicker2.Name = "dateTimePicker2";
        dateTimePicker2.Size = new Size(138, 25);
        dateTimePicker2.TabIndex = 7;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        dateTimePicker1.Format = DateTimePickerFormat.Short;
        dateTimePicker1.Location = new Point(173, 124);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(138, 25);
        dateTimePicker1.TabIndex = 6;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(55, 131);
        label1.Name = "label1";
        label1.Size = new Size(116, 16);
        label1.TabIndex = 5;
        label1.Text = "Reg Date From:";
        // 
        // searc_subject_like_butt
        // 
        searc_subject_like_butt.Cursor = Cursors.Hand;
        searc_subject_like_butt.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        searc_subject_like_butt.Image = Properties.Resources.butt_search;
        searc_subject_like_butt.Location = new Point(317, 68);
        searc_subject_like_butt.Name = "searc_subject_like_butt";
        searc_subject_like_butt.Size = new Size(131, 31);
        searc_subject_like_butt.TabIndex = 4;
        searc_subject_like_butt.Text = "Search";
        searc_subject_like_butt.TextImageRelation = TextImageRelation.ImageBeforeText;
        searc_subject_like_butt.UseVisualStyleBackColor = true;
        searc_subject_like_butt.Click += searc_subject_like_butt_Click;
        // 
        // search_subject_textbox
        // 
        search_subject_textbox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        search_subject_textbox.Location = new Point(173, 77);
        search_subject_textbox.Name = "search_subject_textbox";
        search_subject_textbox.Size = new Size(138, 22);
        search_subject_textbox.TabIndex = 1;
        // 
        // search_panel_butt
        // 
        search_panel_butt.Cursor = Cursors.Hand;
        search_panel_butt.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        search_panel_butt.Image = Properties.Resources.butt_search;
        search_panel_butt.ImageAlign = ContentAlignment.MiddleRight;
        search_panel_butt.Location = new Point(317, 15);
        search_panel_butt.Name = "search_panel_butt";
        search_panel_butt.Size = new Size(131, 29);
        search_panel_butt.TabIndex = 4;
        search_panel_butt.Text = "Search ID";
        search_panel_butt.TextImageRelation = TextImageRelation.ImageBeforeText;
        search_panel_butt.UseVisualStyleBackColor = true;
        search_panel_butt.Click += search_panel_butt_Click;
        // 
        // subject_like_lbl
        // 
        subject_like_lbl.AutoSize = true;
        subject_like_lbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        subject_like_lbl.Location = new Point(75, 80);
        subject_like_lbl.Name = "subject_like_lbl";
        subject_like_lbl.Size = new Size(96, 16);
        subject_like_lbl.TabIndex = 0;
        subject_like_lbl.Text = "Subject Like:";
        // 
        // search_textbox
        // 
        search_textbox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        search_textbox.Location = new Point(173, 22);
        search_textbox.Name = "search_textbox";
        search_textbox.Size = new Size(138, 22);
        search_textbox.TabIndex = 1;
        // 
        // search_id_lbl
        // 
        search_id_lbl.AutoSize = true;
        search_id_lbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        search_id_lbl.Location = new Point(145, 26);
        search_id_lbl.Name = "search_id_lbl";
        search_id_lbl.Size = new Size(26, 16);
        search_id_lbl.TabIndex = 0;
        search_id_lbl.Text = "ID:";
        // 
        // search_pannel1
        // 
        search_pannel1.BackColor = Color.Gainsboro;
        search_pannel1.BackgroundImage = Properties.Resources.down_icon;
        search_pannel1.BackgroundImageLayout = ImageLayout.Stretch;
        search_pannel1.Location = new Point(977, 73);
        search_pannel1.Name = "search_pannel1";
        search_pannel1.Size = new Size(79, 34);
        search_pannel1.TabIndex = 4;
        search_pannel1.Visible = false;
        // 
        // id_label
        // 
        id_label.AutoSize = true;
        id_label.DataBindings.Add(new Binding("Text", in_letters_bindingSource1, "ID", true));
        id_label.Location = new Point(1254, 175);
        id_label.Name = "id_label";
        id_label.Size = new Size(43, 17);
        id_label.TabIndex = 5;
        id_label.Text = "label3";
        // 
        // In_Letters_List
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(1175, 627);
        Controls.Add(id_label);
        Controls.Add(search_pannel1);
        Controls.Add(search_pannel2);
        Controls.Add(dataGridView1);
        Controls.Add(Bottom_ToolStrip);
        Controls.Add(Top_Toolstrip);
        Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        KeyPreview = true;
        MaximizeBox = false;
        Name = "In_Letters_List";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Incoming Letters List";
        Load += In_Letters_Form_Load;
        KeyDown += In_Letters_List_KeyDown;
        Top_Toolstrip.ResumeLayout(false);
        Top_Toolstrip.PerformLayout();
        Bottom_ToolStrip.ResumeLayout(false);
        Bottom_ToolStrip.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)in_letters_bindingSource1).EndInit();
        ((System.ComponentModel.ISupportInitialize)letters1).EndInit();
        search_pannel2.ResumeLayout(false);
        search_pannel2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ToolStrip Top_Toolstrip;
    private ToolStrip Bottom_ToolStrip;
    private DataGridView dataGridView1;
    private DataSet.Letters letters1;
    private BindingSource in_letters_bindingSource1;
    private DataSet.LettersTableAdapters.Sa_In_LettersTableAdapter sa_In_LettersTableAdapter1;
    private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn letterNumberDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn letterTimeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn recivedDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn letterTypeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn recipientDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn reciveMethodDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn pageCountDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn deadlineDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn refDocDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn docSummaryDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn sysDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn sysTimeDataGridViewTextBoxColumn;
    private ToolStripButton FirstButt;
    private ToolStripButton SecondButt;
    private ToolStripButton ThirdButt;
    private ToolStripButton FourthButt;
    private ToolStripTextBox position_tbox;
    private ToolStripLabel total_records_lbl;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton search_butt;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripSeparator toolStripSeparator4;
    private Panel search_pannel2;
    private Panel search_pannel1;
    private Label search_id_lbl;
    private TextBox search_textbox;
    private Button search_panel_butt;
    private Button searc_subject_like_butt;
    private TextBox search_subject_textbox;
    private Label subject_like_lbl;
    private Label label1;
    private DateTimePicker dateTimePicker1;
    private Label label2;
    private DateTimePicker dateTimePicker2;
    private Button search_date_butt;
    private Label id_label;
    private ToolStripDropDownButton print_butt;
    private ToolStripMenuItem incomingLettersListToolStripMenuItem;
    private ToolStripMenuItem incomingLetterDetailsToolStripMenuItem;
    public ToolStripButton add_butt;
}