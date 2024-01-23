namespace Secretariat_Soft.CommForms;

partial class RestoreForm
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
        groupBox1 = new GroupBox();
        prog_panel4 = new Panel();
        label7 = new Label();
        label5 = new Label();
        restore_textBox1 = new TextBox();
        browse_button1 = new Button();
        help_button3 = new Button();
        exit_button2 = new Button();
        restore_button1 = new Button();
        panel1 = new Panel();
        label3 = new Label();
        label2 = new Label();
        groupBox1.SuspendLayout();
        prog_panel4.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(prog_panel4);
        groupBox1.Controls.Add(restore_textBox1);
        groupBox1.Controls.Add(browse_button1);
        groupBox1.Controls.Add(help_button3);
        groupBox1.Controls.Add(exit_button2);
        groupBox1.Controls.Add(restore_button1);
        groupBox1.Controls.Add(panel1);
        groupBox1.Location = new Point(-3, -17);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(667, 239);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        // 
        // prog_panel4
        // 
        prog_panel4.BackColor = Color.PapayaWhip;
        prog_panel4.BorderStyle = BorderStyle.FixedSingle;
        prog_panel4.Controls.Add(label7);
        prog_panel4.Controls.Add(label5);
        prog_panel4.Location = new Point(204, 42);
        prog_panel4.Name = "prog_panel4";
        prog_panel4.Size = new Size(218, 127);
        prog_panel4.TabIndex = 12;
        prog_panel4.Visible = false;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label7.Location = new Point(29, 73);
        label7.Name = "label7";
        label7.Size = new Size(161, 21);
        label7.TabIndex = 2;
        label7.Text = "Restoring the  data...";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label5.Location = new Point(49, 24);
        label5.Name = "label5";
        label5.Size = new Size(110, 21);
        label5.TabIndex = 1;
        label5.Text = "Please Wait...";
        // 
        // restore_textBox1
        // 
        restore_textBox1.Location = new Point(120, 112);
        restore_textBox1.Name = "restore_textBox1";
        restore_textBox1.ReadOnly = true;
        restore_textBox1.Size = new Size(516, 25);
        restore_textBox1.TabIndex = 11;
        // 
        // browse_button1
        // 
        browse_button1.BackColor = SystemColors.ButtonFace;
        browse_button1.Cursor = Cursors.Hand;
        browse_button1.Location = new Point(30, 112);
        browse_button1.Name = "browse_button1";
        browse_button1.Size = new Size(84, 25);
        browse_button1.TabIndex = 10;
        browse_button1.Text = "Browse";
        browse_button1.UseVisualStyleBackColor = false;
        browse_button1.Click += browse_button1_Click;
        // 
        // help_button3
        // 
        help_button3.BackColor = SystemColors.ButtonFace;
        help_button3.Cursor = Cursors.Hand;
        help_button3.Image = Properties.Resources.bk_help;
        help_button3.Location = new Point(549, 167);
        help_button3.Name = "help_button3";
        help_button3.Size = new Size(87, 40);
        help_button3.TabIndex = 9;
        help_button3.Text = "Help";
        help_button3.TextImageRelation = TextImageRelation.ImageBeforeText;
        help_button3.UseVisualStyleBackColor = false;
        // 
        // exit_button2
        // 
        exit_button2.BackColor = SystemColors.ButtonFace;
        exit_button2.Cursor = Cursors.Hand;
        exit_button2.Image = Properties.Resources.bk_exit;
        exit_button2.Location = new Point(169, 167);
        exit_button2.Name = "exit_button2";
        exit_button2.Size = new Size(82, 40);
        exit_button2.TabIndex = 8;
        exit_button2.Text = "Exit";
        exit_button2.TextImageRelation = TextImageRelation.ImageBeforeText;
        exit_button2.UseVisualStyleBackColor = false;
        exit_button2.Click += exit_button2_Click;
        // 
        // restore_button1
        // 
        restore_button1.BackColor = SystemColors.ButtonFace;
        restore_button1.Cursor = Cursors.Hand;
        restore_button1.Image = Properties.Resources.bk_database;
        restore_button1.Location = new Point(30, 167);
        restore_button1.Name = "restore_button1";
        restore_button1.Size = new Size(133, 40);
        restore_button1.TabIndex = 7;
        restore_button1.Text = "Start Restore";
        restore_button1.TextImageRelation = TextImageRelation.ImageBeforeText;
        restore_button1.UseVisualStyleBackColor = false;
        restore_button1.Click += restore_button1_Click;
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(192, 255, 192);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Location = new Point(-4, 10);
        panel1.Name = "panel1";
        panel1.Size = new Size(682, 79);
        panel1.TabIndex = 1;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(16, 45);
        label3.Name = "label3";
        label3.Size = new Size(645, 17);
        label3.TabIndex = 2;
        label3.Text = "Tip 2: Don't put backup file in the Windows drive or My Documents or Desktop because it will cause an error.";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(16, 18);
        label2.Name = "label2";
        label2.Size = new Size(523, 17);
        label2.TabIndex = 1;
        label2.Text = "Tip 1: If you burned backup file on CD, be sure to copy it to hard drive and then restore.";
        // 
        // RestoreForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(658, 200);
        ControlBox = false;
        Controls.Add(groupBox1);
        Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "RestoreForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Restore Data";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        prog_panel4.ResumeLayout(false);
        prog_panel4.PerformLayout();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Panel panel1;
    private Label label3;
    private Label label2;
    private Button help_button3;
    private Button exit_button2;
    private Button restore_button1;
    private TextBox restore_textBox1;
    private Button browse_button1;
    private Panel prog_panel4;
    private Label label7;
    private Label label5;
}