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
        min_button = new Button();
        close_button = new Button();
        Side_Panel = new Panel();
        Bottom_Panel = new Panel();
        Top_Panel.SuspendLayout();
        SuspendLayout();
        // 
        // Top_Panel
        // 
        Top_Panel.Controls.Add(min_button);
        Top_Panel.Controls.Add(close_button);
        Top_Panel.Dock = DockStyle.Top;
        Top_Panel.Location = new Point(233, 0);
        Top_Panel.MinimumSize = new Size(791, 75);
        Top_Panel.Name = "Top_Panel";
        Top_Panel.Size = new Size(929, 80);
        Top_Panel.TabIndex = 1;
        Top_Panel.Paint += panel1_Paint;
        // 
        // min_button
        // 
        min_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        min_button.Location = new Point(860, 3);
        min_button.Name = "min_button";
        min_button.Size = new Size(30, 30);
        min_button.TabIndex = 1;
        min_button.UseVisualStyleBackColor = true;
        // 
        // close_button
        // 
        close_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        close_button.Location = new Point(896, 3);
        close_button.Name = "close_button";
        close_button.Size = new Size(30, 30);
        close_button.TabIndex = 0;
        close_button.UseVisualStyleBackColor = true;
        // 
        // Side_Panel
        // 
        Side_Panel.BackColor = Color.Gainsboro;
        Side_Panel.Dock = DockStyle.Left;
        Side_Panel.Location = new Point(0, 0);
        Side_Panel.MinimumSize = new Size(180, 728);
        Side_Panel.Name = "Side_Panel";
        Side_Panel.Size = new Size(233, 768);
        Side_Panel.TabIndex = 0;
        // 
        // Bottom_Panel
        // 
        Bottom_Panel.Dock = DockStyle.Bottom;
        Bottom_Panel.Location = new Point(233, 718);
        Bottom_Panel.MinimumSize = new Size(844, 40);
        Bottom_Panel.Name = "Bottom_Panel";
        Bottom_Panel.Size = new Size(929, 50);
        Bottom_Panel.TabIndex = 0;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1162, 768);
        Controls.Add(Bottom_Panel);
        Controls.Add(Top_Panel);
        Controls.Add(Side_Panel);
        FormBorderStyle = FormBorderStyle.None;
        IsMdiContainer = true;
        MinimizeBox = false;
        MinimumSize = new Size(1024, 768);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Main Form";
        WindowState = FormWindowState.Maximized;
        Top_Panel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel Top_Panel;
    private Panel Side_Panel;
    private Panel Bottom_Panel;
    private Button close_button;
    private Button min_button;
}