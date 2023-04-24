using System;

namespace tema_lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Pos pos = new Pos();
            Card card = new Card();
            TelContactless telContactless = new TelContactless();
            CardContactless cardContactless = new CardContactless();

            pos.Plateste(card);
            pos.Plateste(telContactless);
            pos.Plateste(cardContactless);
        }
    }
}
