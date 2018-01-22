using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JzEQMS
{
    public partial class EQMS : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void zdgl_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Terminal/TerminalIndex.aspx");
        }

        protected void statistics_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Statistics/StatisticsIndex.aspx");
        }
    }
}