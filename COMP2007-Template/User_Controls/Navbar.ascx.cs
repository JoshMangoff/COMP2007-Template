using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/**
 * @author: Josh Mangoff
 * @date: May 26 2016
 * @
 */

namespace COMP2007_Template
{
    public partial class Navbar : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            SetActivePage();
        }

        /**
         * This method adds css class of "active" to lis items relating to current page
         * 
         * @private
         * @
         */
        protected void SetActivePage()
        {
            switch(Page.Title)
            {
                case "Home Page":
                    home.Attributes.Add("class", "active");
                    break;
                case "Contact":
                    contact.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}