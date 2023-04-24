using System;
using System.Collections.Generic;
using System.Text;

namespace tema_lab10
{
    class Card : IContactPayment
    {
        public void IntroduceCardul()
        {
            Console.WriteLine("Introduceti cardul");
        }
        public void EfectueazaPlata()
        {
            Console.WriteLine("Efectueaza cardul");
        }

        public void ExtrageCardul()
        {
            Console.WriteLine("Extrageti cardul");
        }
    }
}
