using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testgit
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs args)
        {
          }

   
        protected void EnterInfoButton_OnClick(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Session["firstName"] = Server.HtmlEncode(firstNameTextBox.Text);
                Session["lastName"] = Server.HtmlEncode(lastNameTextBox.Text);
                Session["address"] = Server.HtmlEncode(addressTextBox.Text);
                Session["city"] = Server.HtmlEncode(cityTextBox.Text);
                Session["stateOrProvince"] = Server.HtmlEncode(stateOrProvinceTextBox.Text);
                Session["zipCode"] = Server.HtmlEncode(zipCodeTextBox.Text);
                Session["country"] = Server.HtmlEncode(countryTextBox.Text);

                this.Response.Redirect("WebForm2.aspx");
            }
        }

 
    }
}