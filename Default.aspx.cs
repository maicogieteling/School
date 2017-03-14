using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnMaakKaart_Click(object sender, EventArgs e)
    {
        string Naam, Geslacht, Hobby, Opleiding;
        Naam = txtNaam.Text;
        Geslacht = rbGeslacht.SelectedValue;
        Opleiding = cbOpleiding.SelectedValue;
        Hobby = "Hobby: ";
        if (chkhobby.SelectedValue == "1"){
            Hobby += "Gamen";
        }
        if (chkhobby.SelectedValue == "2"){
            Hobby += "Programmeren";
        }
        Response.Write("Naam: " + Naam + "<br />");
        Response.Write(Hobby + "<br />");
        Response.Write("Opleiding: " + Opleiding + "<br />");
        Response.Write("Geslacht: " + Geslacht + "<br />");
    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (this.RadioButtonList1.SelectedValue == "1")
        {
            this.Panel1.Visible = true;
        }
        if (this.RadioButtonList1.SelectedValue == "2")
        {
            this.Panel1.Visible = false;
        }
    }
}