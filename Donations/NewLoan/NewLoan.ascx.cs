using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace SvLuka.Donations.NewLoan
{
    public partial class NewLoan1 : System.Web.UI.UserControl
    {
        public bool showHeader = true;
        public bool showWhatIsBingAsked = true;
        public bool showThermometer = true;
        public bool showList = true;
        public bool showBackground = true;
        public bool showTheGoal = true;
        public bool showWhereIsYourHeart = true;
        public int columnsCount = 4;

        private const string show = "block;";
        private const string hide = "none;";

        public string headerDisplay
        {
            get
            {
                return display(showHeader);
            }
        }

        public string whatIsBeingAskedDisplay
        {
            get
            {
                return display(showWhatIsBingAsked);
            }
        }

        public string thermometerDisplay
        {
            get
            {
                return display(showThermometer);
            }
        }

        public string listDisplay
        {
            get
            {
                return display(showList);
            }
        }

        public string backgroundDisplay
        {
            get
            {
                return display(showBackground);
            }
        }

        public string goalDisplay
        {
            get
            {
                return display(showTheGoal);
            }
        }

        public string whereIsYourHeartDisplay
        {
            get
            {
                return display(showWhereIsYourHeart);
            }
        }

        private string display(bool display)
        {
            if (display)
            {
                return show;
            }
            else
            {
                return hide;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            string strSQL = "Select * From tblDonationsNewLoan Order By Amount Desc, LastName + FirstName";

            SvLuka.ConnString Conn = new ConnString();

            DataTable DT = new DataTable();
            OleDbDataAdapter DA = new OleDbDataAdapter(strSQL, Conn.ConnenctionString);

            DA.Fill(DT);

            this.lblList.Text = "<div class='newspaper'>";

            int goal = 40000;
            int counter = 0;
            int adjustedCounter = 0;
            double amount = 0;
            int total = 0;
            string backgroundColor = "";
            foreach (System.Data.DataRow row in DT.Rows)
            {
                counter = counter + 1;
                if (amount != Convert.ToDouble(row["Amount"]))
                {
                    adjustedCounter = adjustedCounter + 1;
                    amount = Convert.ToDouble(row["Amount"]);
                }
                if (adjustedCounter % 2 == 0)
                {
                    backgroundColor = "-webkit-text-fill-color: #5B393C;";
                }
                else
                {
                    backgroundColor = "";
                }
                this.lblList.Text = this.lblList.Text + "<div counter=" + counter + " style='padding-top:10px; font-weight: bold; " + backgroundColor + "'>" + adjustedCounter.ToString() + " " + row["LastName"] + ", " + row["FirstName"];
               
                this.lblList.Text = this.lblList.Text + "</div>";
                total = total + Convert.ToInt32(row["Amount"]);

            }

            this.lblList.Text = this.lblList.Text + "</div>";

            int progressPercent = Convert.ToInt16(Convert.ToDecimal(total) / goal * 100);
            this.lblProgress.Text = @"
                <a href='https://secure.etransfer.com/SLSOC/Campaign.cfm' target=_blank border=0>
                <div class='donation-meter'>
                  <strong>Monthly Goal</strong>
                  <strong class='goal'>$" + goal.ToString("###,###") + @"</strong>
                  <span class='glass'>
                      <strong class='total' style='bottom: " + progressPercent + "%'>$" + total.ToString("###,###") + @"</strong>
                      <span class='amount' style='height: " + progressPercent + @"%'></span>
                  </span>
                  <div class='bulb'>
                      <span class='red-circle'></span>
                      <span class='filler'>
                          <span></span>
                      </span>
                  </div>
                </div>
                </a>";

            this.lblHeader.Text = HttpContext.GetGlobalResourceObject("Strings", "16_NewLoan_header").ToString();

            this.lblWhatIsBeingAsked.Text = HttpContext.GetGlobalResourceObject("Strings", "16_NewLoan_what_is_being_asked").ToString();

            this.lblListHeader.Text = HttpContext.GetGlobalResourceObject("Strings", "16_NewLoan_ListHeader").ToString();

            this.lblBackground.Text = HttpContext.GetGlobalResourceObject("Strings", "16_NewLoan_BodyText").ToString();


        }
    }
}