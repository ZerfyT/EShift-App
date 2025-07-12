using System.ComponentModel;

namespace EShift_App.View;

partial class AssistantForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        dataGridViewAssistants = new DataGridView();
        groupBoxDetails = new GroupBox();
        panelDetails = new Panel();
        dtpHireDate = new DateTimePicker();
        lblHireDate = new Label();
        txtPhoneNumber = new TextBox();
        lblPhoneNumber = new Label();
        txtLastName = new TextBox();
        lblLastName = new Label();
        txtFirstName = new TextBox();
        lblFirstName = new Label();
        btnDelete = new Button();
        btnCancel = new Button();
        btnSave = new Button();
        btnAddNew = new Button();
        txtSearch = new TextBox();
        btnSearch = new Button();
        lblSearch = new Label();
        ((ISupportInitialize)dataGridViewAssistants).BeginInit();
        groupBoxDetails.SuspendLayout();
        panelDetails.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridViewAssistants
        // 
        dataGridViewAssistants.AllowUserToAddRows = false;
        dataGridViewAssistants.AllowUserToDeleteRows = false;
        dataGridViewAssistants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewAssistants.Location = new Point(12, 59);
        dataGridViewAssistants.Name = "dataGridViewAssistants";
        dataGridViewAssistants.ReadOnly = true;
        dataGridViewAssistants.RowHeadersWidth = 51;
        dataGridViewAssistants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewAssistants.Size = new Size(575, 582);
        dataGridViewAssistants.TabIndex = 0;
        // 
        // groupBoxDetails
        // 
        groupBoxDetails.Controls.Add(panelDetails);
        groupBoxDetails.Controls.Add(btnDelete);
        groupBoxDetails.Controls.Add(btnCancel);
        groupBoxDetails.Controls.Add(btnSave);
        groupBoxDetails.Controls.Add(btnAddNew);
        groupBoxDetails.Location = new Point(593, 59);
        groupBoxDetails.Name = "groupBoxDetails";
        groupBoxDetails.Size = new Size(377, 582);
        groupBoxDetails.TabIndex = 1;
        groupBoxDetails.TabStop = false;
        groupBoxDetails.Text = "Assistant Details";
        // 
        // panelDetails
        // 
        panelDetails.Controls.Add(dtpHireDate);
        panelDetails.Controls.Add(lblHireDate);
        panelDetails.Controls.Add(txtPhoneNumber);
        panelDetails.Controls.Add(lblPhoneNumber);
        panelDetails.Controls.Add(txtLastName);
        panelDetails.Controls.Add(lblLastName);
        panelDetails.Controls.Add(txtFirstName);
        panelDetails.Controls.Add(lblFirstName);
        panelDetails.Location = new Point(6, 26);
        panelDetails.Name = "panelDetails";
        panelDetails.Size = new Size(365, 230);
        panelDetails.TabIndex = 14;
        // 
        // dtpHireDate
        // 
        dtpHireDate.Location = new Point(10, 185);
        dtpHireDate.Name = "dtpHireDate";
        dtpHireDate.Size = new Size(346, 27);
        dtpHireDate.TabIndex = 4;
        // 
        // lblHireDate
        // 
        lblHireDate.AutoSize = true;
        lblHireDate.Location = new Point(10, 162);
        lblHireDate.Name = "lblHireDate";
        lblHireDate.Size = new Size(73, 20);
        lblHireDate.TabIndex = 8;
        lblHireDate.Text = "Hire Date";
        // 
        // txtPhoneNumber
        // 
        txtPhoneNumber.Location = new Point(10, 128);
        txtPhoneNumber.Name = "txtPhoneNumber";
        txtPhoneNumber.Size = new Size(346, 27);
        txtPhoneNumber.TabIndex = 3;
        // 
        // lblPhoneNumber
        // 
        lblPhoneNumber.AutoSize = true;
        lblPhoneNumber.Location = new Point(10, 105);
        lblPhoneNumber.Name = "lblPhoneNumber";
        lblPhoneNumber.Size = new Size(108, 20);
        lblPhoneNumber.TabIndex = 4;
        lblPhoneNumber.Text = "Phone Number";
        // 
        // txtLastName
        // 
        txtLastName.Location = new Point(10, 71);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new Size(346, 27);
        txtLastName.TabIndex = 2;
        // 
        // lblLastName
        // 
        lblLastName.AutoSize = true;
        lblLastName.Location = new Point(10, 48);
        lblLastName.Name = "lblLastName";
        lblLastName.Size = new Size(79, 20);
        lblLastName.TabIndex = 2;
        lblLastName.Text = "Last Name";
        // 
        // txtFirstName
        // 
        txtFirstName.Location = new Point(10, 14);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new Size(346, 27);
        txtFirstName.TabIndex = 1;
        // 
        // lblFirstName
        // 
        lblFirstName.AutoSize = true;
        lblFirstName.Location = new Point(10, -9);
        lblFirstName.Name = "lblFirstName";
        lblFirstName.Size = new Size(80, 20);
        lblFirstName.TabIndex = 0;
        lblFirstName.Text = "First Name";
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(277, 547);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(94, 29);
        btnDelete.TabIndex = 9;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnCancel
        // 
        btnCancel.Location = new Point(16, 275);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(94, 29);
        btnCancel.TabIndex = 7;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(277, 275);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(94, 29);
        btnSave.TabIndex = 6;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnAddNew
        // 
        btnAddNew.Location = new Point(16, 547);
        btnAddNew.Name = "btnAddNew";
        btnAddNew.Size = new Size(94, 29);
        btnAddNew.TabIndex = 8;
        btnAddNew.Text = "Add New";
        btnAddNew.UseVisualStyleBackColor = true;
        btnAddNew.Click += btnAddNew_Click;
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(69, 26);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(413, 27);
        txtSearch.TabIndex = 10;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(488, 25);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(99, 29);
        btnSearch.TabIndex = 11;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Location = new Point(12, 29);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(53, 20);
        lblSearch.TabIndex = 12;
        lblSearch.Text = "Search";
        // 
        // AssistantForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(982, 653);
        Controls.Add(lblSearch);
        Controls.Add(btnSearch);
        Controls.Add(txtSearch);
        Controls.Add(groupBoxDetails);
        Controls.Add(dataGridViewAssistants);
        Name = "AssistantForm";
        Text = "Manage Assistants";
        Load += AssistantForm_Load;
        ((ISupportInitialize)dataGridViewAssistants).EndInit();
        groupBoxDetails.ResumeLayout(false);
        panelDetails.ResumeLayout(false);
        panelDetails.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridViewAssistants;
    private GroupBox groupBoxDetails;
    private TextBox txtLastName;
    private Label lblLastName;
    private TextBox txtFirstName;
    private Label lblFirstName;
    private TextBox txtPhoneNumber;
    private Label lblPhoneNumber;
    private Button btnSave;
    private Button btnAddNew;
    private Button btnDelete;
    private TextBox txtSearch;
    private Button btnSearch;
    private Label lblSearch;
    private Button btnCancel;
    private Panel panelDetails;
    private DateTimePicker dtpHireDate;
    private Label lblHireDate;
}