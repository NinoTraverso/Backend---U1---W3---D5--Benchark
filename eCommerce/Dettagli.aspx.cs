using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCommerce
{
    public partial class Dettagli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string allDetails = Request.QueryString["Description"];
                if (!string.IsNullOrEmpty(allDetails))
                {
                    
                    Details.Text = "Details: " + allDetails;
                }
                else
                {
                    Details.Text = "No details found";
                }

                
            }

        }

        
    }
}