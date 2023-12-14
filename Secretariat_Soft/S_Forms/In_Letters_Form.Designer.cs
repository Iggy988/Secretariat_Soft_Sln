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
        components = new System.ComponentModel.Container();
        Top_Toolstrip = new ToolStrip();
        Bottom_ToolStrip = new ToolStrip();
        dataGridView1 = new DataGridView();
        iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        subjectDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        regDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        letterNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        letterTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        recivedDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        letterTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        senderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        recipientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        reciveMethodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        groupNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        priorityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        pageCountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        deadlineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        refDocDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        docSummaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        sysDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        sysTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        in_letters_bindingSource1 = new BindingSource(components);
        letters1 = new DataSet.Letters();
        sa_In_LettersTableAdapter1 = new DataSet.LettersTableAdapters.Sa_In_LettersTableAdapter();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)in_letters_bindingSource1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)letters1).BeginInit();
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
        dataGridView1.AutoGenerateColumns = false;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, subjectDataGridViewTextBoxColumn, regDateDataGridViewTextBoxColumn, letterNumberDataGridViewTextBoxColumn, letterTimeDataGridViewTextBoxColumn, recivedDateDataGridViewTextBoxColumn, letterTypeDataGridViewTextBoxColumn, senderDataGridViewTextBoxColumn, recipientDataGridViewTextBoxColumn, reciveMethodDataGridViewTextBoxColumn, groupNameDataGridViewTextBoxColumn, priorityDataGridViewTextBoxColumn, pageCountDataGridViewTextBoxColumn, deadlineDataGridViewTextBoxColumn, refDocDataGridViewTextBoxColumn, docSummaryDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, userIdDataGridViewTextBoxColumn, sysDateDataGridViewTextBoxColumn, sysTimeDataGridViewTextBoxColumn });
        dataGridView1.DataSource = in_letters_bindingSource1;
        dataGridView1.Location = new Point(12, 73);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowTemplate.Height = 25;
        dataGridView1.Size = new Size(1052, 461);
        dataGridView1.TabIndex = 2;
        // 
        // iDDataGridViewTextBoxColumn
        // 
        iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
        iDDataGridViewTextBoxColumn.HeaderText = "ID";
        iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
        iDDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // subjectDataGridViewTextBoxColumn
        // 
        subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
        subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
        subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
        // 
        // regDateDataGridViewTextBoxColumn
        // 
        regDateDataGridViewTextBoxColumn.DataPropertyName = "RegDate";
        regDateDataGridViewTextBoxColumn.HeaderText = "RegDate";
        regDateDataGridViewTextBoxColumn.Name = "regDateDataGridViewTextBoxColumn";
        // 
        // letterNumberDataGridViewTextBoxColumn
        // 
        letterNumberDataGridViewTextBoxColumn.DataPropertyName = "LetterNumber";
        letterNumberDataGridViewTextBoxColumn.HeaderText = "LetterNumber";
        letterNumberDataGridViewTextBoxColumn.Name = "letterNumberDataGridViewTextBoxColumn";
        // 
        // letterTimeDataGridViewTextBoxColumn
        // 
        letterTimeDataGridViewTextBoxColumn.DataPropertyName = "Letter_Time";
        letterTimeDataGridViewTextBoxColumn.HeaderText = "Letter_Time";
        letterTimeDataGridViewTextBoxColumn.Name = "letterTimeDataGridViewTextBoxColumn";
        // 
        // recivedDateDataGridViewTextBoxColumn
        // 
        recivedDateDataGridViewTextBoxColumn.DataPropertyName = "RecivedDate";
        recivedDateDataGridViewTextBoxColumn.HeaderText = "RecivedDate";
        recivedDateDataGridViewTextBoxColumn.Name = "recivedDateDataGridViewTextBoxColumn";
        // 
        // letterTypeDataGridViewTextBoxColumn
        // 
        letterTypeDataGridViewTextBoxColumn.DataPropertyName = "LetterType";
        letterTypeDataGridViewTextBoxColumn.HeaderText = "LetterType";
        letterTypeDataGridViewTextBoxColumn.Name = "letterTypeDataGridViewTextBoxColumn";
        // 
        // senderDataGridViewTextBoxColumn
        // 
        senderDataGridViewTextBoxColumn.DataPropertyName = "Sender";
        senderDataGridViewTextBoxColumn.HeaderText = "Sender";
        senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
        // 
        // recipientDataGridViewTextBoxColumn
        // 
        recipientDataGridViewTextBoxColumn.DataPropertyName = "Recipient";
        recipientDataGridViewTextBoxColumn.HeaderText = "Recipient";
        recipientDataGridViewTextBoxColumn.Name = "recipientDataGridViewTextBoxColumn";
        // 
        // reciveMethodDataGridViewTextBoxColumn
        // 
        reciveMethodDataGridViewTextBoxColumn.DataPropertyName = "Recive_Method";
        reciveMethodDataGridViewTextBoxColumn.HeaderText = "Recive_Method";
        reciveMethodDataGridViewTextBoxColumn.Name = "reciveMethodDataGridViewTextBoxColumn";
        // 
        // groupNameDataGridViewTextBoxColumn
        // 
        groupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName";
        groupNameDataGridViewTextBoxColumn.HeaderText = "GroupName";
        groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
        // 
        // priorityDataGridViewTextBoxColumn
        // 
        priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
        priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
        priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
        // 
        // pageCountDataGridViewTextBoxColumn
        // 
        pageCountDataGridViewTextBoxColumn.DataPropertyName = "PageCount";
        pageCountDataGridViewTextBoxColumn.HeaderText = "PageCount";
        pageCountDataGridViewTextBoxColumn.Name = "pageCountDataGridViewTextBoxColumn";
        // 
        // deadlineDataGridViewTextBoxColumn
        // 
        deadlineDataGridViewTextBoxColumn.DataPropertyName = "Deadline";
        deadlineDataGridViewTextBoxColumn.HeaderText = "Deadline";
        deadlineDataGridViewTextBoxColumn.Name = "deadlineDataGridViewTextBoxColumn";
        // 
        // refDocDataGridViewTextBoxColumn
        // 
        refDocDataGridViewTextBoxColumn.DataPropertyName = "Ref_Doc";
        refDocDataGridViewTextBoxColumn.HeaderText = "Ref_Doc";
        refDocDataGridViewTextBoxColumn.Name = "refDocDataGridViewTextBoxColumn";
        // 
        // docSummaryDataGridViewTextBoxColumn
        // 
        docSummaryDataGridViewTextBoxColumn.DataPropertyName = "DocSummary";
        docSummaryDataGridViewTextBoxColumn.HeaderText = "DocSummary";
        docSummaryDataGridViewTextBoxColumn.Name = "docSummaryDataGridViewTextBoxColumn";
        // 
        // userNameDataGridViewTextBoxColumn
        // 
        userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
        userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
        userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
        // 
        // userIdDataGridViewTextBoxColumn
        // 
        userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
        userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
        userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
        // 
        // sysDateDataGridViewTextBoxColumn
        // 
        sysDateDataGridViewTextBoxColumn.DataPropertyName = "SysDate";
        sysDateDataGridViewTextBoxColumn.HeaderText = "SysDate";
        sysDateDataGridViewTextBoxColumn.Name = "sysDateDataGridViewTextBoxColumn";
        // 
        // sysTimeDataGridViewTextBoxColumn
        // 
        sysTimeDataGridViewTextBoxColumn.DataPropertyName = "SysTime";
        sysTimeDataGridViewTextBoxColumn.HeaderText = "SysTime";
        sysTimeDataGridViewTextBoxColumn.Name = "sysTimeDataGridViewTextBoxColumn";
        // 
        // in_letters_bindingSource1
        // 
        in_letters_bindingSource1.DataMember = "Sa_In_Letters";
        in_letters_bindingSource1.DataSource = letters1;
        // 
        // letters1
        // 
        letters1.DataSetName = "Letters";
        letters1.Namespace = "http://tempuri.org/Letters.xsd";
        letters1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        // 
        // sa_In_LettersTableAdapter1
        // 
        sa_In_LettersTableAdapter1.ClearBeforeFill = true;
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
        ((System.ComponentModel.ISupportInitialize)in_letters_bindingSource1).EndInit();
        ((System.ComponentModel.ISupportInitialize)letters1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private ToolStrip Top_Toolstrip;
    private ToolStrip Bottom_ToolStrip;
    private DataGridView dataGridView1;
    private DataSet.Letters letters1;
    private BindingSource in_letters_bindingSource1;
    private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn letterNumberDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn letterTimeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn recivedDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn letterTypeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn recipientDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn reciveMethodDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn pageCountDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn deadlineDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn refDocDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn docSummaryDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn sysDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn sysTimeDataGridViewTextBoxColumn;
    private DataSet.LettersTableAdapters.Sa_In_LettersTableAdapter sa_In_LettersTableAdapter1;
}