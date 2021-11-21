namespace Inlämning3Game
{
    internal class Monster
    {
        public string? Name { get; set; }
        public int Xp { get; set; }
        public int Hp { get; set; }

        public Monster()
        {
            Name = "Beast: ";
            Hp = 100;
            Xp = 15;
        }

        public void PrintMonster()
        {
            Console.WriteLine("Type      :" + Name);
            Console.WriteLine("Level     :" + Xp);
            Console.WriteLine("Hp        :" + Hp);
        }
    }
}