namespace Secretariat_Soft.S_Forms;

partial class In_Letters_De
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
        panel1 = new Panel();
        main_gbox = new GroupBox();
        letters1 = new DataSet.Letters();
        Top_Toolstrip.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)letters1).BeginInit();
        SuspendLayout();
        // 
        // Top_Toolstrip
        // 
        Top_Toolstrip.AutoSize = false;
        Top_Toolstrip.Items.AddRange(new ToolStripItem[] { de_add_butt, toolStripSeparator4, de_edit_butt, toolStripSeparator1, de_delete_butt, toolStripSeparator2, de_save_butt, toolStripSeparator5, toolStripSeparator3, de_print_butt, toolStripSeparator6, de_cancel_butt, toolStripSeparator7 });
        Top_Toolstrip.Location = new Point(0, 0);
        Top_Toolstrip.Name = "Top_Toolstrip";
        Top_Toolstrip.Size = new Size(995, 70);
        Top_Toolstrip.TabIndex = 1;
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
        // panel1
        // 
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 624);
        panel1.Name = "panel1";
        panel1.Size = new Size(995, 50);
        panel1.TabIndex = 2;
        // 
        // main_gbox
        // 
        main_gbox.Location = new Point(8, 73);
        main_gbox.Name = "main_gbox";
        main_gbox.Size = new Size(979, 545);
        main_gbox.TabIndex = 3;
        main_gbox.TabStop = false;
        main_gbox.Text = "Info";
        // 
        // letters1
        // 
        letters1.DataSetName = "Letters";
        letters1.Namespace = "http://tempuri.org/Letters.xsd";
        letters1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        // 
        // In_Letters_De
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(995, 674);
        Controls.Add(main_gbox);
        Controls.Add(panel1);
        Controls.Add(Top_Toolstrip);
        Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "In_Letters_De";
        ShowIcon = false;
        Text = "Data Entry: Incoming Letters";
        Load += In_Letters_De_Load;
        Top_Toolstrip.ResumeLayout(false);
        Top_Toolstrip.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)letters1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private ToolStrip Top_Toolstrip;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripSeparator toolStripSeparator4;
    private Panel panel1;
    private GroupBox main_gbox;
    public ToolStripButton de_add_butt;
    public ToolStripButton de_edit_butt;
    private ToolStripSeparator toolStripSeparator1;
    public ToolStripButton de_delete_butt;
    private ToolStripSeparator toolStripSeparator2;
    public ToolStripButton de_save_butt;
    private ToolStripSeparator toolStripSeparator5;
    public ToolStripButton de_cancel_butt;
    private DataSet.Letters letters1;
    public ToolStripButton de_print_butt;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripSeparator toolStripSeparator7;
}