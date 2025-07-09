using System.ComponentModel;

namespace EShift_App.View;

partial class DriverForm
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
        tbCustomers = new DataGridView();
        groupBox1 = new GroupBox();
        button3 = new Button();
        button2 = new Button();
        button1 = new Button();
        textBox5 = new TextBox();
        txPhoneNumber = new Label();
        textBox4 = new TextBox();
        txEmail = new Label();
        txLicenseNumber = new TextBox();
        label3 = new Label();
        txLastName = new TextBox();
        label2 = new Label();
        txFirstName = new TextBox();
        label1 = new Label();
        ((ISupportInitialize)tbCustomers).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // tbCustomers
        // 
        tbCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tbCustomers.Location = new Point(12, 131);
        tbCustomers.Name = "tbCustomers";
        tbCustomers.RowHeadersWidth = 51;
        tbCustomers.Size = new Size(492, 510);
        tbCustomers.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(button3);
        groupBox1.Controls.Add(button2);
        groupBox1.Controls.Add(button1);
        groupBox1.Controls.Add(textBox5);
        groupBox1.Controls.Add(txPhoneNumber);
        groupBox1.Controls.Add(textBox4);
        groupBox1.Controls.Add(txEmail);
        groupBox1.Controls.Add(txLicenseNumber);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(txLastName);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(txFirstName);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(525, 131);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(345, 510);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "Driver Details";
        // 
        // button3
        // 
        button3.Location = new Point(6, 468);
        button3.Name = "button3";
        button3.Size = new Size(94, 29);
        button3.TabIndex = 12;
        button3.Text = "Delete";
        button3.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(245, 383);
        button2.Name = "button2";
        button2.Size = new Size(94, 29);
        button2.TabIndex = 11;
        button2.Text = "Save";
        button2.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Location = new Point(6, 433);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 10;
        button1.Text = "Add New";
        button1.UseVisualStyleBackColor = true;
        // 
        // textBox5
        // 
        textBox5.Location = new Point(6, 325);
        textBox5.Name = "textBox5";
        textBox5.Size = new Size(333, 27);
        textBox5.TabIndex = 9;
        // 
        // txPhoneNumber
        // 
        txPhoneNumber.AutoSize = true;
        txPhoneNumber.Location = new Point(6, 302);
        txPhoneNumber.Name = "txPhoneNumber";
        txPhoneNumber.Size = new Size(108, 20);
        txPhoneNumber.TabIndex = 8;
        txPhoneNumber.Text = "Phone Number";
        // 
        // textBox4
        // 
        textBox4.Location = new Point(6, 260);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(333, 27);
        textBox4.TabIndex = 7;
        // 
        // txEmail
        // 
        txEmail.AutoSize = true;
        txEmail.Location = new Point(6, 237);
        txEmail.Name = "txEmail";
        txEmail.Size = new Size(46, 20);
        txEmail.TabIndex = 6;
        txEmail.Text = "Email";
        // 
        // txLicenseNumber
        // 
        txLicenseNumber.Location = new Point(6, 190);
        txLicenseNumber.Name = "txLicenseNumber";
        txLicenseNumber.Size = new Size(333, 27);
        txLicenseNumber.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(6, 167);
        label3.Name = "label3";
        label3.Size = new Size(115, 20);
        label3.TabIndex = 4;
        label3.Text = "License Number";
        // 
        // txLastName
        // 
        txLastName.Location = new Point(6, 124);
        txLastName.Name = "txLastName";
        txLastName.Size = new Size(333, 27);
        txLastName.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(6, 101);
        label2.Name = "label2";
        label2.Size = new Size(79, 20);
        label2.TabIndex = 2;
        label2.Text = "Last Name";
        // 
        // txFirstName
        // 
        txFirstName.Location = new Point(6, 60);
        txFirstName.Name = "txFirstName";
        txFirstName.Size = new Size(333, 27);
        txFirstName.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(6, 37);
        label1.Name = "label1";
        label1.Size = new Size(80, 20);
        label1.TabIndex = 0;
        label1.Text = "First Name";
        // 
        // DriverForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 653);
        Controls.Add(groupBox1);
        Controls.Add(tbCustomers);
        Name = "DriverForm";
        Text = "DriverForm";
        ((ISupportInitialize)tbCustomers).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView tbCustomers;
    private GroupBox groupBox1;
    private TextBox txLicenseNumber;
    private Label label3;
    private TextBox txLastName;
    private Label label2;
    private TextBox txFirstName;
    private Label label1;
    private TextBox textBox5;
    private Label txPhoneNumber;
    private TextBox textBox4;
    private Label txEmail;
    private Button button2;
    private Button button1;
    private Button button3;
}