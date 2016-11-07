using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestADLogin;

namespace UnitTestADLogin
{
	[TestClass]
	
	public class UnitTestActiveDirectoryServices
	{
		[TestMethod]
		[TestCategory("Integration Test")]
		public void TestGetDomains()
		{
			List<Domain> domains = ActiveDirectoryServices.GetDomains();
			Assert.IsTrue(domains.Count > 0);
		}

		[TestMethod]
		public void TestGetAllUserNames()
		{
			Domain domain = ActiveDirectoryServices.GetDomains().FirstOrDefault();

			List<ADUser> users = ActiveDirectoryServices.GetAllUsers(domain);
			Assert.IsTrue(users.Count > 0);
		}

		[TestMethod]
		public void TestGetAllUserNamesOld()
		{
			Domain domain = ActiveDirectoryServices.GetDomains().FirstOrDefault();

			List<string> users = ActiveDirectoryServices.GetAllUsersOld(domain);
			Assert.IsTrue(users.Count > 0);
		}

		[TestMethod]
		public void TestGetGroupNamesOld()
		{
			Domain domain = ActiveDirectoryServices.GetDomains().FirstOrDefault();
			List<string> groups = ActiveDirectoryServices.GetGroupNamesOld(domain.GetDirectoryEntry());

			Assert.IsTrue(groups.Count > 0);
		}

		[TestMethod]
		public void TestGetGroupNames()
		{
			Domain domain = ActiveDirectoryServices.GetDomains().FirstOrDefault();
			List<string> groups = ActiveDirectoryServices.GetGroupNames(domain);

			Assert.IsTrue(groups.Count > 0);
		}

		[TestMethod]
		public void TestGetAllUserNamesByGroup()
		{
			Domain domain = ActiveDirectoryServices.GetDomains().FirstOrDefault();
			string group = ActiveDirectoryServices.GetGroupNames(domain).SingleOrDefault(x => x.Equals("Users"));
			List<string> users = ActiveDirectoryServices.GetAllUserNamesByGroup(domain, group);
			Assert.IsTrue(users.Count > 0);
		}

		[TestMethod]
		public void TestAuthenticateShouldFail()
		{
			Domain domain = ActiveDirectoryServices.GetDomains().FirstOrDefault();
			bool result = ActiveDirectoryServices.AuthenticateUser(domain.Name, "test", "1234");

			Assert.IsFalse(result);
		}
	}
}
