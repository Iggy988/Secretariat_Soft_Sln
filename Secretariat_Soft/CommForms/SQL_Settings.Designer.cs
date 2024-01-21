namespace Secretariat_Soft.CommForms;

partial class SQL_Settings
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
        server_name_label1 = new Label();
        server_name_textBox1 = new TextBox();
        database_textBox1 = new TextBox();
        database_label1 = new Label();
        win_authentication_radioButton1 = new RadioButton();
        sql_server_auth_radioButton1 = new RadioButton();
        username_textBox1 = new TextBox();
        username_lbl = new Label();
        password_textBox1 = new TextBox();
        password_label1 = new Label();
        authentication_panel1 = new Panel();
        exit_button = new Button();
        save_button1 = new Button();
        authentication_panel1.SuspendLayout();
        SuspendLayout();
        // 
        // server_name_label1
        // 
        server_name_label1.AutoSize = true;
        server_name_label1.Location = new Point(39, 34);
        server_name_label1.Name = "server_name_label1";
        server_name_label1.Size = new Size(87, 17);
        server_name_label1.TabIndex = 0;
        server_name_label1.Text = "Server Name:";
        // 
        // server_name_textBox1
        // 
        server_name_textBox1.Location = new Point(161, 31);
        server_name_textBox1.Name = "server_name_textBox1";
        server_name_textBox1.Size = new Size(259, 25);
        server_name_textBox1.TabIndex = 1;
        // 
        // database_textBox1
        // 
        database_textBox1.Location = new Point(161, 80);
        database_textBox1.Name = "database_textBox1";
        database_textBox1.Size = new Size(259, 25);
        database_textBox1.TabIndex = 3;
        // 
        // database_label1
        // 
        database_label1.AutoSize = true;
        database_label1.Location = new Point(39, 83);
        database_label1.Name = "database_label1";
        database_label1.Size = new Size(105, 17);
        database_label1.TabIndex = 2;
        database_label1.Text = "Database Name:";
        // 
        // win_authentication_radioButton1
        // 
        win_authentication_radioButton1.AutoSize = true;
        win_authentication_radioButton1.Checked = true;
        win_authentication_radioButton1.Cursor = Cursors.Hand;
        win_authentication_radioButton1.Location = new Point(161, 130);
        win_authentication_radioButton1.Name = "win_authentication_radioButton1";
        win_authentication_radioButton1.Size = new Size(165, 21);
        win_authentication_radioButton1.TabIndex = 4;
        win_authentication_radioButton1.TabStop = true;
        win_authentication_radioButton1.Text = "Windows Authentication";
        win_authentication_radioButton1.UseVisualStyleBackColor = true;
        // 
        // sql_server_auth_radioButton1
        // 
        sql_server_auth_radioButton1.AutoSize = true;
        sql_server_auth_radioButton1.Cursor = Cursors.Hand;
        sql_server_auth_radioButton1.Location = new Point(161, 166);
        sql_server_auth_radioButton1.Name = "sql_server_auth_radioButton1";
        sql_server_auth_radioButton1.Size = new Size(176, 21);
        sql_server_auth_radioButton1.TabIndex = 5;
        sql_server_auth_radioButton1.Text = "SQL Server Authentication";
        sql_server_auth_radioButton1.UseVisualStyleBackColor = true;
        sql_server_auth_radioButton1.CheckedChanged += sql_server_auth_radioButton1_CheckedChanged;
        // 
        // username_textBox1
        // 
        username_textBox1.Location = new Point(125, 18);
        username_textBox1.Name = "username_textBox1";
        username_textBox1.Size = new Size(176, 25);
        username_textBox1.TabIndex = 7;
        // 
        // username_lbl
        // 
        username_lbl.AutoSize = true;
        username_lbl.Location = new Point(27, 21);
        username_lbl.Name = "username_lbl";
        username_lbl.Size = new Size(77, 17);
        username_lbl.TabIndex = 6;
        username_lbl.Text = "User Name:";
        // 
        // password_textBox1
        // 
        password_textBox1.Location = new Point(125, 56);
        password_textBox1.Name = "password_textBox1";
        password_textBox1.PasswordChar = '*';
        password_textBox1.Size = new Size(176, 25);
        password_textBox1.TabIndex = 9;
        // 
        // password_label1
        // 
        password_label1.AutoSize = true;
        password_label1.Location = new Point(27, 59);
        password_label1.Name = "password_label1";
        password_label1.Size = new Size(67, 17);
        password_label1.TabIndex = 8;
        password_label1.Text = "Password:";
        // 
        // authentication_panel1
        // 
        authentication_panel1.Controls.Add(password_textBox1);
        authentication_panel1.Controls.Add(password_label1);
        authentication_panel1.Controls.Add(username_textBox1);
        authentication_panel1.Controls.Add(username_lbl);
        authentication_panel1.Location = new Point(62, 200);
        authentication_panel1.Name = "authentication_panel1";
        authentication_panel1.Size = new Size(332, 102);
        authentication_panel1.TabIndex = 10;
        authentication_panel1.Visible = false;
        // 
        // exit_button
        // 
        exit_button.BackColor = SystemColors.ButtonFace;
        exit_button.Cursor = Cursors.Hand;
        exit_button.Image = Properties.Resources.bk_exit;
        exit_button.Location = new Point(305, 356);
        exit_button.Name = "exit_button";
        exit_button.Size = new Size(115, 40);
        exit_button.TabIndex = 12;
        exit_button.Text = "Exit";
        exit_button.TextImageRelation = TextImageRelation.ImageBeforeText;
        exit_button.UseVisualStyleBackColor = false;
        exit_button.Click += exit_button_Click;
        // 
        // save_button1
        // 
        save_button1.BackColor = SystemColors.ButtonFace;
        save_button1.Cursor = Cursors.Hand;
        save_button1.Image = Properties.Resources.de_save_butt;
        save_button1.Location = new Point(39, 356);
        save_button1.Name = "save_button1";
        save_button1.Size = new Size(126, 40);
        save_button1.TabIndex = 11;
        save_button1.Text = "Save && Exit";
        save_button1.TextImageRelation = TextImageRelation.ImageBeforeText;
        save_button1.UseVisualStyleBackColor = false;
        save_button1.Click += save_button1_Click;
        // 
        // SQL_Settings
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(460, 441);
        Controls.Add(exit_button);
        Controls.Add(save_button1);
        Controls.Add(authentication_panel1);
        Controls.Add(sql_server_auth_radioButton1);
        Controls.Add(win_authentication_radioButton1);
        Controls.Add(database_textBox1);
        Controls.Add(database_label1);
        Controls.Add(server_name_textBox1);
        Controls.Add(server_name_label1);
        Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "SQL_Settings";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "SQL Server Settings";
        Load += SQL_Settings_Load;
        authentication_panel1.ResumeLayout(false);
        authentication_panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label server_name_label1;
    private TextBox server_name_textBox1;
    private TextBox database_textBox1;
    private Label database_label1;
    private RadioButton win_authentication_radioButton1;
    private RadioButton sql_server_auth_radioButton1;
    private TextBox username_textBox1;
    private Label username_lbl;
    private TextBox password_textBox1;
    private Label password_label1;
    private Panel authentication_panel1;
    private Button exit_button;
    private Button save_button1;
}