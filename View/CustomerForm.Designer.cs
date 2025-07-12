using System.ComponentModel;

namespace EShift_App.View;

partial class CustomerForm
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
        dataGridViewCustomers = new DataGridView();
        groupBoxDetails = new GroupBox();
        panelDetails = new Panel();
        txtAddress = new TextBox();
        lblAddress = new Label();
        txtEmail = new TextBox();
        lblEmail = new Label();
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
        ((ISupportInitialize)dataGridViewCustomers).BeginInit();
        groupBoxDetails.SuspendLayout();
        panelDetails.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridViewCustomers
        // 
        dataGridViewCustomers.AllowUserToAddRows = false;
        dataGridViewCustomers.AllowUserToDeleteRows = false;
        dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCustomers.Location = new Point(12, 59);
        dataGridViewCustomers.Name = "dataGridViewCustomers";
        dataGridViewCustomers.ReadOnly = true;
        dataGridViewCustomers.RowHeadersWidth = 51;
        dataGridViewCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewCustomers.Size = new Size(575, 582);
        dataGridViewCustomers.TabIndex = 0;
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
        groupBoxDetails.Text = "Customer Details";
        // 
        // panelDetails
        // 
        panelDetails.Controls.Add(txtAddress);
        panelDetails.Controls.Add(lblAddress);
        panelDetails.Controls.Add(txtEmail);
        panelDetails.Controls.Add(lblEmail);
        panelDetails.Controls.Add(txtPhoneNumber);
        panelDetails.Controls.Add(lblPhoneNumber);
        panelDetails.Controls.Add(txtLastName);
        panelDetails.Controls.Add(lblLastName);
        panelDetails.Controls.Add(txtFirstName);
        panelDetails.Controls.Add(lblFirstName);
        panelDetails.Location = new Point(6, 26);
        panelDetails.Name = "panelDetails";
        panelDetails.Size = new Size(365, 345);
        panelDetails.TabIndex = 14;
        // 
        // txtAddress
        // 
        txtAddress.Location = new Point(10, 151);
        txtAddress.Multiline = true;
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new Size(346, 76);
        txtAddress.TabIndex = 3;
        // 
        // lblAddress
        // 
        lblAddress.AutoSize = true;
        lblAddress.Location = new Point(10, 128);
        lblAddress.Name = "lblAddress";
        lblAddress.Size = new Size(62, 20);
        lblAddress.TabIndex = 8;
        lblAddress.Text = "Address";
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(10, 262);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(346, 27);
        txtEmail.TabIndex = 4;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Location = new Point(10, 239);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(46, 20);
        lblEmail.TabIndex = 6;
        lblEmail.Text = "Email";
        // 
        // txtPhoneNumber
        // 
        txtPhoneNumber.Location = new Point(10, 315);
        txtPhoneNumber.Name = "txtPhoneNumber";
        txtPhoneNumber.Size = new Size(346, 27);
        txtPhoneNumber.TabIndex = 5;
        // 
        // lblPhoneNumber
        // 
        lblPhoneNumber.AutoSize = true;
        lblPhoneNumber.Location = new Point(10, 292);
        lblPhoneNumber.Name = "lblPhoneNumber";
        lblPhoneNumber.Size = new Size(108, 20);
        lblPhoneNumber.TabIndex = 4;
        lblPhoneNumber.Text = "Phone Number";
        // 
        // txtLastName
        // 
        txtLastName.Location = new Point(10, 89);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new Size(346, 27);
        txtLastName.TabIndex = 2;
        // 
        // lblLastName
        // 
        lblLastName.AutoSize = true;
        lblLastName.Location = new Point(10, 66);
        lblLastName.Name = "lblLastName";
        lblLastName.Size = new Size(79, 20);
        lblLastName.TabIndex = 2;
        lblLastName.Text = "Last Name";
        // 
        // txtFirstName
        // 
        txtFirstName.Location = new Point(10, 29);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new Size(346, 27);
        txtFirstName.TabIndex = 1;
        // 
        // lblFirstName
        // 
        lblFirstName.AutoSize = true;
        lblFirstName.Location = new Point(10, 6);
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
        // 
        // btnCancel
        // 
        btnCancel.Location = new Point(16, 423);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(94, 29);
        btnCancel.TabIndex = 7;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(277, 388);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(94, 29);
        btnSave.TabIndex = 6;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnAddNew
        // 
        btnAddNew.Location = new Point(16, 388);
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
        // CustomerForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(982, 653);
        Controls.Add(lblSearch);
        Controls.Add(btnSearch);
        Controls.Add(txtSearch);
        Controls.Add(groupBoxDetails);
        Controls.Add(dataGridViewCustomers);
        Name = "CustomerForm";
        Text = "Manage Customers";
        Load += CustomerForm_Load;
        ((ISupportInitialize)dataGridViewCustomers).EndInit();
        groupBoxDetails.ResumeLayout(false);
        panelDetails.ResumeLayout(false);
        panelDetails.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridViewCustomers;
    private GroupBox groupBoxDetails;
    private TextBox txtAddress;
    private Label lblAddress;
    private TextBox txtLastName;
    private Label lblLastName;
    private TextBox txtFirstName;
    private Label lblFirstName;
    private TextBox txtPhoneNumber;
    private Label lblPhoneNumber;
    private TextBox txtEmail;
    private Label lblEmail;
    private Button btnSave;
    private Button btnAddNew;
    private Button btnDelete;
    private TextBox txtSearch;
    private Button btnSearch;
    private Label lblSearch;
    private Button btnCancel;
    private Panel panelDetails;
}