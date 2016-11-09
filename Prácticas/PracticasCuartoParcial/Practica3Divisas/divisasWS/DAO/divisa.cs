using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using divisasWS.net.webservicex.www;
using System.Windows.Forms;

namespace divisasWS.DAO
{
    class divisa
    {
        double cantidad, value, resultado;

        CurrencyConvertor oCurrencyConvertor = new CurrencyConvertor();
        Currency curFrom;
        Currency curTo;
        public void calcula()
        {
            resultado = (value * cantidad);
        }
    }
}
