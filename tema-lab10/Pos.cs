
namespace tema_lab10
{
    class Pos
    {
        public void Plateste(IContactlessPayment card)
        {
            card.ApropieDispozitiv();
            card.EfectueazaPlata();
        } 

        public void Plateste(IContactPayment card) 
        {
            card.IntroduceCardul();
            card.EfectueazaPlata();
            card.ExtrageCardul();
        }
    }
}
