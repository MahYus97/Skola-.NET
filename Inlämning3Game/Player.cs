namespace Inlämning3Game
{
    public class Player
    {
        public static Player player = new Player();

        public string? Name { get; set; }
        public int Xp { get; set; }
        public int Level { get; set; }
        public int Hp { get; set; }
        public int Strenght { get; set; }
        public int Toughness { get; set; }

        public Player()
        {
            Name = "";
            Xp = 0;
            Level = 0;
            Hp = 200;
            Strenght = 20;
            Toughness = 10;
        }

        public void PrintPlayer()
        {
            Console.WriteLine("Name      :" + Name);
            Console.WriteLine("Xp        :" + Xp);
            Console.WriteLine("Level     :" + Level);
            Console.WriteLine("Hp        :" + Hp);
            Console.WriteLine("Strenght  :" + Strenght);
            Console.WriteLine("Toughness :" + Toughness);
        }

        public static void Startplayer()
        {
            Console.Write("Your name :");
            player.Name = Console.ReadLine();
            Console.WriteLine("\n[Press enter to continue]");
            Console.ReadLine();
            Console.Clear();
        }
    }
}