using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SvLuka.Donations._90Month
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["showHeader"] != null)
            {
                Month.showHeader = Convert.ToBoolean(Request.QueryString["showHeader"]);
            }
            if (Request.QueryString["showWhatIsBingAsked"] != null)
            {
                Month.showWhatIsBingAsked = Convert.ToBoolean(Request.QueryString["showWhatIsBingAsked"]);
            }
            if (Request.QueryString["showThermometer"] != null)
            {
                Month.showThermometer = Convert.ToBoolean(Request.QueryString["showThermometer"]);
            }
            if (Request.QueryString["showList"] != null)
            {
                Month.showList = Convert.ToBoolean(Request.QueryString["showList"]);
            }
            if (Request.QueryString["showBackground"] != null)
            {
                Month.showBackground = Convert.ToBoolean(Request.QueryString["showBackground"]);
            }
            if (Request.QueryString["showTheGoal"] != null)
            {
                Month.showTheGoal = Convert.ToBoolean(Request.QueryString["showTheGoal"]);
            }
            if (Request.QueryString["showWhereIsYourHeart"] != null)
            {
                Month.showWhereIsYourHeart = Convert.ToBoolean(Request.QueryString["showWhereIsYourHeart"]);
            }
            if (Request.QueryString["columnsCount"] != null)
            {
                Month.columnsCount = Convert.ToInt16(Request.QueryString["columnsCount"]);
            }

            

        }
    }
}