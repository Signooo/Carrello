using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrello
{
    internal class ProdottoInformatico:Prodotto
    {
        public ProdottoInformatico(string marca, string modello, string identificativo, double prezzo) : base(marca, modello, identificativo, prezzo)
        {
            PrezzoEffettivo = CalcolaPrezzo();
        }
        override public double CalcolaPrezzo()
        {
            return Prezzo - Prezzo * 10 / 100;
        }
    }
}
