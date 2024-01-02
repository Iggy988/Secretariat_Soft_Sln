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
        ((System.ComponentModel.ISupportInitialize)user_pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)appusers_bindingSource1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)letters1).BeginInit();
        SuspendLayout();
        // 
        // ok_button1
        // 
        ok_button1.Cursor = Cursors.Hand;
        ok_button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        ok_button1.Location = new Point(57, 344);
        ok_button1.Name = "ok_button1";
        ok_button1.Size = new Size(92, 30);
        ok_button1.TabIndex = 0;
        ok_button1.Text = "Ok";
        ok_button1.UseVisualStyleBackColor = true;
        ok_button1.Click += ok_button1_Click;
        // 
        // cancel_button2
        // 
        cancel_button2.Cursor = Cursors.Hand;
        cancel_button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        cancel_button2.Location = new Point(214, 344);
        cancel_button2.Name = "cancel_button2";
        cancel_button2.Size = new Size(89, 30);
        cancel_button2.TabIndex = 1;
        cancel_button2.Text = "Cancel";
        cancel_button2.UseVisualStyleBackColor = true;
        cancel_button2.Click += cancel_button2_Click;
        // 
        // user_pictureBox1
        // 
        user_pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        user_pictureBox1.DataBindings.Add(new Binding("Image", appusers_bindingSource1, "Photo", true));
        user_pictureBox1.Location = new Point(103, 31);
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
        username_CB.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        username_CB.FormattingEnabled = true;
        username_CB.Location = new Point(103, 234);
        username_CB.Name = "username_CB";
        username_CB.Size = new Size(161, 25);
        username_CB.TabIndex = 21;
        // 
        // password_TB
        // 
        password_TB.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        password_TB.Location = new Point(103, 280);
        password_TB.MaxLength = 10;
        password_TB.Name = "password_TB";
        password_TB.PasswordChar = '*';
        password_TB.Size = new Size(161, 25);
        password_TB.TabIndex = 23;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        label5.Location = new Point(20, 283);
        label5.Name = "label5";
        label5.Size = new Size(67, 17);
        label5.TabIndex = 22;
        label5.Text = "Password:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(20, 237);
        label1.Name = "label1";
        label1.Size = new Size(77, 17);
        label1.TabIndex = 24;
        label1.Text = "User Name:";
        // 
        // panel1
        // 
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Location = new Point(5, 324);
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
        sys_id_LBL.Location = new Point(465, 93);
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
        label2.Location = new Point(405, 93);
        label2.Name = "label2";
        label2.Size = new Size(54, 17);
        label2.TabIndex = 26;
        label2.Text = "User ID:";
        // 
        // correct_pass_textBox1
        // 
        correct_pass_textBox1.DataBindings.Add(new Binding("Text", appusers_bindingSource1, "Password", true));
        correct_pass_textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        correct_pass_textBox1.Location = new Point(465, 132);
        correct_pass_textBox1.Name = "correct_pass_textBox1";
        correct_pass_textBox1.ReadOnly = true;
        correct_pass_textBox1.Size = new Size(98, 25);
        correct_pass_textBox1.TabIndex = 29;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(392, 135);
        label3.Name = "label3";
        label3.Size = new Size(67, 17);
        label3.TabIndex = 28;
        label3.Text = "Password:";
        // 
        // LoginFrm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.MenuBar;
        ClientSize = new Size(365, 386);
        ControlBox = false;
        Controls.Add(correct_pass_textBox1);
        Controls.Add(label3);
        Controls.Add(sys_id_LBL);
        Controls.Add(label2);
        Controls.Add(panel1);
        Controls.Add(label1);
        Controls.Add(password_TB);
        Controls.Add(label5);
        Controls.Add(username_CB);
        Controls.Add(user_pictureBox1);
        Controls.Add(cancel_button2);
        Controls.Add(ok_button1);
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
}