using System.ComponentModel;

namespace EShift_App.View;

partial class LorryForm
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
        dataGridViewLorries = new DataGridView();
        groupBoxDetails = new GroupBox();
        panelDetails = new Panel();
        numCapacity = new NumericUpDown();
        lblCapacity = new Label();
        txtModel = new TextBox();
        lblModel = new Label();
        txtRegistrationNumber = new TextBox();
        lblRegistrationNumber = new Label();
        btnDelete = new Button();
        btnCancel = new Button();
        btnSave = new Button();
        btnAddNew = new Button();
        txtSearch = new TextBox();
        btnSearch = new Button();
        lblSearch = new Label();
        ((ISupportInitialize)dataGridViewLorries).BeginInit();
        groupBoxDetails.SuspendLayout();
        panelDetails.SuspendLayout();
        ((ISupportInitialize)numCapacity).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewLorries
        // 
        dataGridViewLorries.AllowUserToAddRows = false;
        dataGridViewLorries.AllowUserToDeleteRows = false;
        dataGridViewLorries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewLorries.Location = new Point(12, 59);
        dataGridViewLorries.Name = "dataGridViewLorries";
        dataGridViewLorries.ReadOnly = true;
        dataGridViewLorries.RowHeadersWidth = 51;
        dataGridViewLorries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewLorries.Size = new Size(575, 582);
        dataGridViewLorries.TabIndex = 0;
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
        groupBoxDetails.Text = "Lorry Details";
        // 
        // panelDetails
        // 
        panelDetails.Controls.Add(numCapacity);
        panelDetails.Controls.Add(lblCapacity);
        panelDetails.Controls.Add(txtModel);
        panelDetails.Controls.Add(lblModel);
        panelDetails.Controls.Add(txtRegistrationNumber);
        panelDetails.Controls.Add(lblRegistrationNumber);
        panelDetails.Location = new Point(6, 26);
        panelDetails.Name = "panelDetails";
        panelDetails.Size = new Size(365, 180);
        panelDetails.TabIndex = 14;
        // 
        // numCapacity
        // 
        numCapacity.DecimalPlaces = 2;
        numCapacity.Location = new Point(10, 137);
        numCapacity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        numCapacity.Name = "numCapacity";
        numCapacity.Size = new Size(346, 27);
        numCapacity.TabIndex = 3;
        // 
        // lblCapacity
        // 
        lblCapacity.AutoSize = true;
        lblCapacity.Location = new Point(10, 114);
        lblCapacity.Name = "lblCapacity";
        lblCapacity.Size = new Size(170, 20);
        lblCapacity.TabIndex = 4;
        lblCapacity.Text = "Capacity (kg or cubic m)";
        // 
        // txtModel
        // 
        txtModel.Location = new Point(10, 80);
        txtModel.Name = "txtModel";
        txtModel.Size = new Size(346, 27);
        txtModel.TabIndex = 2;
        // 
        // lblModel
        // 
        lblModel.AutoSize = true;
        lblModel.Location = new Point(10, 57);
        lblModel.Name = "lblModel";
        lblModel.Size = new Size(52, 20);
        lblModel.TabIndex = 2;
        lblModel.Text = "Model";
        // 
        // txtRegistrationNumber
        // 
        txtRegistrationNumber.Location = new Point(10, 23);
        txtRegistrationNumber.Name = "txtRegistrationNumber";
        txtRegistrationNumber.Size = new Size(346, 27);
        txtRegistrationNumber.TabIndex = 1;
        // 
        // lblRegistrationNumber
        // 
        lblRegistrationNumber.AutoSize = true;
        lblRegistrationNumber.Location = new Point(10, 0);
        lblRegistrationNumber.Name = "lblRegistrationNumber";
        lblRegistrationNumber.Size = new Size(147, 20);
        lblRegistrationNumber.TabIndex = 0;
        lblRegistrationNumber.Text = "Registration Number";
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
        btnCancel.Location = new Point(16, 225);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(94, 29);
        btnCancel.TabIndex = 7;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(277, 225);
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
        txtSearch.Click += btnSearch_Click;
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
        // LorryForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(982, 653);
        Controls.Add(lblSearch);
        Controls.Add(btnSearch);
        Controls.Add(txtSearch);
        Controls.Add(groupBoxDetails);
        Controls.Add(dataGridViewLorries);
        Name = "LorryForm";
        Text = "Manage Lorries";
        Load += LorryForm_Load;
        Click += LorryForm_Load;
        ((ISupportInitialize)dataGridViewLorries).EndInit();
        groupBoxDetails.ResumeLayout(false);
        panelDetails.ResumeLayout(false);
        panelDetails.PerformLayout();
        ((ISupportInitialize)numCapacity).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridViewLorries;
    private GroupBox groupBoxDetails;
    private TextBox txtModel;
    private Label lblModel;
    private TextBox txtRegistrationNumber;
    private Label lblRegistrationNumber;
    private Button btnSave;
    private Button btnAddNew;
    private Button btnDelete;
    private TextBox txtSearch;
    private Button btnSearch;
    private Label lblSearch;
    private Button btnCancel;
    private Panel panelDetails;
    private NumericUpDown numCapacity;
    private Label lblCapacity;
}