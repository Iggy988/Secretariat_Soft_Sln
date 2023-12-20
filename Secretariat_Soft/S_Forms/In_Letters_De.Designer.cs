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
        add_butt = new ToolStripButton();
        toolStripSeparator3 = new ToolStripSeparator();
        toolStripSeparator4 = new ToolStripSeparator();
        panel1 = new Panel();
        main_gbox = new GroupBox();
        Top_Toolstrip.SuspendLayout();
        SuspendLayout();
        // 
        // Top_Toolstrip
        // 
        Top_Toolstrip.AutoSize = false;
        Top_Toolstrip.Items.AddRange(new ToolStripItem[] { add_butt, toolStripSeparator3, toolStripSeparator4 });
        Top_Toolstrip.Location = new Point(0, 0);
        Top_Toolstrip.Name = "Top_Toolstrip";
        Top_Toolstrip.Size = new Size(995, 70);
        Top_Toolstrip.TabIndex = 1;
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
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Alignment = ToolStripItemAlignment.Right;
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new Size(6, 70);
        // 
        // toolStripSeparator4
        // 
        toolStripSeparator4.Name = "toolStripSeparator4";
        toolStripSeparator4.Size = new Size(6, 70);
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
        ResumeLayout(false);
    }

    #endregion

    private ToolStrip Top_Toolstrip;
    private ToolStripButton add_butt;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripSeparator toolStripSeparator4;
    private Panel panel1;
    private GroupBox main_gbox;
}