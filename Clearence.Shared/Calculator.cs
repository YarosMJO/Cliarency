using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Clearence
{
    public class Calculator
    {
        public double Price { get; private set; }
        public double ExcizeDuty { get; set; }
        public double ImportDuty { get; private set; }
        public double VAT { get; private set; }
        public double FullPrice { get; set; }

        public Calculator()
        {
         
        }
        public double CalcExcizeDuty(Engine engine)
        {
            ExcizeDuty = engine.GetExcizeDuty();
            return ExcizeDuty;
        }
        public double CalcImportDuty()
        {
            ImportDuty = Price * 0.1;
            return ImportDuty;
        }

        public double CalcVAT()
        {
            VAT = (Price + ExcizeDuty +ImportDuty)*0.2;
            return VAT;
        }
        public double CalcFullPrice()
        {
            FullPrice = Price + VAT + 0.37 +ExcizeDuty+ImportDuty; //0.37?  
            return FullPrice;
        }

    }
}