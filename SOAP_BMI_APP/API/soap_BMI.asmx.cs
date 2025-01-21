using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SOAP_BMI
{
    /// <summary>
    /// Summary description for soap_BMI
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class soap_BMI : System.Web.Services.WebService
    {

        [WebMethod]
        public double getBMI(int height, int weight)
        {
            BMI bmi = new BMI(height, weight);
            return bmi.bmi;
        }

        [WebMethod]
        public BMI myHealth(int height, int weight)
        {
            BMI bmi = new BMI(height, weight);
            return bmi;
        }

        public class BMI
        {
            public double bmi { get; set; }
            public String risk { get; set; }
            public String riskColor { get; set; } // Use string instead of Color
            public String[] externalLink { get; set; }

            // Parameterless constructor for serialization purposes
            public BMI()
            {
                // You can initialize default values if needed
                this.bmi = 0;
                this.risk = "Unknown";
                this.riskColor = "Unknown";
                this.externalLink = new string[] { };
            }

            // Constructor to calculate BMI
            public BMI(int height, int weight)
            {
                this.bmi = calculateBMI(height, weight);
                setRisk(this.bmi);
                this.externalLink = new String[] {
                    "https://www.cdc.gov/healthyweight/assessing/bmi/index.html",
                    "https://www.nhlbi.nih.gov/health/educational/lose_wt/index.htm",
                    "https://www.ucsfhealth.org/education/body_mass_index_tool/"
                };
            }

            private void setRisk(double bmi)
            {
                if (bmi < 18)
                {
                    riskColor = "Blue";
                    risk = "You are underweight.";
                }
                else if (bmi >= 18 && bmi < 25)
                {
                    riskColor = "Green";
                    risk = "You are normal.";
                }
                else if (bmi >= 25 && bmi < 30)
                {
                    riskColor = "Purple";
                    risk = "You are pre-obese.";
                }
                else
                {
                    riskColor = "Red";
                    risk = "You are obese.";
                }
            }

            public double calculateBMI(int height, int weight)
            {
                return (weight / Math.Pow(height, 2)) * 703;
            }
        }
    }
}
