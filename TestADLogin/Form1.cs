﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Collections;

namespace TestADLogin
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			this.InitializeComponent();
			this.cmbDomains.Items.AddRange(ActiveDirectoryServices.GetDomains().ToArray());
			
		}

		private void cmbDomains_SelectedValueChanged(object sender, EventArgs e)
		{
			this.cmbGroups.Enabled = true;
			this.cmbUserNames.Enabled = true;
			this.txtPassword.Enabled = true;

			var domain = ((Domain)cmbDomains.SelectedItem);

			var users = ActiveDirectoryServices.GetAllUserNames(domain);
			var groups = ActiveDirectoryServices.GetGroupNames(domain);

			this.cmbUserNames.Items.Clear();
			this.cmbUserNames.Items.AddRange(users.ToArray());

			this.cmbGroups.Items.Clear();
			this.cmbGroups.Items.AddRange(groups.ToArray());
		}


		private void btnLogin_Click(object sender, EventArgs e)
		{
			AuthenticateUser();
		}

		private void AuthenticateUser()
		{
			ActiveDirectoryServices ads = new ActiveDirectoryServices();

			if(ActiveDirectoryServices.AuthenticateUser(cmbDomains.Text, cmbUserNames.Text, txtPassword.Text))
			{
				this.txtResult.Text = "True";
			}
			else
			{
				this.txtResult.Text = "Login failed";
			}
		}

		private void cmbGroups_SelectedValueChanged(object sender, EventArgs e)
		{
			var domain = ((Domain)cmbDomains.SelectedItem);
			var users = ActiveDirectoryServices.GetAllUserNamesByGroup(domain, cmbGroups.Text);
			this.cmbUserNames.Items.Clear();
			this.cmbUserNames.Items.AddRange(users.ToArray());
		}
	}
}