using System;
using System.Configuration;

namespace SvLuka
{
	/// <summary>
	/// Summary description for ConnString.
	/// </summary>
	public class ConnString
	{
		private string mConString;

		public ConnString()
		{
            string Path = ConfigurationSettings.AppSettings["Database_Path"].ToString();


        mConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + Path;
		}

		public string ConnenctionString
		{
			get
			{
				return mConString;
			}
		}

		public bool isLogged( object logged )
		{

//			return true;

			if ( logged != null && Convert.ToBoolean( logged ) == true )
			{
				return true;
			}
			else
			{
				return false;
			}

		}
	}
}
