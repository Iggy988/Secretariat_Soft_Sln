namespace Secretariat_Soft;

partial class MainForm
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
        Top_Panel = new Panel();
        Side_Panel = new Panel();
        Bottom_Panel = new Panel();
        SuspendLayout();
        // 
        // Top_Panel
        // 
        Top_Panel.Dock = DockStyle.Top;
        Top_Panel.Location = new Point(206, 0);
        Top_Panel.Name = "Top_Panel";
        Top_Panel.Size = new Size(754, 72);
        Top_Panel.TabIndex = 1;
        Top_Panel.Paint += panel1_Paint;
        // 
        // Side_Panel
        // 
        Side_Panel.BackColor = Color.Gainsboro;
        Side_Panel.Dock = DockStyle.Left;
        Side_Panel.Location = new Point(0, 0);
        Side_Panel.Name = "Side_Panel";
        Side_Panel.Size = new Size(206, 604);
        Side_Panel.TabIndex = 0;
        // 
        // Bottom_Panel
        // 
        Bottom_Panel.Dock = DockStyle.Bottom;
        Bottom_Panel.Location = new Point(206, 554);
        Bottom_Panel.Name = "Bottom_Panel";
        Bottom_Panel.Size = new Size(754, 50);
        Bottom_Panel.TabIndex = 0;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(960, 604);
        Controls.Add(Bottom_Panel);
        Controls.Add(Top_Panel);
        Controls.Add(Side_Panel);
        FormBorderStyle = FormBorderStyle.None;
        IsMdiContainer = true;
        MinimizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Main Form";
        WindowState = FormWindowState.Maximized;
        ResumeLayout(false);
    }

    #endregion

    private Panel Top_Panel;
    private Panel Side_Panel;
    private Panel Bottom_Panel;
}