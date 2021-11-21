using static Inlämning3Game.Player;

namespace Inlämning3Game
{
    public class Program
    {
        private static Monster monster = new();

        private static void Main(string[] args)
        {
            Player.Startplayer();
            StartMenu();
            Script();
        }

        public static void StartMenu()
        {
            // Huvudmeny.
            Console.WriteLine("|           MENU         |");
            Console.WriteLine("|[1]- Go on adventure    |");
            Console.WriteLine("|[2]- Player stats       |");
            Console.WriteLine("|[3]- Exit the program   |");
            Console.Write("\nEnter Choice: ");
            _ = int.TryParse(Console.ReadLine(), out int MenuChoice);

            switch (MenuChoice)
            {
                case 1:

                    Console.Clear();
                    Program.Script();

                    break;

                case 2:
                    Console.ReadLine();
                    Console.Clear();
                    player.PrintPlayer();
                    break;

                case 3:
                    Environment.Exit(0);
                    Console.WriteLine("Welcome back any time");
                    break;

                default:

                    Console.Clear();
                    StartMenu();
                    break;
            }

            Console.ReadLine();
            Console.Clear();
        }

        public static void Script()
        {
            Console.WriteLine("While on your home at nigth you hear strange sound");
            Console.WriteLine("\n[Press enter to continue]");
            Console.ReadLine();
            Console.Clear();

            bool Again = true;
            while (Again)
            {
                int enemy = new Random().Next(1, 49);
                int enemy1 = new Random().Next(2, 89);
                Console.Clear();
                monster.Hp -= enemy;
                Console.WriteLine("\nYou hit the monster, dealing {0} damage. Monster Hp {1}", enemy, monster.Hp);
                if (monster.Hp <= 0)
                {
                    player.Level += 2;
                    player.Toughness *= 2;
                    player.Hp = 200;
                    player.Xp += monster.Xp;
                    Console.WriteLine("\nYou hav Killed the Monster,gaining: {0} experience\nMonster Health: {1}", player.Xp += monster.Xp, monster.Hp);

                    Console.WriteLine("\nNew Level: {0}", player.Level);
                    player.PrintPlayer();
                    Console.WriteLine("\n[Press enter to continue]");
                    Console.ReadLine();
                    Console.Clear();
                    monster.Hp = 200;
                }
                while (player.Level == 10)
                {
                    Console.WriteLine("GAME OVER, YOU WON THE GAME");
                    Environment.Exit(0);
                }

                player.Hp -= enemy1;
                Console.WriteLine("\nBoom the monster hit you, dealing {0} damage. Your Hp {1}", enemy1, player.Hp);
                Console.WriteLine("\n[Press enter to continue]");
                Console.ReadLine();

                if (player.Hp <= 0)
                {
                    if (player.Level == -1)
                    {
                        Console.WriteLine("GAME OVER, YOU LOST THE GAME");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nYou Lost and got defeated by the Monster. player Hp{0}", player.Hp);
                        Console.WriteLine("\n[Press enter to continue]");
                        Console.ReadLine();
                        player.Level -= 1;

                        Console.WriteLine("Play (1) or Back to Menu(2)");
                        _ = int.TryParse(Console.ReadLine(), out int parts);
                        if (parts == 1)
                        {
                            player.Hp = 200;
                        }
                        else
                        {
                            player.Hp = 200;
                            StartMenu();
                        }
                    }
                }
            }
        }
    }
}