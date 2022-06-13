using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billeteras
{
    public class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }


        public decimal Total()
        {
            decimal total = BilletesDe10*10 + BilletesDe100*100 + BilletesDe20*20 + BilletesDe50*50 + BilletesDe500*500 + BilletesDe1000*1000;
            return total;
        }

        public Billetera Combinar(Billetera b1, Billetera b2)
        {
            Billetera b3 = new Billetera()
            {
                BilletesDe10 = b1.BilletesDe10 + b2.BilletesDe10,
                BilletesDe20 = b1.BilletesDe20 + b2.BilletesDe20,
                BilletesDe100 = b1.BilletesDe100 + b2.BilletesDe100,
                BilletesDe500 = b1.BilletesDe500 + b2.BilletesDe500,
                BilletesDe50 = b1.BilletesDe50 + b2.BilletesDe50,
                BilletesDe1000 = b1.BilletesDe1000 + b2.BilletesDe1000,
            };

            b1.BilletesDe10 = 0;
            b1.BilletesDe20 = 0;
            b1.BilletesDe50 = 0;
            b1.BilletesDe100 = 0;
            b1.BilletesDe500 = 0;
            b1.BilletesDe1000 = 0;



            b2.BilletesDe10 = 0;
            b2.BilletesDe20 = 0;
            b2.BilletesDe50 = 0;
            b2.BilletesDe100 = 0;
            b2.BilletesDe500 = 0;
            b2.BilletesDe1000 = 0;



            return b3;
        }


    }
}
