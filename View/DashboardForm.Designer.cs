using System.ComponentModel;

namespace EShift_App.View;

partial class DashboardForm
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
        tbUpcomiingJobs = new DataGridView();
        label1 = new Label();
        ((ISupportInitialize)tbUpcomiingJobs).BeginInit();
        SuspendLayout();
        // 
        // tbUpcomiingJobs
        // 
        tbUpcomiingJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tbUpcomiingJobs.Location = new Point(22, 217);
        tbUpcomiingJobs.Name = "tbUpcomiingJobs";
        tbUpcomiingJobs.RowHeadersWidth = 51;
        tbUpcomiingJobs.Size = new Size(831, 407);
        tbUpcomiingJobs.TabIndex = 0;
        tbUpcomiingJobs.Text = "dataGridView1";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(22, 181);
        label1.Name = "label1";
        label1.Size = new Size(111, 20);
        label1.TabIndex = 1;
        label1.Text = "Upcoming Jobs";
        // 
        // DashboardForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 653);
        Controls.Add(label1);
        Controls.Add(tbUpcomiingJobs);
        Name = "DashboardForm";
        Text = "DashboardForm";
        ((ISupportInitialize)tbUpcomiingJobs).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.DataGridView tbUpcomiingJobs;

    #endregion

    private Label label1;
}