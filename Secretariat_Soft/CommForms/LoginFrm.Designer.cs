namespace Secretariat_Soft.CommForms;

partial class LoginFrm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
        ok_button1 = new Button();
        cancel_button2 = new Button();
        user_pictureBox1 = new PictureBox();
        appusers_bindingSource1 = new BindingSource(components);
        letters1 = new DataSet.Letters();
        username_CB = new ComboBox();
        password_TB = new TextBox();
        label5 = new Label();
        label1 = new Label();
        panel1 = new Panel();
        appUsersTableAdapter1 = new DataSet.LettersTableAdapters.AppUsersTableAdapter();
        sys_id_LBL = new Label();
        label2 = new Label();
        correct_pass_textBox1 = new TextBox();
        label3 = new Label();
        panel2 = new Panel();
        settings_button1 = new Button();
        ((System.ComponentModel.ISupportInitialize)user_pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)appusers_bindingSource1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)letters1).BeginInit();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // ok_button1
        // 
        ok_button1.Cursor = Cursors.Hand;
        ok_button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        ok_button1.Location = new Point(351, 358);
        ok_button1.Name = "ok_button1";
        ok_button1.Size = new Size(161, 35);
        ok_button1.TabIndex = 0;
        ok_button1.Text = "Ok (Enter)";
        ok_button1.UseVisualStyleBackColor = true;
        ok_button1.Click += ok_button1_Click;
        // 
        // cancel_button2
        // 
        cancel_button2.BackColor = Color.Transparent;
        cancel_button2.BackgroundImage = Properties.Resources.bk_exit;
        cancel_button2.BackgroundImageLayout = ImageLayout.Stretch;
        cancel_button2.Cursor = Cursors.Hand;
        cancel_button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        cancel_button2.Location = new Point(667, 454);
        cancel_button2.Name = "cancel_button2";
        cancel_button2.Size = new Size(55, 48);
        cancel_button2.TabIndex = 1;
        cancel_button2.UseVisualStyleBackColor = false;
        cancel_button2.Click += cancel_button2_Click;
        // 
        // user_pictureBox1
        // 
        user_pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        user_pictureBox1.DataBindings.Add(new Binding("Image", appusers_bindingSource1, "Photo", true));
        user_pictureBox1.Location = new Point(301, 43);
        user_pictureBox1.Name = "user_pictureBox1";
        user_pictureBox1.Size = new Size(161, 182);
        user_pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        user_pictureBox1.TabIndex = 20;
        user_pictureBox1.TabStop = false;
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
        // username_CB
        // 
        username_CB.Cursor = Cursors.Hand;
        username_CB.DataSource = appusers_bindingSource1;
        username_CB.DisplayMember = "User_Name";
        username_CB.DropDownStyle = ComboBoxStyle.DropDownList;
        username_CB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        username_CB.FormattingEnabled = true;
        username_CB.Location = new Point(120, 23);
        username_CB.Name = "username_CB";
        username_CB.Size = new Size(161, 29);
        username_CB.TabIndex = 21;
        // 
        // password_TB
        // 
        password_TB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        password_TB.Location = new Point(120, 69);
        password_TB.MaxLength = 10;
        password_TB.Name = "password_TB";
        password_TB.PasswordChar = '*';
        password_TB.Size = new Size(161, 29);
        password_TB.TabIndex = 23;
        password_TB.Text = "123";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.BackColor = Color.Transparent;
        label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label5.ForeColor = SystemColors.ControlLight;
        label5.Location = new Point(15, 72);
        label5.Name = "label5";
        label5.Size = new Size(86, 21);
        label5.TabIndex = 22;
        label5.Text = "Password:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = Color.Transparent;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label1.ForeColor = SystemColors.ControlLight;
        label1.Location = new Point(15, 26);
        label1.Name = "label1";
        label1.Size = new Size(98, 21);
        label1.TabIndex = 24;
        label1.Text = "User Name:";
        // 
        // panel1
        // 
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Location = new Point(215, 472);
        panel1.Name = "panel1";
        panel1.Size = new Size(357, 1);
        panel1.TabIndex = 25;
        // 
        // appUsersTableAdapter1
        // 
        appUsersTableAdapter1.ClearBeforeFill = true;
        // 
        // sys_id_LBL
        // 
        sys_id_LBL.BorderStyle = BorderStyle.FixedSingle;
        sys_id_LBL.DataBindings.Add(new Binding("Text", appusers_bindingSource1, "id", true));
        sys_id_LBL.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        sys_id_LBL.Location = new Point(850, 98);
        sys_id_LBL.Name = "sys_id_LBL";
        sys_id_LBL.Size = new Size(98, 25);
        sys_id_LBL.TabIndex = 27;
        sys_id_LBL.Text = "-";
        sys_id_LBL.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(790, 98);
        label2.Name = "label2";
        label2.Size = new Size(54, 17);
        label2.TabIndex = 26;
        label2.Text = "User ID:";
        // 
        // correct_pass_textBox1
        // 
        correct_pass_textBox1.DataBindings.Add(new Binding("Text", appusers_bindingSource1, "Password", true));
        correct_pass_textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        correct_pass_textBox1.Location = new Point(850, 137);
        correct_pass_textBox1.Name = "correct_pass_textBox1";
        correct_pass_textBox1.ReadOnly = true;
        correct_pass_textBox1.Size = new Size(98, 25);
        correct_pass_textBox1.TabIndex = 29;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(777, 140);
        label3.Name = "label3";
        label3.Size = new Size(67, 17);
        label3.TabIndex = 28;
        label3.Text = "Password:";
        // 
        // panel2
        // 
        panel2.Controls.Add(label1);
        panel2.Controls.Add(password_TB);
        panel2.Controls.Add(label5);
        panel2.Controls.Add(username_CB);
        panel2.Location = new Point(231, 246);
        panel2.Name = "panel2";
        panel2.Size = new Size(304, 181);
        panel2.TabIndex = 30;
        // 
        // settings_button1
        // 
        settings_button1.BackColor = Color.Transparent;
        settings_button1.BackgroundImageLayout = ImageLayout.Stretch;
        settings_button1.Cursor = Cursors.Hand;
        settings_button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        settings_button1.Image = (Image)resources.GetObject("settings_button1.Image");
        settings_button1.Location = new Point(12, 12);
        settings_button1.Name = "settings_button1";
        settings_button1.Size = new Size(47, 43);
        settings_button1.TabIndex = 31;
        settings_button1.UseVisualStyleBackColor = false;
        settings_button1.Click += settings_button1_Click;
        // 
        // LoginFrm
        // 
        AcceptButton = ok_button1;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.MenuBar;
        BackgroundImage = Properties.Resources.login;
        BackgroundImageLayout = ImageLayout.Stretch;
        CancelButton = cancel_button2;
        ClientSize = new Size(726, 506);
        ControlBox = false;
        Controls.Add(settings_button1);
        Controls.Add(correct_pass_textBox1);
        Controls.Add(label3);
        Controls.Add(ok_button1);
        Controls.Add(sys_id_LBL);
        Controls.Add(user_pictureBox1);
        Controls.Add(label2);
        Controls.Add(panel1);
        Controls.Add(cancel_button2);
        Controls.Add(panel2);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LoginFrm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        Load += LoginFrm_Load;
        ((System.ComponentModel.ISupportInitialize)user_pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)appusers_bindingSource1).EndInit();
        ((System.ComponentModel.ISupportInitialize)letters1).EndInit();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button ok_button1;
    private Button cancel_button2;
    private TextBox password_TB;
    private Label label5;
    private Label label1;
    private Panel panel1;
    private BindingSource appusers_bindingSource1;
    private DataSet.Letters letters1;
    private DataSet.LettersTableAdapters.AppUsersTableAdapter appUsersTableAdapter1;
    private Label label2;
    private TextBox correct_pass_textBox1;
    private Label label3;
    public PictureBox user_pictureBox1;
    public ComboBox username_CB;
    public Label sys_id_LBL;
    private Panel panel2;
    private Button settings_button1;
}