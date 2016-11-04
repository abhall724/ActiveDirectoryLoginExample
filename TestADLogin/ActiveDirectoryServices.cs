using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;

namespace TestADLogin
{
	// Link for further uses: http://www.codeproject.com/Articles/38344/Using-System-DirectoryServices-AccountManagement
	public class ActiveDirectoryServices
	{
		public static List<Domain> GetDomains()
		{
			var dc = new DirectoryContext(DirectoryContextType.Forest);

			var forest = Forest.GetForest(dc);
			var domainCollection = forest.Domains;

			List<Domain> domains = new List<Domain>();

			foreach (Domain dom in domainCollection)
			{
				domains.Add(dom);
			}

			return domains;
		}

		private static void GetAllUserNamesExtracted(List<string> results, SearchResultCollection oSearchResultCollection)
		{
			foreach (SearchResult item in oSearchResultCollection)
			{
				DirectoryEntry entry = item.GetDirectoryEntry();

				if (entry.Properties.Contains("sAMAccountName"))
				{
					results.Add(entry.Properties["sAMAccountName"].Value.ToString());
				}
			}
		}

		public static List<string> GetAllUserNames(Domain domain)
		{
			try
			{
				using (var pc = new PrincipalContext(ContextType.Domain, domain.Name, null, ContextOptions.Negotiate | ContextOptions.Signing | ContextOptions.Sealing))
				{
					using (var gp = new UserPrincipal(pc))
					{
						PrincipalSearcher searcher = new PrincipalSearcher(gp);

						var result = searcher.FindAll().Select(x => x.SamAccountName);
						return result.ToList();
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}

			return new List<string>();
		}

		public static List<string> GetAllUserNamesOld(Domain domain)
		{
			List<string> results = new List<string>();

			try
			{
				SearchResultCollection oSearchResultCollection = SearchDomain(domain.GetDirectoryEntry(), "(objectCategory=user)", SearchScope.Subtree);
				GetAllUserNamesExtracted(results, oSearchResultCollection);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}

			return results;
		}

		public static List<string> GetGroupNames(Domain domain)
		{
			try
			{
				using (var pc = new PrincipalContext(ContextType.Domain, domain.Name, null, ContextOptions.Negotiate | ContextOptions.Signing | ContextOptions.Sealing))
				{
					using (var gp = new GroupPrincipal(pc))
					{
						PrincipalSearcher searcher = new PrincipalSearcher(gp);

						var result = searcher.FindAll().Select(x => x.Name);
						return result.ToList();
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}

			return new List<string>();
		}

		public static List<string> GetGroupNamesOld(DirectoryEntry directoryEntry)
		{
			List<string> results = new List<string>();

			try
			{
				SearchResultCollection oSearchResultCollection = SearchDomain(directoryEntry, "(objectCategory=organizationalUnit)", SearchScope.Subtree);

				foreach (SearchResult item in oSearchResultCollection)
				{
					results.Add(item.GetDirectoryEntry().Name);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}

			return results;
		}

		public static List<string> GetAllUserNamesByGroup(Domain domain, string group)
		{
			List<string> results = new List<string>();

			try
			{
				using (var pc = new PrincipalContext(ContextType.Domain, domain.Name, null, ContextOptions.Negotiate | ContextOptions.Signing | ContextOptions.Sealing))
				{
					using (var gp = GroupPrincipal.FindByIdentity(pc, group))
					{
						var members = gp.GetMembers(true).Select(u => u.SamAccountName);
						return members.ToList();
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}

			return results;
		}

		private static SearchResultCollection SearchDomain(DirectoryEntry searchRoot, string searchFilter, SearchScope scope)
		{
			try
			{
				DirectorySearcher oDirectorySearcher = new DirectorySearcher(searchRoot,
					searchFilter, null, scope);

				var collection = oDirectorySearcher.FindAll();
				oDirectorySearcher.Dispose();
				return collection;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			

			return null;
		}

		public static bool AuthenticateUser(string domain, string userName, string password)
		{
			try
			{
				using (var context = new PrincipalContext(ContextType.Domain, domain, null, ContextOptions.Negotiate | ContextOptions.Signing | ContextOptions.Sealing))
				{
					return context.ValidateCredentials(userName, password);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return false;
			}
		}
	}
}
