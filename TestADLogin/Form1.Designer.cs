namespace TestADLogin
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblUserName = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.cmbDomains = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.cmbUserNames = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbGroups = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCurrentUser = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtUserIdentity = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Domain";
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(17, 93);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(60, 13);
			this.lblUserName.TabIndex = 1;
			this.lblUserName.Text = "User Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			// 
			// txtPassword
			// 
			this.txtPassword.Enabled = false;
			this.txtPassword.Location = new System.Drawing.Point(83, 124);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(234, 20);
			this.txtPassword.TabIndex = 5;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(242, 165);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 6;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// cmbDomains
			// 
			this.cmbDomains.FormattingEnabled = true;
			this.cmbDomains.Location = new System.Drawing.Point(83, 22);
			this.cmbDomains.Name = "cmbDomains";
			this.cmbDomains.Size = new System.Drawing.Size(234, 21);
			this.cmbDomains.TabIndex = 8;
			this.cmbDomains.SelectedValueChanged += new System.EventHandler(this.cmbDomains_SelectedValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 240);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Login Result:";
			// 
			// txtResult
			// 
			this.txtResult.Enabled = false;
			this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResult.Location = new System.Drawing.Point(82, 240);
			this.txtResult.Multiline = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(235, 68);
			this.txtResult.TabIndex = 10;
			// 
			// cmbUserNames
			// 
			this.cmbUserNames.Enabled = false;
			this.cmbUserNames.FormattingEnabled = true;
			this.cmbUserNames.Location = new System.Drawing.Point(83, 90);
			this.cmbUserNames.Name = "cmbUserNames";
			this.cmbUserNames.Size = new System.Drawing.Size(234, 21);
			this.cmbUserNames.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Groups";
			// 
			// cmbGroups
			// 
			this.cmbGroups.Enabled = false;
			this.cmbGroups.FormattingEnabled = true;
			this.cmbGroups.Location = new System.Drawing.Point(83, 56);
			this.cmbGroups.Name = "cmbGroups";
			this.cmbGroups.Size = new System.Drawing.Size(234, 21);
			this.cmbGroups.TabIndex = 13;
			this.cmbGroups.SelectedValueChanged += new System.EventHandler(this.cmbGroups_SelectedValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(342, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Current Windows User:";
			// 
			// txtCurrentUser
			// 
			this.txtCurrentUser.Location = new System.Drawing.Point(464, 56);
			this.txtCurrentUser.Name = "txtCurrentUser";
			this.txtCurrentUser.ReadOnly = true;
			this.txtCurrentUser.Size = new System.Drawing.Size(157, 20);
			this.txtCurrentUser.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(345, 93);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(276, 30);
			this.label6.TabIndex = 16;
			this.label6.Text = "Use this token to save and verify the current active user later, if required:";
			// 
			// txtUserIdentity
			// 
			this.txtUserIdentity.Location = new System.Drawing.Point(345, 124);
			this.txtUserIdentity.Name = "txtUserIdentity";
			this.txtUserIdentity.ReadOnly = true;
			this.txtUserIdentity.Size = new System.Drawing.Size(276, 20);
			this.txtUserIdentity.TabIndex = 17;
			// 
			// Form1
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 364);
			this.Controls.Add(this.txtUserIdentity);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtCurrentUser);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmbGroups);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbUserNames);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbDomains);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.ComboBox cmbDomains;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.ComboBox cmbUserNames;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbGroups;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCurrentUser;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtUserIdentity;
	}
}

