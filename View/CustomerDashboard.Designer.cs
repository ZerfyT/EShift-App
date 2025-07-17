namespace EShift_App.View
{
    partial class CustomerDashboard
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageNewJob = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numVolume = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.txtGoodsDescription = new System.Windows.Forms.TextBox();
            this.lblGoodsDescription = new System.Windows.Forms.Label();
            this.btnPlaceJob = new System.Windows.Forms.Button();
            this.dtpJobDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageMyJobs = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvMyJobs = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageNewJob.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            this.tabPageMyJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageNewJob);
            this.tabControlMain.Controls.Add(this.tabPageMyJobs);
            this.tabControlMain.Location = new System.Drawing.Point(12, 53);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(958, 588);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageNewJob
            // 
            this.tabPageNewJob.Controls.Add(this.groupBox1);
            this.tabPageNewJob.Location = new System.Drawing.Point(4, 29);
            this.tabPageNewJob.Name = "tabPageNewJob";
            this.tabPageNewJob.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewJob.Size = new System.Drawing.Size(950, 555);
            this.tabPageNewJob.TabIndex = 0;
            this.tabPageNewJob.Text = "Place New Job/Order";
            this.tabPageNewJob.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numVolume);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numWeight);
            this.groupBox1.Controls.Add(this.txtGoodsDescription);
            this.groupBox1.Controls.Add(this.lblGoodsDescription);
            this.groupBox1.Controls.Add(this.btnPlaceJob);
            this.groupBox1.Controls.Add(this.dtpJobDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDestination);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStartLocation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 510);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Job Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Est. Volume (cubic meters)";
            // 
            // numVolume
            // 
            this.numVolume.DecimalPlaces = 2;
            this.numVolume.Location = new System.Drawing.Point(290, 373);
            this.numVolume.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numVolume.Name = "numVolume";
            this.numVolume.Size = new System.Drawing.Size(235, 27);
            this.numVolume.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Est. Weight (kg)";
            // 
            // numWeight
            // 
            this.numWeight.DecimalPlaces = 2;
            this.numWeight.Location = new System.Drawing.Point(25, 373);
            this.numWeight.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(235, 27);
            this.numWeight.TabIndex = 5;
            // 
            // txtGoodsDescription
            // 
            this.txtGoodsDescription.Location = new System.Drawing.Point(25, 225);
            this.txtGoodsDescription.Multiline = true;
            this.txtGoodsDescription.Name = "txtGoodsDescription";
            this.txtGoodsDescription.Size = new System.Drawing.Size(500, 95);
            this.txtGoodsDescription.TabIndex = 4;
            // 
            // lblGoodsDescription
            // 
            this.lblGoodsDescription.AutoSize = true;
            this.lblGoodsDescription.Location = new System.Drawing.Point(21, 202);
            this.lblGoodsDescription.Name = "lblGoodsDescription";
            this.lblGoodsDescription.Size = new System.Drawing.Size(296, 20);
            this.lblGoodsDescription.TabIndex = 7;
            this.lblGoodsDescription.Text = "Goods Description (e.g., bed, fridge, sofa)";
            // 
            // btnPlaceJob
            // 
            this.btnPlaceJob.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceJob.Location = new System.Drawing.Point(344, 440);
            this.btnPlaceJob.Name = "btnPlaceJob";
            this.btnPlaceJob.Size = new System.Drawing.Size(180, 45);
            this.btnPlaceJob.TabIndex = 8;
            this.btnPlaceJob.Text = "Place Job Request";
            this.btnPlaceJob.UseVisualStyleBackColor = true;
            this.btnPlaceJob.Click += new System.EventHandler(this.btnPlaceJob_Click);
            // 
            // dtpJobDate
            // 
            this.dtpJobDate.Location = new System.Drawing.Point(25, 155);
            this.dtpJobDate.Name = "dtpJobDate";
            this.dtpJobDate.Size = new System.Drawing.Size(500, 27);
            this.dtpJobDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Requested Date";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(25, 95);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(500, 27);
            this.txtDestination.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination Address";
            // 
            // txtStartLocation
            // 
            this.txtStartLocation.Location = new System.Drawing.Point(25, 35);
            this.txtStartLocation.Name = "txtStartLocation";
            this.txtStartLocation.Size = new System.Drawing.Size(500, 27);
            this.txtStartLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pickup Address";
            // 
            // tabPageMyJobs
            // 
            this.tabPageMyJobs.Controls.Add(this.btnRefresh);
            this.tabPageMyJobs.Controls.Add(this.dgvMyJobs);
            this.tabPageMyJobs.Location = new System.Drawing.Point(4, 29);
            this.tabPageMyJobs.Name = "tabPageMyJobs";
            this.tabPageMyJobs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMyJobs.Size = new System.Drawing.Size(950, 555);
            this.tabPageMyJobs.TabIndex = 1;
            this.tabPageMyJobs.Text = "My Job History";
            this.tabPageMyJobs.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(820, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 29);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvMyJobs
            // 
            this.dgvMyJobs.AllowUserToAddRows = false;
            this.dgvMyJobs.AllowUserToDeleteRows = false;
            this.dgvMyJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyJobs.Location = new System.Drawing.Point(15, 50);
            this.dgvMyJobs.Name = "dgvMyJobs";
            this.dgvMyJobs.ReadOnly = true;
            this.dgvMyJobs.RowHeadersWidth = 51;
            this.dgvMyJobs.Size = new System.Drawing.Size(915, 485);
            this.dgvMyJobs.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(185, 31);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, User!";
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.tabControlMain);
            this.Name = "CustomerDashboard";
            this.Text = "Customer Dashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageNewJob.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            this.tabPageMyJobs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageNewJob;
        private System.Windows.Forms.TabPage tabPageMyJobs;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dgvMyJobs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPlaceJob;
        private System.Windows.Forms.DateTimePicker dtpJobDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.TextBox txtGoodsDescription;
        private System.Windows.Forms.Label lblGoodsDescription;
    }
}