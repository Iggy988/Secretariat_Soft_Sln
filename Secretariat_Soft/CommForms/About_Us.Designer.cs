namespace Secretariat_Soft.CommForms;

partial class About_Us
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About_Us));
        company_name_label1 = new Label();
        product_name_label = new Label();
        version_label1 = new Label();
        copy_right_version = new Label();
        panel1 = new Panel();
        SuspendLayout();
        // 
        // company_name_label1
        // 
        company_name_label1.BackColor = Color.Transparent;
        company_name_label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        company_name_label1.Location = new Point(12, 9);
        company_name_label1.Name = "company_name_label1";
        company_name_label1.Size = new Size(439, 59);
        company_name_label1.TabIndex = 0;
        company_name_label1.Text = "Company Name";
        company_name_label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // product_name_label
        // 
        product_name_label.BackColor = Color.Transparent;
        product_name_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        product_name_label.Location = new Point(12, 68);
        product_name_label.Name = "product_name_label";
        product_name_label.Size = new Size(439, 59);
        product_name_label.TabIndex = 1;
        product_name_label.Text = "Product Name";
        product_name_label.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // version_label1
        // 
        version_label1.BackColor = Color.Transparent;
        version_label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        version_label1.ForeColor = Color.DarkRed;
        version_label1.Location = new Point(12, 127);
        version_label1.Name = "version_label1";
        version_label1.Size = new Size(439, 59);
        version_label1.TabIndex = 2;
        version_label1.Text = "Version";
        version_label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // copy_right_version
        // 
        copy_right_version.BackColor = Color.Transparent;
        copy_right_version.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        copy_right_version.Location = new Point(12, 351);
        copy_right_version.Name = "copy_right_version";
        copy_right_version.Size = new Size(439, 46);
        copy_right_version.TabIndex = 3;
        copy_right_version.Text = "Copy Right";
        copy_right_version.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panel1
        // 
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Location = new Point(3, 339);
        panel1.Name = "panel1";
        panel1.Size = new Size(458, 1);
        panel1.TabIndex = 4;
        // 
        // About_Us
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Menu;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(465, 419);
        Controls.Add(panel1);
        Controls.Add(copy_right_version);
        Controls.Add(version_label1);
        Controls.Add(product_name_label);
        Controls.Add(company_name_label1);
        Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "About_Us";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "About Us";
        Load += About_Us_Load;
        ResumeLayout(false);
    }

    #endregion

    private Label company_name_label1;
    private Label product_name_label;
    private Label version_label1;
    private Label copy_right_version;
    private Panel panel1;
}