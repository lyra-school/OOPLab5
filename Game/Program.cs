/* Name: Lyra Karsaj
 * Date: 23/10/23
 * Desc: game class exercise
 */
namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game g1 = new Game("Monopoly", 19.99m, new DateTime(1970, 01, 31));
            // no longer works because of the protected property
            //Game g2 =  new Game() { Price = 10.99m, ReleaseDate = new DateTime(2000, 6, 15) };

            ComputerGame cg1 = new ComputerGame("Test Name", 10.99m, new DateTime(2000, 6, 15), "18");

            // DisplayGame(g1);
            DisplayGame(cg1);

        }

        static void DisplayGame(Game game)
        {
            Console.WriteLine(game.ToString());
        }
    }
}