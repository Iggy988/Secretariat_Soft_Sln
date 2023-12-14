namespace Secretariat_Soft.S_Forms;

partial class In_Letters_Form
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
        Bottom_ToolStrip = new ToolStrip();
        dataGridView1 = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // Top_Toolstrip
        // 
        Top_Toolstrip.AutoSize = false;
        Top_Toolstrip.Location = new Point(0, 0);
        Top_Toolstrip.Name = "Top_Toolstrip";
        Top_Toolstrip.Size = new Size(1076, 70);
        Top_Toolstrip.TabIndex = 0;
        Top_Toolstrip.Text = "toolStrip1";
        // 
        // Bottom_ToolStrip
        // 
        Bottom_ToolStrip.AutoSize = false;
        Bottom_ToolStrip.Dock = DockStyle.Bottom;
        Bottom_ToolStrip.Location = new Point(0, 550);
        Bottom_ToolStrip.Name = "Bottom_ToolStrip";
        Bottom_ToolStrip.Size = new Size(1076, 77);
        Bottom_ToolStrip.TabIndex = 1;
        Bottom_ToolStrip.Text = "toolStrip2";
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(12, 73);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowTemplate.Height = 25;
        dataGridView1.Size = new Size(1052, 461);
        dataGridView1.TabIndex = 2;
        // 
        // In_Letters_Form
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(1076, 627);
        Controls.Add(dataGridView1);
        Controls.Add(Bottom_ToolStrip);
        Controls.Add(Top_Toolstrip);
        Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "In_Letters_Form";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Incoming Letters List";
        Load += In_Letters_Form_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private ToolStrip Top_Toolstrip;
    private ToolStrip Bottom_ToolStrip;
    private DataGridView dataGridView1;
}