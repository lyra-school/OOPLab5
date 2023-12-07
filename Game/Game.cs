namespace Game
{
    public abstract class Game
    {
        private readonly string _name;
        private decimal _price;
        private DateTime _releaseDate;

        public string Name
        {
            get { return _name; }
        }

        protected decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public DateTime ReleaseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; }
        }

        public Game(string name, decimal price, DateTime releaseDate)
        {
            _name = name;
            _price = price;
            _releaseDate = releaseDate;
        }
        public Game(string name, decimal price) : this(name, price, DateTime.Now)
        {

        }

        public Game() : this("", 0)
        {

        }

        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {Price}\nRelease Date: {ReleaseDate}";
        }

        public abstract void UpdatePrice(decimal percentageIncrease);

    }
}