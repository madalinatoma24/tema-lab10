using System;
using System.Collections.Generic;
using System.Text;

namespace tema_lab10
{
    class TelContactless : IContactlessPayment
    {
        public void ApropieDispozitiv()
        {
            Console.WriteLine("Dispozitiv apropiat");
        }

        public void EfectueazaPlata()
        {
            Console.WriteLine("Efectueaza plata");
        }
    }
}
