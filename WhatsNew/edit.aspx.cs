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

namespace SvLuka.WhatsNew
{
	/// <summary>
	/// Summary description for edit.
	/// </summary>
	public partial class edit : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			ConnString conStr = new ConnString();
			bool logged = conStr.isLogged( Session["boolLogged"] );

			if ( logged == false )
			{
				Response.Redirect("default.aspx");
			}

			if ( this.IsPostBack == false )
			{
				this.lblID.Text = Request["ID"].ToString();
				
				if ( this.lblID.Text != "0" )
				{
					// Get the data for the schedule
					string strSQL = "Select * From tblWhatsNew Where WN_ID=@ID";

					System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection( conStr.ConnenctionString );
					System.Data.OleDb.OleDbCommand comm = new System.Data.OleDb.OleDbCommand( strSQL, conn );
					comm.Parameters.Add( new System.Data.OleDb.OleDbParameter("@ID", this.lblID.Text ) );
					System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter( comm );
					System.Data.DataTable dt = new DataTable();
					da.Fill( dt );

					this.txtDate.Text = Convert.ToDateTime( dt.Rows[0]["WN_Date"] ).ToString("d");
					this.txtSDate.Text = Convert.ToDateTime( dt.Rows[0]["WN_SDate"] ).ToString("d");
					this.txtEDate.Text = Convert.ToDateTime( dt.Rows[0]["WN_EDate"] ).ToString("d");

					this.chkVisible.Checked = Convert.ToBoolean( dt.Rows[0]["WN_Visibile"] );
					this.txtOrder.Text = dt.Rows[0]["WN_Order"].ToString();
					this.txtEnglish.Text = dt.Rows[0]["WN_English"].ToString();
					this.txtCirilica.Text = dt.Rows[0]["WN_Cirilica"].ToString();
					this.txtLatinica.Text = dt.Rows[0]["WN_Latinica"].ToString();
				}
				

			}
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

		protected void cmdCancel_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("default.aspx");
		}

		protected void cmdSave_Click(object sender, System.EventArgs e)
		{
			if ( this.txtCirilica.Text == "" )
			{
				this.txtCirilica.Text = this.txtEnglish.Text;
			}
			if ( this.txtLatinica.Text == "" )
			{
				this.txtLatinica.Text = this.txtEnglish.Text;
			}

			string strSQL = "";

			// Check if new record or old
			if ( this.lblID.Text == "0" )
			{
				strSQL = "Insert Into tblWhatsNew (WN_Date, WN_SDate, WN_EDate, WN_English, WN_Cirilica, WN_Latinica, " +
					"WN_Visibile, WN_Order, WN_ID) " +
					"Values(@Date, @SDate, @EDate, @English, @Cirilica, @Latinica, @Active, @Order, @ID)";
				this.lblID.Text = System.Guid.NewGuid().ToString();
			}
			else
			{
				strSQL = "Update tblWhatsNew Set WN_Date = @Date, WN_SDate = @SDate, WN_EDate = @EDate, " +
					"WN_English = @English, WN_Cirilica = @Cirilica, " +
					"WN_Latinica = @Latinica, WN_Visibile = @Active, WN_Order = @Order Where WN_ID = @ID";
			}

			System.Data.OleDb.OleDbCommand comm = new System.Data.OleDb.OleDbCommand();
			
			comm.Parameters.Add( new System.Data.OleDb.OleDbParameter( "@Date", this.txtDate.Text ) );
			comm.Parameters.Add( new System.Data.OleDb.OleDbParameter( "@SDate", this.txtSDate.Text ) );
			comm.Parameters.Add( new System.Data.OleDb.OleDbParameter( "@EDate", this.txtEDate.Text ) );
			comm.Parameters.Add( new System.Data.OleDb.OleDbParameter( "@English", this.txtEnglish.Text ) );
			comm.Parameters.Add( new System.Data.OleDb.OleDbParameter( "@Cirilica", this.txtCirilica.Text ) );
			comm.Parameters.Add( new System.Data.OleDb.OleDbParameter( "@Latinica", this.txtLatinica.Text ) );
			comm.Parameters.Add( new System.Data.OleDb.OleDbParameter( "@Active", this.chkVisible.Checked ) );
			comm.Parameters.Add( new System.Data.OleDb.OleDbParameter( "@Order", this.txtOrder.Text ) );
			comm.Parameters.Add( new System.Data.OleDb.OleDbParameter( "@ID", this.lblID.Text ) );

			ConnString conStr = new ConnString();
			comm.Connection = new System.Data.OleDb.OleDbConnection( conStr.ConnenctionString );
			comm.Connection.Open();
			comm.CommandText = strSQL;
			comm.CommandType = CommandType.Text;
			comm.ExecuteNonQuery();
			comm.Connection.Close();

			Response.Redirect("default.aspx");
		}
	}
}
