using System;
using System.Data;
using System.Data.SqlClient;


namespace Nhom4
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class Conetion
	{
		public static SqlConnection cn;
		public static string Password;

		public static SqlConnection conet()
		{
			try
			{
				cn = new SqlConnection("Server=.; Initial Catalog=GroupFourDatabase;uid=sa;pwd=sa");
			}
			catch(Exception ex)
			{
				ex.Message.ToString();
			}
			return cn;

		}
	}

	}
