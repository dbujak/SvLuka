using System;

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
        string Path = "c:\\sites\\Single37\\dbujak\\Database\\SvLukaSchedules.mdb";
//		Path = "c:\\inetpub\\wwwroot\\SvLuka\\WhatsNew\\SvLukaSchedules.mdb";

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
