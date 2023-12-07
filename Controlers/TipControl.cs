using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipMVS.Model;
using TipMVS.View;

namespace TipMVS.Controlers
{
    internal class TipControl
    {
        Tip myTip = new Tip();
        Display myDisplay = new Display();
        //displei input
        //otivat kum modela
        //da idat kum displeq
        public TipControl() 
        {
            myDisplay.Input();
            //ot display otivat v tip
            myTip.Amount = myDisplay.Amount;
            myTip.Percent = myDisplay.Percent;
            myDisplay.Tip=myTip.CalculateTip();
            myDisplay.Total = myTip.CalculateTotal();
            myDisplay.Output();
        }
    }
}
