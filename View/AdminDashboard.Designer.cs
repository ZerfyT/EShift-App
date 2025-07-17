using System.ComponentModel;

namespace EShift_App.View;

partial class AdminDashboard
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        tabControlAdmin = new TabControl();
        tabPagePendingJobs = new TabPage();
        groupBox4 = new GroupBox();
        btnUpdateStatus = new Button();
        cmbJobStatus = new ComboBox();
        groupBox3 = new GroupBox();
        btnAssignUnit = new Button();
        cmbAssistant = new ComboBox();
        label5 = new Label();
        cmbDriver = new ComboBox();
        label4 = new Label();
        cmbLorry = new ComboBox();
        label3 = new Label();
        groupBox2 = new GroupBox();
        btnDeleteLoad = new Button();
        btnEditLoad = new Button();
        btnAddLoad = new Button();
        dgvLoads = new DataGridView();
        groupBox1 = new GroupBox();
        lblJobDetails = new Label();
        dgvPendingJobs = new DataGridView();
        label1 = new Label();
        tabPageAllJobs = new TabPage();
        btnExportToExcel = new Button();
        btnSearchJobs = new Button();
        txtSearchJobs = new TextBox();
        label2 = new Label();
        dgvAllJobs = new DataGridView();
        tabControlAdmin.SuspendLayout();
        tabPagePendingJobs.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox2.SuspendLayout();
        ((ISupportInitialize)dgvLoads).BeginInit();
        groupBox1.SuspendLayout();
        ((ISupportInitialize)dgvPendingJobs).BeginInit();
        tabPageAllJobs.SuspendLayout();
        ((ISupportInitialize)dgvAllJobs).BeginInit();
        SuspendLayout();
        // 
        // tabControlAdmin
        // 
        tabControlAdmin.Controls.Add(tabPagePendingJobs);
        tabControlAdmin.Controls.Add(tabPageAllJobs);
        tabControlAdmin.Location = new Point(12, 12);
        tabControlAdmin.Name = "tabControlAdmin";
        tabControlAdmin.SelectedIndex = 0;
        tabControlAdmin.Size = new Size(1238, 729);
        tabControlAdmin.TabIndex = 0;
        // 
        // tabPagePendingJobs
        // 
        tabPagePendingJobs.Controls.Add(groupBox4);
        tabPagePendingJobs.Controls.Add(groupBox3);
        tabPagePendingJobs.Controls.Add(groupBox2);
        tabPagePendingJobs.Controls.Add(groupBox1);
        tabPagePendingJobs.Controls.Add(dgvPendingJobs);
        tabPagePendingJobs.Controls.Add(label1);
        tabPagePendingJobs.Location = new Point(4, 29);
        tabPagePendingJobs.Name = "tabPagePendingJobs";
        tabPagePendingJobs.Padding = new Padding(3);
        tabPagePendingJobs.Size = new Size(1230, 696);
        tabPagePendingJobs.TabIndex = 0;
        tabPagePendingJobs.Text = "Pending Jobs & Processing";
        tabPagePendingJobs.UseVisualStyleBackColor = true;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(btnUpdateStatus);
        groupBox4.Controls.Add(cmbJobStatus);
        groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBox4.Location = new Point(927, 545);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(288, 134);
        groupBox4.TabIndex = 5;
        groupBox4.TabStop = false;
        groupBox4.Text = "Update Job Status";
        // 
        // btnUpdateStatus
        // 
        btnUpdateStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnUpdateStatus.Location = new Point(158, 80);
        btnUpdateStatus.Name = "btnUpdateStatus";
        btnUpdateStatus.Size = new Size(124, 29);
        btnUpdateStatus.TabIndex = 1;
        btnUpdateStatus.Text = "Update Status";
        btnUpdateStatus.UseVisualStyleBackColor = true;
        btnUpdateStatus.Click += btnUpdateStatus_Click;
        // 
        // cmbJobStatus
        // 
        cmbJobStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbJobStatus.FormattingEnabled = true;
        cmbJobStatus.Items.AddRange(new object[] { "Pending", "In Progress", "Completed", "Cancelled" });
        cmbJobStatus.Location = new Point(15, 35);
        cmbJobStatus.Name = "cmbJobStatus";
        cmbJobStatus.Size = new Size(267, 28);
        cmbJobStatus.TabIndex = 0;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(btnAssignUnit);
        groupBox3.Controls.Add(cmbAssistant);
        groupBox3.Controls.Add(label5);
        groupBox3.Controls.Add(cmbDriver);
        groupBox3.Controls.Add(label4);
        groupBox3.Controls.Add(cmbLorry);
        groupBox3.Controls.Add(label3);
        groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBox3.Location = new Point(469, 545);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(452, 134);
        groupBox3.TabIndex = 4;
        groupBox3.TabStop = false;
        groupBox3.Text = "Assign Transport Unit to Selected Load";
        // 
        // btnAssignUnit
        // 
        btnAssignUnit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnAssignUnit.Location = new Point(322, 80);
        btnAssignUnit.Name = "btnAssignUnit";
        btnAssignUnit.Size = new Size(124, 29);
        btnAssignUnit.TabIndex = 6;
        btnAssignUnit.Text = "Assign Unit";
        btnAssignUnit.UseVisualStyleBackColor = true;
        btnAssignUnit.Click += btnAssignUnit_Click;
        // 
        // cmbAssistant
        // 
        cmbAssistant.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbAssistant.FormattingEnabled = true;
        cmbAssistant.Location = new Point(232, 46);
        cmbAssistant.Name = "cmbAssistant";
        cmbAssistant.Size = new Size(214, 28);
        cmbAssistant.TabIndex = 5;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label5.Location = new Point(228, 23);
        label5.Name = "label5";
        label5.Size = new Size(67, 20);
        label5.TabIndex = 4;
        label5.Text = "Assistant";
        // 
        // cmbDriver
        // 
        cmbDriver.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbDriver.FormattingEnabled = true;
        cmbDriver.Location = new Point(12, 99);
        cmbDriver.Name = "cmbDriver";
        cmbDriver.Size = new Size(214, 28);
        cmbDriver.TabIndex = 3;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.Location = new Point(8, 76);
        label4.Name = "label4";
        label4.Size = new Size(49, 20);
        label4.TabIndex = 2;
        label4.Text = "Driver";
        // 
        // cmbLorry
        // 
        cmbLorry.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbLorry.FormattingEnabled = true;
        cmbLorry.Location = new Point(12, 46);
        cmbLorry.Name = "cmbLorry";
        cmbLorry.Size = new Size(214, 28);
        cmbLorry.TabIndex = 1;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(8, 23);
        label3.Name = "label3";
        label3.Size = new Size(42, 20);
        label3.TabIndex = 0;
        label3.Text = "Lorry";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btnDeleteLoad);
        groupBox2.Controls.Add(btnEditLoad);
        groupBox2.Controls.Add(btnAddLoad);
        groupBox2.Controls.Add(dgvLoads);
        groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBox2.Location = new Point(469, 285);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(746, 254);
        groupBox2.TabIndex = 3;
        groupBox2.TabStop = false;
        groupBox2.Text = "Loads for Selected Job";
        // 
        // btnDeleteLoad
        // 
        btnDeleteLoad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnDeleteLoad.Location = new Point(210, 26);
        btnDeleteLoad.Name = "btnDeleteLoad";
        btnDeleteLoad.Size = new Size(94, 29);
        btnDeleteLoad.TabIndex = 3;
        btnDeleteLoad.Text = "Delete";
        btnDeleteLoad.UseVisualStyleBackColor = true;
        btnDeleteLoad.Click += btnDeleteLoad_Click;
        // 
        // btnEditLoad
        // 
        btnEditLoad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnEditLoad.Location = new Point(110, 26);
        btnEditLoad.Name = "btnEditLoad";
        btnEditLoad.Size = new Size(94, 29);
        btnEditLoad.TabIndex = 2;
        btnEditLoad.Text = "Edit";
        btnEditLoad.UseVisualStyleBackColor = true;
        btnEditLoad.Click += btnEditLoad_Click;
        // 
        // btnAddLoad
        // 
        btnAddLoad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnAddLoad.Location = new Point(10, 26);
        btnAddLoad.Name = "btnAddLoad";
        btnAddLoad.Size = new Size(94, 29);
        btnAddLoad.TabIndex = 1;
        btnAddLoad.Text = "Add";
        btnAddLoad.UseVisualStyleBackColor = true;
        btnAddLoad.Click += btnAddLoad_Click;
        // 
        // dgvLoads
        // 
        dgvLoads.AllowUserToAddRows = false;
        dgvLoads.AllowUserToDeleteRows = false;
        dgvLoads.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvLoads.Location = new Point(10, 61);
        dgvLoads.Name = "dgvLoads";
        dgvLoads.ReadOnly = true;
        dgvLoads.RowHeadersWidth = 51;
        dgvLoads.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvLoads.Size = new Size(730, 187);
        dgvLoads.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(lblJobDetails);
        groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        groupBox1.Location = new Point(15, 285);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(448, 405);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "Selected Job Details";
        // 
        // lblJobDetails
        // 
        lblJobDetails.AutoSize = true;
        lblJobDetails.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblJobDetails.Location = new Point(15, 35);
        lblJobDetails.Name = "lblJobDetails";
        lblJobDetails.Size = new Size(215, 23);
        lblJobDetails.TabIndex = 0;
        lblJobDetails.Text = "Select a job to see details...";
        // 
        // dgvPendingJobs
        // 
        dgvPendingJobs.AllowUserToAddRows = false;
        dgvPendingJobs.AllowUserToDeleteRows = false;
        dgvPendingJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPendingJobs.Location = new Point(15, 40);
        dgvPendingJobs.Name = "dgvPendingJobs";
        dgvPendingJobs.ReadOnly = true;
        dgvPendingJobs.RowHeadersWidth = 51;
        dgvPendingJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPendingJobs.Size = new Size(1200, 239);
        dgvPendingJobs.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(11, 14);
        label1.Name = "label1";
        label1.Size = new Size(238, 23);
        label1.TabIndex = 0;
        label1.Text = "New Customer Job Requests";
        // 
        // tabPageAllJobs
        // 
        tabPageAllJobs.Controls.Add(btnExportToExcel);
        tabPageAllJobs.Controls.Add(btnSearchJobs);
        tabPageAllJobs.Controls.Add(txtSearchJobs);
        tabPageAllJobs.Controls.Add(label2);
        tabPageAllJobs.Controls.Add(dgvAllJobs);
        tabPageAllJobs.Location = new Point(4, 29);
        tabPageAllJobs.Name = "tabPageAllJobs";
        tabPageAllJobs.Padding = new Padding(3);
        tabPageAllJobs.Size = new Size(1230, 696);
        tabPageAllJobs.TabIndex = 1;
        tabPageAllJobs.Text = "All Jobs & Reports";
        tabPageAllJobs.UseVisualStyleBackColor = true;
        // 
        // btnExportToExcel
        // 
        btnExportToExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnExportToExcel.Location = new Point(1080, 20);
        btnExportToExcel.Name = "btnExportToExcel";
        btnExportToExcel.Size = new Size(135, 29);
        btnExportToExcel.TabIndex = 4;
        btnExportToExcel.Text = "Export to Excel";
        btnExportToExcel.UseVisualStyleBackColor = true;
        btnExportToExcel.Click += btnExportToExcel_Click;
        // 
        // btnSearchJobs
        // 
        btnSearchJobs.Location = new Point(450, 20);
        btnSearchJobs.Name = "btnSearchJobs";
        btnSearchJobs.Size = new Size(94, 29);
        btnSearchJobs.TabIndex = 3;
        btnSearchJobs.Text = "Search";
        btnSearchJobs.UseVisualStyleBackColor = true;
        btnSearchJobs.Click += btnSearchJobs_Click;
        // 
        // txtSearchJobs
        // 
        txtSearchJobs.Location = new Point(75, 21);
        txtSearchJobs.Name = "txtSearchJobs";
        txtSearchJobs.Size = new Size(369, 27);
        txtSearchJobs.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(15, 24);
        label2.Name = "label2";
        label2.Size = new Size(53, 20);
        label2.TabIndex = 1;
        label2.Text = "Search";
        // 
        // dgvAllJobs
        // 
        dgvAllJobs.AllowUserToAddRows = false;
        dgvAllJobs.AllowUserToDeleteRows = false;
        dgvAllJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvAllJobs.Location = new Point(15, 60);
        dgvAllJobs.Name = "dgvAllJobs";
        dgvAllJobs.ReadOnly = true;
        dgvAllJobs.RowHeadersWidth = 51;
        dgvAllJobs.Size = new Size(1200, 620);
        dgvAllJobs.TabIndex = 0;
        // 
        // AdminDashboard
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1262, 753);
        Controls.Add(tabControlAdmin);
        Name = "AdminDashboard";
        Text = "Admin Dashboard";
        WindowState = FormWindowState.Maximized;
        Load += AdminDashboard_Load;
        tabControlAdmin.ResumeLayout(false);
        tabPagePendingJobs.ResumeLayout(false);
        tabPagePendingJobs.PerformLayout();
        groupBox4.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox2.ResumeLayout(false);
        ((ISupportInitialize)dgvLoads).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((ISupportInitialize)dgvPendingJobs).EndInit();
        tabPageAllJobs.ResumeLayout(false);
        tabPageAllJobs.PerformLayout();
        ((ISupportInitialize)dgvAllJobs).EndInit();
        ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControlAdmin;
    private System.Windows.Forms.TabPage tabPagePendingJobs;
    private System.Windows.Forms.TabPage tabPageAllJobs;
    private System.Windows.Forms.DataGridView dgvPendingJobs;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnExportToExcel;
    private System.Windows.Forms.Button btnSearchJobs;
    private System.Windows.Forms.TextBox txtSearchJobs;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView dgvAllJobs;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DataGridView dgvLoads;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label lblJobDetails;
    private System.Windows.Forms.Button btnDeleteLoad;
    private System.Windows.Forms.Button btnEditLoad;
    private System.Windows.Forms.Button btnAddLoad;
    private System.Windows.Forms.Button btnAssignUnit;
    private System.Windows.Forms.ComboBox cmbAssistant;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox cmbDriver;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cmbLorry;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Button btnUpdateStatus;
    private System.Windows.Forms.ComboBox cmbJobStatus;
}