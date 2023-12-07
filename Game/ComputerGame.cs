namespace Game
{
    public class ComputerGame : Game
    {
        private string _pegi;

        public string PEGI
        {
            get { return _pegi; }
            set { _pegi = value; }
        }

        public ComputerGame(string name, decimal price, DateTime releaseDate, string pegi) : base(name, price, releaseDate)
        {
            _pegi = pegi;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {Price}\nRelease Date: {ReleaseDate}\nPEGI Rating: {PEGI}";
        }
        public decimal GetDiscountPrice()
        {
            return Price * .9m;
        }

        public void UpdatePrice(decimal percentageIncrease)
        {
            Price *= (1 + percentageIncrease);

            Console.WriteLine("This computer game's price is updated");
        }
    }
}