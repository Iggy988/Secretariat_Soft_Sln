namespace Secretariat_Soft.CommForms;

partial class UserList
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
        components = new System.ComponentModel.Container();
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        Top_Toolstrip = new ToolStrip();
        add_butt = new ToolStripButton();
        toolStripSeparator3 = new ToolStripSeparator();
        toolStripSeparator4 = new ToolStripSeparator();
        dataGridView1 = new DataGridView();
        idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        commentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        photoDataGridViewImageColumn = new DataGridViewImageColumn();
        sysUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        sysUserIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        sysDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        sysTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        appusers_bindingSource1 = new BindingSource(components);
        letters1 = new DataSet.Letters();
        appUsersTableAdapter1 = new DataSet.LettersTableAdapters.AppUsersTableAdapter();
        Top_Toolstrip.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)appusers_bindingSource1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)letters1).BeginInit();
        SuspendLayout();
        // 
        // Top_Toolstrip
        // 
        Top_Toolstrip.AutoSize = false;
        Top_Toolstrip.Items.AddRange(new ToolStripItem[] { add_butt, toolStripSeparator3, toolStripSeparator4 });
        Top_Toolstrip.Location = new Point(0, 0);
        Top_Toolstrip.Name = "Top_Toolstrip";
        Top_Toolstrip.Size = new Size(784, 70);
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
        add_butt.Size = new Size(127, 67);
        add_butt.Text = "Add | Edit Users F2";
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
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dataGridView1.AutoGenerateColumns = false;
        dataGridView1.BackgroundColor = SystemColors.ControlLight;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn, photoDataGridViewImageColumn, sysUserDataGridViewTextBoxColumn, sysUserIdDataGridViewTextBoxColumn, sysDateDataGridViewTextBoxColumn, sysTimeDataGridViewTextBoxColumn });
        dataGridView1.DataSource = appusers_bindingSource1;
        dataGridView1.Location = new Point(12, 79);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.RowHeadersWidth = 20;
        dataGridView1.RowTemplate.Height = 25;
        dataGridView1.Size = new Size(760, 474);
        dataGridView1.TabIndex = 2;
        // 
        // idDataGridViewTextBoxColumn
        // 
        idDataGridViewTextBoxColumn.DataPropertyName = "id";
        idDataGridViewTextBoxColumn.HeaderText = "ID";
        idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
        idDataGridViewTextBoxColumn.ReadOnly = true;
        idDataGridViewTextBoxColumn.Width = 70;
        // 
        // userNameDataGridViewTextBoxColumn
        // 
        userNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name";
        userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
        userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
        userNameDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // commentDataGridViewTextBoxColumn
        // 
        commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
        commentDataGridViewTextBoxColumn.HeaderText = "Comment";
        commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
        commentDataGridViewTextBoxColumn.ReadOnly = true;
        commentDataGridViewTextBoxColumn.Width = 200;
        // 
        // photoDataGridViewImageColumn
        // 
        photoDataGridViewImageColumn.DataPropertyName = "Photo";
        photoDataGridViewImageColumn.HeaderText = "Photo";
        photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
        photoDataGridViewImageColumn.ReadOnly = true;
        // 
        // sysUserDataGridViewTextBoxColumn
        // 
        sysUserDataGridViewTextBoxColumn.DataPropertyName = "Sys_User";
        sysUserDataGridViewTextBoxColumn.HeaderText = "Sys User";
        sysUserDataGridViewTextBoxColumn.Name = "sysUserDataGridViewTextBoxColumn";
        sysUserDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // sysUserIdDataGridViewTextBoxColumn
        // 
        sysUserIdDataGridViewTextBoxColumn.DataPropertyName = "Sys_UserId";
        sysUserIdDataGridViewTextBoxColumn.HeaderText = "Sys User Id";
        sysUserIdDataGridViewTextBoxColumn.Name = "sysUserIdDataGridViewTextBoxColumn";
        sysUserIdDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // sysDateDataGridViewTextBoxColumn
        // 
        sysDateDataGridViewTextBoxColumn.DataPropertyName = "SysDate";
        sysDateDataGridViewTextBoxColumn.HeaderText = "Sys Date";
        sysDateDataGridViewTextBoxColumn.Name = "sysDateDataGridViewTextBoxColumn";
        sysDateDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // sysTimeDataGridViewTextBoxColumn
        // 
        sysTimeDataGridViewTextBoxColumn.DataPropertyName = "SysTime";
        sysTimeDataGridViewTextBoxColumn.HeaderText = "Sys Time";
        sysTimeDataGridViewTextBoxColumn.Name = "sysTimeDataGridViewTextBoxColumn";
        sysTimeDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // appusers_bindingSource1
        // 
        appusers_bindingSource1.DataMember = "AppUsers";
        appusers_bindingSource1.DataSource = letters1;
        // 
        // letters1
        // 
        letters1.DataSetName = "Letters";
        letters1.Namespace = "http://tempuri.org/Letters.xsd";
        letters1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        // 
        // appUsersTableAdapter1
        // 
        appUsersTableAdapter1.ClearBeforeFill = true;
        // 
        // UserList
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Info;
        ClientSize = new Size(784, 565);
        Controls.Add(dataGridView1);
        Controls.Add(Top_Toolstrip);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "UserList";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "User List";
        Load += UserList_Load;
        Top_Toolstrip.ResumeLayout(false);
        Top_Toolstrip.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)appusers_bindingSource1).EndInit();
        ((System.ComponentModel.ISupportInitialize)letters1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private ToolStrip Top_Toolstrip;
    private ToolStripButton add_butt;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripSeparator toolStripSeparator4;
    private DataGridView dataGridView1;
    private BindingSource appusers_bindingSource1;
    private DataSet.Letters letters1;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    private DataGridViewImageColumn photoDataGridViewImageColumn;
    private DataGridViewTextBoxColumn sysUserDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn sysUserIdDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn sysDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn sysTimeDataGridViewTextBoxColumn;
    private DataSet.LettersTableAdapters.AppUsersTableAdapter appUsersTableAdapter1;
}