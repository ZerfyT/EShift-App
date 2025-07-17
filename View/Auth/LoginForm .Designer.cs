namespace EShift_App.View.Auth;
partial class LoginForm
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
        this.linkRegister = new System.Windows.Forms.LinkLabel();
        this.label4 = new System.Windows.Forms.Label();
        this.btnLogin = new System.Windows.Forms.Button();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // lblTitle
        // 
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblTitle.Location = new System.Drawing.Point(12, 20);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(262, 38);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "e-Shift Login Panel";
        // 
        // panel1
        // 
        this.panel1.BackColor = System.Drawing.Color.White;
        this.panel1.Controls.Add(this.linkRegister);
        this.panel1.Controls.Add(this.label4);
        this.panel1.Controls.Add(this.btnLogin);
        this.panel1.Controls.Add(this.txtPassword);
        this.panel1.Controls.Add(this.label2);
        this.panel1.Controls.Add(this.txtEmail);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Location = new System.Drawing.Point(19, 75);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(445, 365);
        this.panel1.TabIndex = 1;
        // 
        // linkRegister
        // 
        this.linkRegister.AutoSize = true;
        this.linkRegister.Location = new System.Drawing.Point(260, 325);
        this.linkRegister.Name = "linkRegister";
        this.linkRegister.Size = new System.Drawing.Size(101, 20);
        this.linkRegister.TabIndex = 4;
        this.linkRegister.TabStop = true;
        this.linkRegister.Text = "Register Now";
        this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(85, 325);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(169, 20);
        this.label4.TabIndex = 5;
        this.label4.Text = "Don't have an account?";
        // 
        // btnLogin
        // 
        this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnLogin.Location = new System.Drawing.Point(30, 240);
        this.btnLogin.Name = "btnLogin";
        this.btnLogin.Size = new System.Drawing.Size(385, 45);
        this.btnLogin.TabIndex = 3;
        this.btnLogin.Text = "Login";
        this.btnLogin.UseVisualStyleBackColor = true;
        this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        // 
        // txtPassword
        // 
        this.txtPassword.Location = new System.Drawing.Point(30, 160);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.PasswordChar = '*';
        this.txtPassword.Size = new System.Drawing.Size(385, 27);
        this.txtPassword.TabIndex = 2;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(26, 137);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(70, 20);
        this.label2.TabIndex = 2;
        this.label2.Text = "Password";
        // 
        // txtEmail
        // 
        this.txtEmail.Location = new System.Drawing.Point(30, 70);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(385, 27);
        this.txtEmail.TabIndex = 1;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(26, 47);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(46, 20);
        this.label1.TabIndex = 0;
        this.label1.Text = "Email";
        // 
        // LoginForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(482, 453);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.lblTitle);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "LoginForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Login";
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.LinkLabel linkRegister;
    private System.Windows.Forms.Label label4;
}

