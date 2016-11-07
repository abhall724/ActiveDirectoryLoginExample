using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;

namespace TestADLogin
{
	[Serializable]
	public class ADUser : IComparable
	{
		public ADUser()
		{ }

		public ADUser(UserPrincipal principal)
		{
			FirstName = principal.GivenName;
			MiddleName = principal.MiddleName;
			LastName = principal.Surname;
			Enabled = principal.Enabled;
			UserName = principal.SamAccountName;
			EmailAddress = principal.EmailAddress;
		}

		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public bool? Enabled { get; set; }
		public string UserName { get; set; }
		public string EmailAddress { get; set; }

		public override string ToString()
		{
			return UserName;
		}

		/// <summary>
		/// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
		/// </summary>
		/// <param name="obj">An object to compare with this instance.</param>
		/// <returns>
		/// A value that indicates the relative order of the objects being compared. The return value has these meanings: 
		/// Value Meaning Less than zero This instance precedes <paramref name="obj" /> in the sort order. 
		/// Zero This instance occurs in the same position in the sort order as <paramref name="obj" />. 
		/// Greater than zero This instance follows <paramref name="obj" /> in the sort order.
		/// </returns>
		public int CompareTo(object obj)
		{
			if (obj == null) return 1;

			ADUser otherUser = obj as ADUser;

			if (otherUser != null)
			{
				return this.UserName.CompareTo(otherUser.UserName);
			}
			else
			{
				throw new ArgumentException("Object is not an ADUser");
			}
		}
	}
}
