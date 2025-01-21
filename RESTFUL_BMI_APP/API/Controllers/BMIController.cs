using RESTFUL_BMI.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace RESTFUL_BMI.Controllers
{
    public class BMIController : ApiController
    {
        [HttpGet]
        [ActionName("getBMI")]
        public double myBMI(int height, int weight)
        {
            BMI bmi = new BMI(height, weight);
            return bmi.bmi;
        }

        [HttpGet]
        [ActionName("myHealth")]
        public BMI myHealth(int height, int weight)
        {
            BMI bmi = new BMI(height, weight);
            return bmi;
        }
    }
}
