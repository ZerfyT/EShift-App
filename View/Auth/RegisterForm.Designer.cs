using System.ComponentModel;

namespace EShift_App.View.Auth;

partial class RegisterForm
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
        this.lblTitle = new System.Windows.Forms.Label();
        this.panel1 = new System.Windows.Forms.Panel();
        this.txtConfirmPassword = new System.Windows.Forms.TextBox();
        this.label6 = new System.Windows.Forms.Label();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.label5 = new System.Windows.Forms.Label();
        this.txtAddress = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.btnRegister = new System.Windows.Forms.Button();
        this.txtPhoneNumber = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.txtLastName = new System.Windows.Forms.TextBox();
        this.lblLastName = new System.Windows.Forms.Label();
        this.txtFirstName = new System.Windows.Forms.TextBox();
        this.lblFirstName = new System.Windows.Forms.Label();
        this.panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // lblTitle
        // 
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblTitle.Location = new System.Drawing.Point(12, 9);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(393, 38);
        this.lblTitle.TabIndex = 2;
        this.lblTitle.Text = "Create Your e-Shift Account";
        // 
        // panel1
        // 
        this.panel1.BackColor = System.Drawing.Color.White;
        this.panel1.Controls.Add(this.txtConfirmPassword);
        this.panel1.Controls.Add(this.label6);
        this.panel1.Controls.Add(this.txtPassword);
        this.panel1.Controls.Add(this.label5);
        this.panel1.Controls.Add(this.txtAddress);
        this.panel1.Controls.Add(this.label3);
        this.panel1.Controls.Add(this.btnRegister);
        this.panel1.Controls.Add(this.txtPhoneNumber);
        this.panel1.Controls.Add(this.label2);
        this.panel1.Controls.Add(this.txtEmail);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Controls.Add(this.txtLastName);
        this.panel1.Controls.Add(this.lblLastName);
        this.panel1.Controls.Add(this.txtFirstName);
        this.panel1.Controls.Add(this.lblFirstName);
        this.panel1.Location = new System.Drawing.Point(19, 60);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(545, 580);
        this.panel1.TabIndex = 3;
        // 
        // txtConfirmPassword
        // 
        this.txtConfirmPassword.Location = new System.Drawing.Point(30, 440);
        this.txtConfirmPassword.Name = "txtConfirmPassword";
        this.txtConfirmPassword.PasswordChar = '*';
        this.txtConfirmPassword.Size = new System.Drawing.Size(485, 27);
        this.txtConfirmPassword.TabIndex = 7;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(26, 417);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(127, 20);
        this.label6.TabIndex = 12;
        this.label6.Text = "Confirm Password";
        // 
        // txtPassword
        // 
        this.txtPassword.Location = new System.Drawing.Point(30, 380);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.PasswordChar = '*';
        this.txtPassword.Size = new System.Drawing.Size(485, 27);
        this.txtPassword.TabIndex = 6;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(26, 357);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(70, 20);
        this.label5.TabIndex = 10;
        this.label5.Text = "Password";
        // 
        // txtAddress
        // 
        this.txtAddress.Location = new System.Drawing.Point(30, 250);
        this.txtAddress.Multiline = true;
        this.txtAddress.Name = "txtAddress";
        this.txtAddress.Size = new System.Drawing.Size(485, 90);
        this.txtAddress.TabIndex = 5;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(26, 227);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(62, 20);
        this.label3.TabIndex = 8;
        this.label3.Text = "Address";
        // 
        // btnRegister
        // 
        this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnRegister.Location = new System.Drawing.Point(335, 500);
        this.btnRegister.Name = "btnRegister";
        this.btnRegister.Size = new System.Drawing.Size(180, 45);
        this.btnRegister.TabIndex = 8;
        this.btnRegister.Text = "Register";
        this.btnRegister.UseVisualStyleBackColor = true;
        this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
        // 
        // txtPhoneNumber
        // 
        this.txtPhoneNumber.Location = new System.Drawing.Point(30, 190);
        this.txtPhoneNumber.Name = "txtPhoneNumber";
        this.txtPhoneNumber.Size = new System.Drawing.Size(485, 27);
        this.txtPhoneNumber.TabIndex = 4;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(26, 167);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(108, 20);
        this.label2.TabIndex = 2;
        this.label2.Text = "Phone Number";
        // 
        // txtEmail
        // 
        this.txtEmail.Location = new System.Drawing.Point(30, 130);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(485, 27);
        this.txtEmail.TabIndex = 3;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(26, 107);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(46, 20);
        this.label1.TabIndex = 0;
        this.label1.Text = "Email";
        // 
        // txtLastName
        // 
        this.txtLastName.Location = new System.Drawing.Point(285, 50);
        this.txtLastName.Name = "txtLastName";
        this.txtLastName.Size = new System.Drawing.Size(230, 27);
        this.txtLastName.TabIndex = 2;
        // 
        // lblLastName
        // 
        this.lblLastName.AutoSize = true;
        this.lblLastName.Location = new System.Drawing.Point(281, 27);
        this.lblLastName.Name = "lblLastName";
        this.lblLastName.Size = new System.Drawing.Size(79, 20);
        this.lblLastName.TabIndex = 14;
        this.lblLastName.Text = "Last Name";
        // 
        // txtFirstName
        // 
        this.txtFirstName.Location = new System.Drawing.Point(30, 50);
        this.txtFirstName.Name = "txtFirstName";
        this.txtFirstName.Size = new System.Drawing.Size(230, 27);
        this.txtFirstName.TabIndex = 1;
        // 
        // lblFirstName
        // 
        this.lblFirstName.AutoSize = true;
        this.lblFirstName.Location = new System.Drawing.Point(26, 27);
        this.lblFirstName.Name = "lblFirstName";
        this.lblFirstName.Size = new System.Drawing.Size(80, 20);
        this.lblFirstName.TabIndex = 13;
        this.lblFirstName.Text = "First Name";
        // 
        // RegisterForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(582, 653);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.lblTitle);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "RegisterForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Register New Account";
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.TextBox txtPhoneNumber;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtConfirmPassword;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtLastName;
    private System.Windows.Forms.Label lblLastName;
    private System.Windows.Forms.TextBox txtFirstName;
    private System.Windows.Forms.Label lblFirstName;
}

