using BMI_WebApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace BMI_WebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.soap_BMISoapClient myClient = new ServiceReference1.soap_BMISoapClient("soap_BMISoap");

            int height = Int32.Parse(TextBox1.Text);
            int weight = Int32.Parse(TextBox2.Text);

            double bmi = myClient.getBMI(height, weight);
            TextBox3.Text = bmi.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.soap_BMISoapClient myClient = new ServiceReference1.soap_BMISoapClient("soap_BMISoap12");
            int height = Int32.Parse(TextBox1.Text);
            int weight = Int32.Parse(TextBox2.Text);
            BMI bmi = myClient.myHealth(height, weight);

            TextBox3.Text = bmi.bmi.ToString();
            TextBox4.Text = bmi.risk.ToString();
            TextBox4.ForeColor = System.Drawing.Color.FromName(bmi.riskColor);

            // Display URLs with line breaks
            string urls = bmi.externalLink[0] + Environment.NewLine +
                          bmi.externalLink[1] + Environment.NewLine +
                          bmi.externalLink[2];

            // Set the HyperLink properties
            HyperLink hyperLink1 = new HyperLink(); 
            hyperLink1.Text = bmi.externalLink[0]; 
            hyperLink1.NavigateUrl = bmi.externalLink[0];
            PlaceHolder1.Controls.Add(hyperLink1);

            HyperLink hyperLink2 = new HyperLink(); 
            hyperLink2.Text = bmi.externalLink[1]; 
            hyperLink2.NavigateUrl = bmi.externalLink[1];
            PlaceHolder2.Controls.Add(hyperLink2);

            HyperLink hyperLink3 = new HyperLink(); 
            hyperLink3.Text = bmi.externalLink[2]; 
            hyperLink3.NavigateUrl = bmi.externalLink[2]; 
            PlaceHolder3.Controls.Add(hyperLink3);

        }


        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}