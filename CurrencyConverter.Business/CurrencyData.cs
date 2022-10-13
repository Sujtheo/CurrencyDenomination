using CurrencyConverter.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Business
{
    public class CurrencyData: ICurrencyData
    {
        public object getCurrencyDenomination(decimal givenAmount, decimal price)
        {
            int[] notes = new int[] { 500,200,100,50,20,10,5,2,1 };
            int[] noteCounter = new int[10];
            decimal balanceAmount = givenAmount - price;
            string [] balamount = balanceAmount.ToString().Split('.');
            int amount = Convert.ToInt32(balamount[0]);
            for (int i = 0; i < 9; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount % notes[i];
                }
            }
            List<string> denomination = new List<string>();
            string Note = "Your Change Is,";
            denomination.Add(Note);
            for (int i = 0; i < 9; i++)
            {
                if (noteCounter[i] != 0)
                {
                    string DenominationNote = notes[i] + " * € "
                        + noteCounter[i];
                    denomination.Add(DenominationNote);
                }
            }
            if (balamount.Count()>1 && balamount[1] != null && balamount[1] != "0")
            {
                string DenominationPaisa = "1 * "
                         + balamount[1] + "p";
                denomination.Add(DenominationPaisa);
            }       
            return denomination;

        }
    }
}
