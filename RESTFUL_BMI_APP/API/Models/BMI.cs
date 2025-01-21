using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace RESTFUL_BMI.Models
{
    public class BMI
    {
        public double bmi { get; private set; }
        public String risk { get; private set; }
        public Color riskColor { get; private set; }
        public String[] externalLink { get; private set; }

        public BMI(int height, int weight)
        {
            bmi = calculateBMI(height, weight);
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
                riskColor = Color.Blue;
                risk = "You are underweight.";
            }
            else if (bmi >= 18 && bmi < 25)
            {
                riskColor = Color.Green;
                risk = "You are normal.";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                riskColor = Color.Purple;
                risk = "You are pre-obese.";
            }
            else
            {
                riskColor = Color.Red;
                risk = "You are obese.";
            }
        }

        public double calculateBMI(int height, int weight)
        {
            return (weight / Math.Pow(height, 2)) * 703;
        }
    }
}