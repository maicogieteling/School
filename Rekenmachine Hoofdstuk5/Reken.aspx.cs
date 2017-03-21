using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rekenmachine_Hoofdstuk5
{
    public partial class Reken : System.Web.UI.Page
    {

        decimal get1;
        decimal get2;
        decimal uitkomst;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOptel_Click(object sender, EventArgs e)
        {


            get1 = Convert.ToDecimal(txtGetal1.Text);
            get2 = Convert.ToDecimal(txtGetal2.Text);
            uitkomst = get1 + get2;
            txtUitkomst.Text = Convert.ToString(uitkomst);
        }

        protected void btnAftrek_Click(object sender, EventArgs e)
        {

            get1 = Convert.ToDecimal(txtGetal1.Text);
            get2 = Convert.ToDecimal(txtGetal2.Text);
            uitkomst = get1 - get2;
            txtUitkomst.Text = Convert.ToString(uitkomst);
        }

        protected void txtGetal1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}