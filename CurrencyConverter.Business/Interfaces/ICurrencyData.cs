using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Business
{
    public interface ICurrencyData
    {
        object getCurrencyDenomination(decimal givenAmount, decimal price);
    }
}
