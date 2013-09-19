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

namespace SvLuka.Schedules
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
				// Fill combo box
				fillLocations();
				
				if ( this.lblID.Text != "0" )
				{
					// Get the data for the schedule
					string strSQL = "Select * From tblSchedules Where SC_ID=@ID";

					System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection( conStr.ConnenctionString );
					System.Data.OleDb.OleDbCommand comm = new System.Data.OleDb.OleDbCommand( strSQL, conn );
					comm.Parameters.Add( new System.Data.OleDb.OleDbParameter("@ID", this.lblID.Text ) );
					System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter( comm );
					System.Data.DataTable dt = new DataTable();
					da.Fill( dt );

					this.chkNoTime.Attributes.Add("onClick", "javascript:noTimeClicked();");
						DateTime when = Convert.ToDateTime( dt.Rows[0]["SC_Date"] );
						this.txtDate.Text = when.ToString("d");

					if ( Convert.ToBoolean( dt.Rows[0]["SC_NoTime"] ) == true )
					{
						this.chkNoTime.Checked = true;
						this.cboHour.Style["visibility"] = "hidden";
						this.cboMin.Style["visibility"] = "hidden";
                        this.cboAM.Style["visibility"] = "hidden";
					}
					else
					{
						this.chkNoTime.Checked = false;
						int hour = when.Hour;
						if ( hour > 12 )
						{
							hour = hour - 12;
							this.cboAM.SelectedValue = "PM";
						}
						else
						{
							this.cboAM.SelectedValue = "AM";
						}
						this.cboHour.SelectedValue = hour.ToString();
						this.cboMin.SelectedValue = when.Minute.ToString();					
					}
					this.txtEnglish.Text = dt.Rows[0]["SC_English"].ToString();
					this.txtCirilica.Text = dt.Rows[0]["SC_Cirilica"].ToString();
					this.txtLatinica.Text = dt.Rows[0]["SC_Latinica"].ToString();
					this.cboLocations.SelectedValue = dt.Rows[0]["SC_LC_ID_FK"].ToString();
				}
				

			}
		}

		private void fillLocations()
		{
			string strSQL = "Select * From tblDirections Order By LC_Order";

			ConnString conStr = new ConnString();
			System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter( strSQL, conStr.ConnenctionString );
			System.Data.DataTable dt = new DataTable();
			da.Fill( dt );

			foreach ( System.Data.DataRow row in dt.Rows )
			{
				this.cboLocations.Items.Add(new ListItem( row["LC_NameEng"].ToString(), row["LC_ID"].ToString() ) );
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
				strSQL = "Insert Into tblSchedules (SC_Date, SC_NoTime, SC_English, SC_Cirilica, SC_Latinica, SC_LC_ID_FK, SC_ID) " +
					"Values(@Date, @NoTime, @English, @Cirilica, @Latinica, @Location, @ID)";
				this.lblID.Text = System.Guid.NewGuid().ToString();
			}
			else
			{
				strSQL = "Update tblSchedules Set SC_Date = @Date, SC_NoTime = @NoTime, SC_English = @English, SC_Cirilica = @Cirilica, " +
					"SC_Latinica = @Latinica, SC_LC_ID_FK = @Location Where SC_ID = @ID";
			}

			System.Data.OleDb.OleDbCommand comm = new System.Data.OleDb.OleDbCommand();
			
			comm.Parameters.Add( new System.Data.OleDb.OleDbParameter( "@Date", 
				Convert.ToDateTime( this.txtDate.Text + " " + 
					this.cboHour.SelectedValue + ":" + this.cboMin.SelectedValue + " " + this.cboAM.SelectedValue ) ) );
			comm.Parameters.Add( "@NoTime", this.chkNoTime.Checked );
			comm.Parameters.Add( new System.Data.OleDb.OleDbParameter( "@English", this.txtEnglish.Text ) );
			comm.Parameters.Add( new System.Data.OleDb.OleDbParameter( "@Cirilica", this.txtCirilica.Text ) );
			comm.Parameters.Add( new System.Data.OleDb.OleDbParameter( "@Latinica", this.txtLatinica.Text ) );
			comm.Parameters.Add( new System.Data.OleDb.OleDbParameter( "@Location", this.cboLocations.SelectedValue ) );
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
