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
        help_button = new Button();
        tools_button = new Button();
        report_button = new Button();
        data_entry_button = new Button();
        min_button = new Button();
        close_button = new Button();
        Side_Panel = new Panel();
        panel1 = new Panel();
        day_in_week_lbl = new Label();
        day_month_lbl = new Label();
        month_name_lbl = new Label();
        year_num_lbl = new Label();
        Bottom_Panel = new Panel();
        calculator_button = new Button();
        background_button = new Button();
        analogClock1 = new AnalogClock.AnalogClock();
        Top_Panel.SuspendLayout();
        Side_Panel.SuspendLayout();
        panel1.SuspendLayout();
        Bottom_Panel.SuspendLayout();
        SuspendLayout();
        // 
        // Top_Panel
        // 
        Top_Panel.Controls.Add(help_button);
        Top_Panel.Controls.Add(tools_button);
        Top_Panel.Controls.Add(report_button);
        Top_Panel.Controls.Add(data_entry_button);
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
        // help_button
        // 
        help_button.Cursor = Cursors.Hand;
        help_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        help_button.Image = Properties.Resources.top_help_button;
        help_button.ImageAlign = ContentAlignment.TopCenter;
        help_button.Location = new Point(448, 3);
        help_button.Name = "help_button";
        help_button.Size = new Size(144, 74);
        help_button.TabIndex = 5;
        help_button.Text = "Help F5";
        help_button.TextAlign = ContentAlignment.BottomCenter;
        help_button.TextImageRelation = TextImageRelation.ImageAboveText;
        help_button.UseVisualStyleBackColor = true;
        // 
        // tools_button
        // 
        tools_button.Cursor = Cursors.Hand;
        tools_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        tools_button.Image = Properties.Resources.top_tools_button;
        tools_button.ImageAlign = ContentAlignment.TopCenter;
        tools_button.Location = new Point(301, 3);
        tools_button.Name = "tools_button";
        tools_button.Size = new Size(144, 74);
        tools_button.TabIndex = 4;
        tools_button.Text = "Tools F4";
        tools_button.TextAlign = ContentAlignment.BottomCenter;
        tools_button.TextImageRelation = TextImageRelation.ImageAboveText;
        tools_button.UseVisualStyleBackColor = true;
        // 
        // report_button
        // 
        report_button.Cursor = Cursors.Hand;
        report_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        report_button.Image = Properties.Resources.top_report_button;
        report_button.ImageAlign = ContentAlignment.TopCenter;
        report_button.Location = new Point(154, 3);
        report_button.Name = "report_button";
        report_button.Size = new Size(144, 74);
        report_button.TabIndex = 3;
        report_button.Text = "Reports F3";
        report_button.TextAlign = ContentAlignment.BottomCenter;
        report_button.TextImageRelation = TextImageRelation.ImageAboveText;
        report_button.UseVisualStyleBackColor = true;
        // 
        // data_entry_button
        // 
        data_entry_button.Cursor = Cursors.Hand;
        data_entry_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        data_entry_button.Image = Properties.Resources.top_input_button;
        data_entry_button.ImageAlign = ContentAlignment.TopCenter;
        data_entry_button.Location = new Point(6, 3);
        data_entry_button.Name = "data_entry_button";
        data_entry_button.Size = new Size(144, 74);
        data_entry_button.TabIndex = 2;
        data_entry_button.Text = "Data Entry F2";
        data_entry_button.TextAlign = ContentAlignment.BottomCenter;
        data_entry_button.TextImageRelation = TextImageRelation.ImageAboveText;
        data_entry_button.UseVisualStyleBackColor = true;
        // 
        // min_button
        // 
        min_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        min_button.BackgroundImage = Properties.Resources.min_button;
        min_button.BackgroundImageLayout = ImageLayout.Center;
        min_button.Cursor = Cursors.Hand;
        min_button.Location = new Point(860, 3);
        min_button.Name = "min_button";
        min_button.Size = new Size(30, 30);
        min_button.TabIndex = 1;
        min_button.UseVisualStyleBackColor = true;
        min_button.Click += min_button_Click;
        // 
        // close_button
        // 
        close_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        close_button.BackgroundImage = Properties.Resources.close_button;
        close_button.BackgroundImageLayout = ImageLayout.Center;
        close_button.Cursor = Cursors.Hand;
        close_button.Location = new Point(896, 3);
        close_button.Name = "close_button";
        close_button.Size = new Size(30, 30);
        close_button.TabIndex = 0;
        close_button.UseVisualStyleBackColor = true;
        close_button.Click += close_button_Click;
        // 
        // Side_Panel
        // 
        Side_Panel.BackColor = Color.Gainsboro;
        Side_Panel.Controls.Add(analogClock1);
        Side_Panel.Controls.Add(panel1);
        Side_Panel.Dock = DockStyle.Left;
        Side_Panel.Location = new Point(0, 0);
        Side_Panel.MinimumSize = new Size(180, 728);
        Side_Panel.Name = "Side_Panel";
        Side_Panel.Size = new Size(233, 768);
        Side_Panel.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.BackgroundImage = Properties.Resources.calendar;
        panel1.BackgroundImageLayout = ImageLayout.Zoom;
        panel1.Controls.Add(day_in_week_lbl);
        panel1.Controls.Add(day_month_lbl);
        panel1.Controls.Add(month_name_lbl);
        panel1.Controls.Add(year_num_lbl);
        panel1.Location = new Point(3, 254);
        panel1.Name = "panel1";
        panel1.Size = new Size(230, 193);
        panel1.TabIndex = 0;
        // 
        // day_in_week_lbl
        // 
        day_in_week_lbl.BackColor = Color.Transparent;
        day_in_week_lbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        day_in_week_lbl.ForeColor = Color.Black;
        day_in_week_lbl.Location = new Point(23, 131);
        day_in_week_lbl.Name = "day_in_week_lbl";
        day_in_week_lbl.Size = new Size(184, 45);
        day_in_week_lbl.TabIndex = 3;
        day_in_week_lbl.Text = "Sunday";
        day_in_week_lbl.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // day_month_lbl
        // 
        day_month_lbl.BackColor = Color.Transparent;
        day_month_lbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
        day_month_lbl.ForeColor = Color.Black;
        day_month_lbl.Location = new Point(23, 86);
        day_month_lbl.Name = "day_month_lbl";
        day_month_lbl.Size = new Size(184, 45);
        day_month_lbl.TabIndex = 2;
        day_month_lbl.Text = "21";
        day_month_lbl.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // month_name_lbl
        // 
        month_name_lbl.AutoSize = true;
        month_name_lbl.BackColor = Color.Transparent;
        month_name_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        month_name_lbl.ForeColor = Color.White;
        month_name_lbl.Location = new Point(107, 23);
        month_name_lbl.Name = "month_name_lbl";
        month_name_lbl.Size = new Size(47, 21);
        month_name_lbl.TabIndex = 1;
        month_name_lbl.Text = "April";
        // 
        // year_num_lbl
        // 
        year_num_lbl.AutoSize = true;
        year_num_lbl.BackColor = Color.Transparent;
        year_num_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        year_num_lbl.ForeColor = Color.White;
        year_num_lbl.Location = new Point(40, 23);
        year_num_lbl.Name = "year_num_lbl";
        year_num_lbl.Size = new Size(46, 21);
        year_num_lbl.TabIndex = 0;
        year_num_lbl.Text = "2023";
        // 
        // Bottom_Panel
        // 
        Bottom_Panel.Controls.Add(calculator_button);
        Bottom_Panel.Controls.Add(background_button);
        Bottom_Panel.Dock = DockStyle.Bottom;
        Bottom_Panel.Location = new Point(233, 718);
        Bottom_Panel.MinimumSize = new Size(844, 40);
        Bottom_Panel.Name = "Bottom_Panel";
        Bottom_Panel.Size = new Size(929, 50);
        Bottom_Panel.TabIndex = 0;
        // 
        // calculator_button
        // 
        calculator_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        calculator_button.BackgroundImage = Properties.Resources.calculator;
        calculator_button.BackgroundImageLayout = ImageLayout.Zoom;
        calculator_button.Cursor = Cursors.Hand;
        calculator_button.Location = new Point(711, 4);
        calculator_button.Name = "calculator_button";
        calculator_button.Size = new Size(60, 44);
        calculator_button.TabIndex = 1;
        calculator_button.UseVisualStyleBackColor = true;
        // 
        // background_button
        // 
        background_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        background_button.Cursor = Cursors.Hand;
        background_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        background_button.Image = Properties.Resources.background;
        background_button.Location = new Point(777, 4);
        background_button.Name = "background_button";
        background_button.Size = new Size(140, 44);
        background_button.TabIndex = 0;
        background_button.Text = "Background";
        background_button.UseVisualStyleBackColor = true;
        // 
        // analogClock1
        // 
        analogClock1.DrawHourHand = true;
        analogClock1.DrawHourHandShadow = true;
        analogClock1.DrawMinuteHand = true;
        analogClock1.DrawMinuteHandShadow = true;
        analogClock1.DrawSecondHand = true;
        analogClock1.DropShadowColor = Color.Black;
        analogClock1.DropShadowOffset = new Point(0, 0);
        analogClock1.FaceColorHigh = Color.RoyalBlue;
        analogClock1.FaceColorLow = Color.SkyBlue;
        analogClock1.FaceGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
        analogClock1.FaceImage = null;
        analogClock1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        analogClock1.HourHandColor = Color.Gainsboro;
        analogClock1.HourHandDropShadowColor = Color.Gray;
        analogClock1.Location = new Point(9, 12);
        analogClock1.MinuteHandColor = Color.WhiteSmoke;
        analogClock1.MinuteHandDropShadowColor = Color.Gray;
        analogClock1.MinuteHandTickStyle = AnalogClock.TickStyle.Normal;
        analogClock1.Name = "analogClock1";
        analogClock1.NumeralColor = Color.WhiteSmoke;
        analogClock1.RimColorHigh = Color.RoyalBlue;
        analogClock1.RimColorLow = Color.SkyBlue;
        analogClock1.RimGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
        analogClock1.SecondHandColor = Color.Tomato;
        analogClock1.SecondHandDropShadowColor = Color.Gray;
        analogClock1.SecondHandEndCap = System.Drawing.Drawing2D.LineCap.Round;
        analogClock1.SecondHandTickStyle = AnalogClock.TickStyle.Normal;
        analogClock1.Size = new Size(218, 218);
        analogClock1.TabIndex = 1;
        analogClock1.Time = new DateTime(0L);
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
        Load += MainForm_Load;
        Top_Panel.ResumeLayout(false);
        Side_Panel.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        Bottom_Panel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel Top_Panel;
    private Panel Side_Panel;
    private Panel Bottom_Panel;
    private Button close_button;
    private Button min_button;
    private Button data_entry_button;
    private Button help_button;
    private Button tools_button;
    private Button report_button;
    private Button background_button;
    private Button calculator_button;
    private Panel panel1;
    private Label year_num_lbl;
    private Label day_month_lbl;
    private Label month_name_lbl;
    private Label day_in_week_lbl;
    private AnalogClock.AnalogClock analogClock1;
}