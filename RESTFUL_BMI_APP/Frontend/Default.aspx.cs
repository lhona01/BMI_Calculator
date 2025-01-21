using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BMI_REST_WebApp
{
    public partial class Default : System.Web.UI.Page
    {
        string baseUrl = "https://localhost:44382/api/BMI/";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void Button1_Click(object sender, EventArgs e)
        {
            int height = Int32.Parse(TextBox1.Text);
            int weight = Int32.Parse(TextBox2.Text);

            String result;
            using (HttpClient client = new HttpClient())
            {
                string url = $"{baseUrl}getBMI?height={height}&weight={weight}";
                HttpResponseMessage response = await client.GetAsync(url);
                
                result =  await response.Content.ReadAsStringAsync();
            }

            TextBox3.Text = result;
        }

        protected async void Button2_Click(object sender, EventArgs e)
        {
            int height = Int32.Parse(TextBox1.Text);
            int weight = Int32.Parse(TextBox2.Text);

            using (HttpClient client = new HttpClient())
            {
                string url = $"{baseUrl}myHealth?height={height}&weight={weight}";
                HttpResponseMessage response = await client.GetAsync(url);

                String data = await response.Content.ReadAsStringAsync();
                dynamic result = JsonConvert.DeserializeObject(data);
                TextBox3.Text = result.bmi.ToString();

                TextBox4.Text = result.risk.ToString();
                TextBox4.ForeColor = System.Drawing.Color.FromName(result.riskColor.ToString());

                HyperLink hyperLink1 = new HyperLink();
                hyperLink1.Text = result.externalLink[0];
                hyperLink1.NavigateUrl = result.externalLink[0];
                PlaceHolder1.Controls.Add(hyperLink1);

                HyperLink hyperLink2 = new HyperLink();
                hyperLink2.Text = result.externalLink[1];
                hyperLink2.NavigateUrl = result.externalLink[1];
                PlaceHolder2.Controls.Add(hyperLink2);

                HyperLink hyperLink3 = new HyperLink();
                hyperLink3.Text = result.externalLink[2];
                hyperLink3.NavigateUrl = result.externalLink[2];
                PlaceHolder3.Controls.Add(hyperLink3);
            }

        }
    }
}