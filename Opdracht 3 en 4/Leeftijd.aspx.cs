using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Opdracht_3_en_4
{
    public partial class Leeftijd : System.Web.UI.Page
    {
        int dagPasen = 106;
        int dagen;
        int uren;
        int minuten;
        int seconden;

        public static int GetDaysInYear(int year)
        {
            DateTime thisYear = new DateTime(year, 1, 1);
            DateTime nextYear = new DateTime(year + 1, 1, 1);

            return (nextYear - thisYear).Days;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime vandaag = DateTime.Now;
            DateTime pasen = new DateTime(2017, 4, 16, 0, 0, 0);
            TimeSpan periode = pasen - vandaag;

            litVandaag.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");
            litTijd.Text = DateTime.Now.TimeOfDay.ToString("hh\\:mm\\:ss");
            lblUren.Text = "" + Convert.ToInt32(periode.TotalHours) + " uren";
            lblMin.Text = "" + Convert.ToInt32(periode.TotalMinutes) + " minuten";
            lblSec.Text = "" + Convert.ToInt32(periode.TotalSeconds) + " seconden";
            if (DateTime.Now.DayOfYear == dagPasen || DateTime.Now.DayOfYear == dagPasen + 1)
            {
                lblUren.Text = "Vandaag is het pasen";
                lblMin.Text = "";
                lblSec.Text = "";
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text = kalVerjaardag.SelectedDate.ToString("dd-MM-yyyy");
        }

        protected void btnLeeftijd_Click(object sender, EventArgs e)
        {
            if (kalVerjaardag.SelectedDate == DateTime.MinValue.Date)
                return;

            int age = DateTime.Now.Year - kalVerjaardag.SelectedDate.Year;

            if (DateTime.Now.Month < kalVerjaardag.SelectedDate.Month || (DateTime.Now.Month == kalVerjaardag.SelectedDate.Month && DateTime.Now.Day < kalVerjaardag.SelectedDate.Day))
                age--;

            Label2.Text = "" + age;
        }
    }
}