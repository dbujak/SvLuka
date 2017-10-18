using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SvLuka.Donations
{
    public partial class NewLoan2018 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Header1.lblPageTitle.Text = HttpContext.GetGlobalResourceObject("Strings", "16_NewLoan_PageTitle").ToString();

        }
    }
}