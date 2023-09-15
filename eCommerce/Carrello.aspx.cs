using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCommerce
{
    public partial class Carrello : System.Web.UI.Page
    {

        public class Cart
        {

            public string Name { get; set; }

        }
    public static List<Cart> cartItems { get; set; } = new List<Cart>();
      protected void Page_Load(object sender, EventArgs e)
      {
            if (!IsPostBack)
            {
               

                string potionName = Request.QueryString["Name"];
                if (!string.IsNullOrEmpty(potionName)) 
                {

                    NameOfPotion.Text = "Name of potion: " + potionName;
                    
                }
                else
                {
                    NameOfPotion.Text = "Potion name not found...";
                }
            }

      }

        protected void Delete_Click(object sender, EventArgs e)
        {
            NameOfPotion.Visible = false;
            Button1.Visible = false;
        }



    }
}