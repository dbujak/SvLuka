using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace SvLuka.Login
{
	/// <summary>
	/// Summary description for _default.
	/// </summary>
	public partial class _default : System.Web.UI.Page
	{
		protected SvLuka.controls.Header Header1;

		
		protected void Page_Load(object sender, System.EventArgs e)
		{
			//Check what user forwarded to us
			if (this.IsPostBack == false)
			{

				string strEnc = Request["txtEncryptedUser"];

				if (strEnc == "")
				{
					BadUser();
				}
	                
				string privateKey = "<RSAKeyValue><Modulus>qqcd9JNSOAvgUZB15bZkzlEea5sc9PELRskeSme7yhlG0niMxbkERstlNx5uKUQye0qBXWBmooyCW6Cz0k4TSbhbZsD4QR5OU+odqPvMuw5jD8Jzn+ZA58RSYcQt/QfXDVKH4dbIFmIpAojuCEyxiTPVuoe5ZiKgL1Y8/4HdBEE=</Modulus><Exponent>AQAB</Exponent><P>1daF9JioOgO0Xo7bL8p5/CiHlRRUXYWYW2lzOM+2EFFmOY68c5dQuOqfNNG8hrgKgcoJUrdMUxZV30dqW/ig5w==</P><Q>zEzSIWxd5ERfX2YWyoPsdDBwoM1gf5IQhD4jW3BwQbhxnnlK8fXpvm4ZBWXgVaS6sj44fB6YACeuFBIB2+mElw==</Q><DP>ZU/QA4TYHzRmHm68djYN+WQSaJVLK0wCVTzutDnk3nJSZm6z5mgIfLPcXiAInCNSBw/7vs7NQIhSgwjI4W44fQ==</DP><DQ>lhPMvQ7NPlVXtk3ZajVVKtk2s3mLbMtQ5MR81rwXSsACfwbdHjem2OQp70QycteK6ks41TzoLhz4DPhZc0Hsyw==</DQ><InverseQ>mf4F9oKUFCRgt5PrEcr6BB1yscmfngvip2N232ycIBayKjzICGBFe49Tp1+ycIZfxKMFNPrhz52dWLTvHbBn9g==</InverseQ><D>mSmMlSp0LKFcH1iMuDNPnmzn5KQ/BQgimtF/QkCAJw8wpU5U6lD4KaH7odDKBneS510jZm9TLqj1hs9hFWvFmnl2rpN34ohPE+GOWVIZ1FBTtncPr+d1AWGyeNL3oDFjkI/1mFTwAtlpQIgM6bjUG2XHQIaQir1a2p3SqytG4hE=</D></RSAKeyValue>";
				string publicKey = "<RSAKeyValue><Modulus>umejTBIzSxQqiWfnGAldP2AVNCNCaaT2NLqPLqjtBH5HkxJL1AUqbmUoTe3d6iXml/Uo/Q8HG3iMYjsrVanK6wxqpyCPy9J7BYTDcecmY3qrbfnkQZRFeuM2mX7uXAVHA8QA0Cjpu0cm3Jg0GZ5AIrcvlXNuM/vrLjx6eYgsmW0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
	            
				try
				{

					properIT.Public.ValidateUser objBus = new properIT.Public.ValidateUser();
					strEnc = objBus.GetUser( privateKey, publicKey, strEnc );

					Session["userID"] = strEnc;
					Session["boolLogged"] = true;

					Response.Redirect( Session["lastPage"].ToString() );
					return;
				}
				catch (System.Exception ex)
				{
					BadUser();
				}

			}			

		}

		void BadUser()
		{
			this.Header1.lblPageTitle.Text="";

			this.lblLogin.Text = "Somehow it appears to be a bad log-in.<br><br>Please <a href='https://secures7.brinkster.com/dbujak/Login/Default.aspx?Project={0E452B4C-958B-4C84-919C-EEABB30EBC68}'>try again</a>.";

		}
		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    

		}
		#endregion
	}
}
