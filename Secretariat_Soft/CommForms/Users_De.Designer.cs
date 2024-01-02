namespace Secretariat_Soft.CommForms;

partial class Users_De
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
        de_cancel_butt = new ToolStripButton();
        toolStripSeparator7 = new ToolStripSeparator();
        panel1 = new Panel();
        system_time_lbl = new Label();
        appusers_bindingSource1 = new BindingSource(components);
        letters1 = new DataSet.Letters();
        label6 = new Label();
        system_date_lbl = new Label();
        label4 = new Label();
        user_id_lbl = new Label();
        userId_lbl = new Label();
        user_name_lbl = new Label();
        userName_lbl = new Label();
        main_gbox = new GroupBox();
        browse_button1 = new Button();
        user_pictureBox1 = new PictureBox();
        comment_TB = new TextBox();
        label7 = new Label();
        password_repeat_TB = new TextBox();
        label3 = new Label();
        password_TB = new TextBox();
        user_name_TB = new TextBox();
        sys_id_LBL = new Label();
        label5 = new Label();
        label2 = new Label();
        label1 = new Label();
        appUsersTableAdapter1 = new DataSet.LettersTableAdapters.AppUsersTableAdapter();
        id_label2 = new Label();
        contextMenuStrip1 = new ContextMenuStrip(components);
        Top_Toolstrip.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)appusers_bindingSource1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)letters1).BeginInit();
        main_gbox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)user_pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // Top_Toolstrip
        // 
        Top_Toolstrip.AutoSize = false;
        Top_Toolstrip.Items.AddRange(new ToolStripItem[] { de_add_butt, toolStripSeparator4, de_edit_butt, toolStripSeparator1, de_delete_butt, toolStripSeparator2, de_save_butt, toolStripSeparator5, toolStripSeparator3, de_cancel_butt, toolStripSeparator7 });
        Top_Toolstrip.Location = new Point(0, 0);
        Top_Toolstrip.Name = "Top_Toolstrip";
        Top_Toolstrip.Size = new Size(799, 70);
        Top_Toolstrip.TabIndex = 2;
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
        de_delete_butt.BackColor = Color.WhiteSmoke;
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
        panel1.Location = new Point(0, 492);
        panel1.Name = "panel1";
        panel1.Size = new Size(799, 35);
        panel1.TabIndex = 3;
        // 
        // system_time_lbl
        // 
        system_time_lbl.DataBindings.Add(new Binding("Text", appusers_bindingSource1, "SysTime", true));
        system_time_lbl.ForeColor = Color.FromArgb(192, 0, 0);
        system_time_lbl.Location = new Point(617, 8);
        system_time_lbl.Name = "system_time_lbl";
        system_time_lbl.Size = new Size(95, 17);
        system_time_lbl.TabIndex = 7;
        system_time_lbl.Text = "-";
        // 
        // appusers_bindingSource1
        // 
        appusers_bindingSource1.DataMember = "AppUsers";
        appusers_bindingSource1.DataSource = letters1;
        // 
        // letters1
        // 
        letters1.DataSetName = "Letters";
        letters1.Namespace = "http://tempuri.org/Letters.xsd";
        letters1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(528, 8);
        label6.Name = "label6";
        label6.Size = new Size(77, 15);
        label6.TabIndex = 6;
        label6.Text = "System Time:";
        // 
        // system_date_lbl
        // 
        system_date_lbl.DataBindings.Add(new Binding("Text", appusers_bindingSource1, "SysDate", true));
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
        label4.Size = new Size(75, 15);
        label4.TabIndex = 4;
        label4.Text = "System Date:";
        // 
        // user_id_lbl
        // 
        user_id_lbl.DataBindings.Add(new Binding("Text", appusers_bindingSource1, "Sys_UserId", true));
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
        userId_lbl.Size = new Size(46, 15);
        userId_lbl.TabIndex = 2;
        userId_lbl.Text = "User Id:";
        // 
        // user_name_lbl
        // 
        user_name_lbl.DataBindings.Add(new Binding("Text", appusers_bindingSource1, "Sys_User", true));
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
        userName_lbl.Size = new Size(68, 15);
        userName_lbl.TabIndex = 0;
        userName_lbl.Text = "User Name:";
        // 
        // main_gbox
        // 
        main_gbox.Controls.Add(browse_button1);
        main_gbox.Controls.Add(user_pictureBox1);
        main_gbox.Controls.Add(comment_TB);
        main_gbox.Controls.Add(label7);
        main_gbox.Controls.Add(password_repeat_TB);
        main_gbox.Controls.Add(label3);
        main_gbox.Controls.Add(password_TB);
        main_gbox.Controls.Add(user_name_TB);
        main_gbox.Controls.Add(sys_id_LBL);
        main_gbox.Controls.Add(label5);
        main_gbox.Controls.Add(label2);
        main_gbox.Controls.Add(label1);
        main_gbox.Location = new Point(12, 83);
        main_gbox.Name = "main_gbox";
        main_gbox.Size = new Size(778, 393);
        main_gbox.TabIndex = 4;
        main_gbox.TabStop = false;
        main_gbox.Text = "info";
        // 
        // browse_button1
        // 
        browse_button1.Cursor = Cursors.Hand;
        browse_button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        browse_button1.Location = new Point(487, 177);
        browse_button1.Name = "browse_button1";
        browse_button1.Size = new Size(107, 32);
        browse_button1.TabIndex = 20;
        browse_button1.Text = "Browse";
        browse_button1.UseVisualStyleBackColor = true;
        browse_button1.Click += browse_button1_Click;
        // 
        // user_pictureBox1
        // 
        user_pictureBox1.DataBindings.Add(new Binding("Image", appusers_bindingSource1, "Photo", true));
        user_pictureBox1.Location = new Point(487, 35);
        user_pictureBox1.Name = "user_pictureBox1";
        user_pictureBox1.Size = new Size(107, 132);
        user_pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        user_pictureBox1.TabIndex = 19;
        user_pictureBox1.TabStop = false;
        // 
        // comment_TB
        // 
        comment_TB.DataBindings.Add(new Binding("Text", appusers_bindingSource1, "Comment", true));
        comment_TB.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        comment_TB.Location = new Point(162, 231);
        comment_TB.Name = "comment_TB";
        comment_TB.Size = new Size(570, 25);
        comment_TB.TabIndex = 18;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        label7.Location = new Point(51, 235);
        label7.Name = "label7";
        label7.Size = new Size(67, 17);
        label7.TabIndex = 17;
        label7.Text = "Comment:";
        // 
        // password_repeat_TB
        // 
        password_repeat_TB.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        password_repeat_TB.Location = new Point(162, 184);
        password_repeat_TB.Name = "password_repeat_TB";
        password_repeat_TB.Size = new Size(240, 25);
        password_repeat_TB.TabIndex = 16;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(51, 188);
        label3.Name = "label3";
        label3.Size = new Size(112, 17);
        label3.TabIndex = 15;
        label3.Text = "Password Repeat:";
        // 
        // password_TB
        // 
        password_TB.DataBindings.Add(new Binding("Text", appusers_bindingSource1, "Password", true));
        password_TB.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        password_TB.Location = new Point(162, 133);
        password_TB.Name = "password_TB";
        password_TB.Size = new Size(240, 25);
        password_TB.TabIndex = 13;
        // 
        // user_name_TB
        // 
        user_name_TB.DataBindings.Add(new Binding("Text", appusers_bindingSource1, "User_Name", true));
        user_name_TB.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        user_name_TB.Location = new Point(162, 85);
        user_name_TB.Name = "user_name_TB";
        user_name_TB.Size = new Size(240, 25);
        user_name_TB.TabIndex = 14;
        // 
        // sys_id_LBL
        // 
        sys_id_LBL.BorderStyle = BorderStyle.FixedSingle;
        sys_id_LBL.DataBindings.Add(new Binding("Text", appusers_bindingSource1, "id", true));
        sys_id_LBL.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        sys_id_LBL.Location = new Point(162, 35);
        sys_id_LBL.Name = "sys_id_LBL";
        sys_id_LBL.Size = new Size(240, 25);
        sys_id_LBL.TabIndex = 12;
        sys_id_LBL.Text = "-";
        sys_id_LBL.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        label5.Location = new Point(51, 137);
        label5.Name = "label5";
        label5.Size = new Size(67, 17);
        label5.TabIndex = 8;
        label5.Text = "Password:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(51, 90);
        label2.Name = "label2";
        label2.Size = new Size(77, 17);
        label2.TabIndex = 10;
        label2.Text = "User Name:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(51, 40);
        label1.Name = "label1";
        label1.Size = new Size(54, 17);
        label1.TabIndex = 11;
        label1.Text = "User ID:";
        // 
        // appUsersTableAdapter1
        // 
        appUsersTableAdapter1.ClearBeforeFill = true;
        // 
        // id_label2
        // 
        id_label2.AutoSize = true;
        id_label2.DataBindings.Add(new Binding("Text", appusers_bindingSource1, "id", true));
        id_label2.Location = new Point(879, 216);
        id_label2.Name = "id_label2";
        id_label2.Size = new Size(38, 15);
        id_label2.TabIndex = 7;
        id_label2.Text = "label3";
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new Size(61, 4);
        // 
        // Users_De
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Lavender;
        ClientSize = new Size(799, 527);
        Controls.Add(id_label2);
        Controls.Add(main_gbox);
        Controls.Add(panel1);
        Controls.Add(Top_Toolstrip);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Users_De";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Users Data Entry";
        Load += Users_De_Load;
        Top_Toolstrip.ResumeLayout(false);
        Top_Toolstrip.PerformLayout();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)appusers_bindingSource1).EndInit();
        ((System.ComponentModel.ISupportInitialize)letters1).EndInit();
        main_gbox.ResumeLayout(false);
        main_gbox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)user_pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

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
    public ToolStripButton de_cancel_butt;
    private ToolStripSeparator toolStripSeparator7;
    private Panel panel1;
    private Label system_time_lbl;
    private Label label6;
    private Label system_date_lbl;
    private Label label4;
    private Label user_id_lbl;
    private Label userId_lbl;
    private Label user_name_lbl;
    private Label userName_lbl;
    private GroupBox main_gbox;
    private TextBox password_TB;
    private TextBox user_name_TB;
    private Label sys_id_LBL;
    private Label label5;
    private Label label2;
    private Label label1;
    private TextBox password_repeat_TB;
    private Label label3;
    private TextBox comment_TB;
    private Label label7;
    private BindingSource appusers_bindingSource1;
    private DataSet.Letters letters1;
    private DataSet.LettersTableAdapters.AppUsersTableAdapter appUsersTableAdapter1;
    public Label id_label2;
    private Button browse_button1;
    private PictureBox user_pictureBox1;
    private ContextMenuStrip contextMenuStrip1;
}