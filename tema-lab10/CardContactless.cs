using System;
using System.Collections.Generic;
using System.Text;

namespace tema_lab10
{
    class CardContactless : IContactlessPayment
    {
        public void ApropieDispozitiv()
        {
            Console.WriteLine("Card Contactless apropiat");
        }

        public void EfectueazaPlata()
        {
            Console.WriteLine("Efectueaza plata");
        }
    }
}
