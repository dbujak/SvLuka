using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SvLuka.Misc
{
    public partial class StGeorgePicnic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Header1.lblPageTitle.Text = "St. George’s Day Picnic";
        }
    }
}