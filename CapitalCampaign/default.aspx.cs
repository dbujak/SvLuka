using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SvLuka.CapitalCampaign
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Header1.lblPageTitle.Text = HttpContext.GetGlobalResourceObject("Strings", "100_capitalcampaign_title").ToString();


            // loop and build the page
            this.lblCapitalCampaign.Text = HttpContext.GetGlobalResourceObject("Strings", "100_capitalcampaign_page").ToString();
        }
    }
}