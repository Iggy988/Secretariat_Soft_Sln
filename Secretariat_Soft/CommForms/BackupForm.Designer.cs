namespace Secretariat_Soft.CommForms;

partial class BackupForm
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
        panel1 = new Panel();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        panel2 = new Panel();
        label6 = new Label();
        browse_button1 = new Button();
        filename_textBox1 = new TextBox();
        backup_button1 = new Button();
        exit_button2 = new Button();
        help_button3 = new Button();
        panel3 = new Panel();
        folderBrowserDialog1 = new FolderBrowserDialog();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(192, 255, 192);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(722, 148);
        panel1.TabIndex = 0;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(12, 107);
        label4.Name = "label4";
        label4.Size = new Size(717, 17);
        label4.TabIndex = 3;
        label4.Text = "3. Be sure to backup the data at different times. In any conditions the responibility for the loss of data is at your own resk.";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(12, 81);
        label3.Name = "label3";
        label3.Size = new Size(464, 17);
        label3.TabIndex = 2;
        label3.Text = "2. No error should be displayed when backing up. An error means no backup.";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 54);
        label2.Name = "label2";
        label2.Size = new Size(487, 17);
        label2.TabIndex = 1;
        label2.Text = "1. Be sure to see a message of success after the backup, if not there is a problem.";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(214, 18);
        label1.Name = "label1";
        label1.Size = new Size(262, 17);
        label1.TabIndex = 0;
        label1.Text = "Consider the following while backing up:";
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(255, 255, 192);
        panel2.Controls.Add(label6);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 148);
        panel2.Name = "panel2";
        panel2.Size = new Size(722, 44);
        panel2.TabIndex = 1;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(12, 12);
        label6.Name = "label6";
        label6.Size = new Size(707, 17);
        label6.TabIndex = 0;
        label6.Text = "Warning: Before you change Windows and remove the program, be sure to copy the installation folder and keep it safe.";
        // 
        // browse_button1
        // 
        browse_button1.BackColor = SystemColors.ButtonFace;
        browse_button1.Cursor = Cursors.Hand;
        browse_button1.Location = new Point(38, 211);
        browse_button1.Name = "browse_button1";
        browse_button1.Size = new Size(84, 25);
        browse_button1.TabIndex = 2;
        browse_button1.Text = "Browse";
        browse_button1.UseVisualStyleBackColor = false;
        browse_button1.Click += browse_button1_Click;
        // 
        // filename_textBox1
        // 
        filename_textBox1.Location = new Point(128, 211);
        filename_textBox1.Name = "filename_textBox1";
        filename_textBox1.ReadOnly = true;
        filename_textBox1.Size = new Size(545, 25);
        filename_textBox1.TabIndex = 3;
        // 
        // backup_button1
        // 
        backup_button1.BackColor = SystemColors.ButtonFace;
        backup_button1.Cursor = Cursors.Hand;
        backup_button1.Image = Properties.Resources.bk_database;
        backup_button1.Location = new Point(38, 270);
        backup_button1.Name = "backup_button1";
        backup_button1.Size = new Size(111, 40);
        backup_button1.TabIndex = 4;
        backup_button1.Text = "Backup";
        backup_button1.TextImageRelation = TextImageRelation.ImageBeforeText;
        backup_button1.UseVisualStyleBackColor = false;
        // 
        // exit_button2
        // 
        exit_button2.BackColor = SystemColors.ButtonFace;
        exit_button2.Cursor = Cursors.Hand;
        exit_button2.Image = Properties.Resources.bk_exit;
        exit_button2.Location = new Point(155, 270);
        exit_button2.Name = "exit_button2";
        exit_button2.Size = new Size(82, 40);
        exit_button2.TabIndex = 5;
        exit_button2.Text = "Exit";
        exit_button2.TextImageRelation = TextImageRelation.ImageBeforeText;
        exit_button2.UseVisualStyleBackColor = false;
        exit_button2.Click += exit_button2_Click;
        // 
        // help_button3
        // 
        help_button3.BackColor = SystemColors.ButtonFace;
        help_button3.Cursor = Cursors.Hand;
        help_button3.Image = Properties.Resources.bk_help;
        help_button3.Location = new Point(586, 270);
        help_button3.Name = "help_button3";
        help_button3.Size = new Size(87, 40);
        help_button3.TabIndex = 6;
        help_button3.Text = "Help";
        help_button3.TextImageRelation = TextImageRelation.ImageBeforeText;
        help_button3.UseVisualStyleBackColor = false;
        // 
        // panel3
        // 
        panel3.BorderStyle = BorderStyle.FixedSingle;
        panel3.Location = new Point(0, 253);
        panel3.Name = "panel3";
        panel3.Size = new Size(738, 1);
        panel3.TabIndex = 7;
        // 
        // BackupForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLight;
        ClientSize = new Size(722, 317);
        ControlBox = false;
        Controls.Add(panel3);
        Controls.Add(help_button3);
        Controls.Add(exit_button2);
        Controls.Add(backup_button1);
        Controls.Add(filename_textBox1);
        Controls.Add(browse_button1);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "BackupForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Backup Data";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Button browse_button1;
    private TextBox filename_textBox1;
    private Button backup_button1;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private Button exit_button2;
    private Button help_button3;
    private Label label6;
    private Panel panel3;
    private FolderBrowserDialog folderBrowserDialog1;
}