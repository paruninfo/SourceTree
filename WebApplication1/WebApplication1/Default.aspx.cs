using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void viewbutton_Click(Object sender, EventArgs e)
        {
            string name = firstname.Text;
            string org = companyname.Text;

            address.Text = name + org;

        }
    }
}