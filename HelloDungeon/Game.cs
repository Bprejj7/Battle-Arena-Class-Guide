using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {


        struct Weapon
        {
            public string Name;
            public float Damage;
            public float Durability;
            public float Weight;
        }



        struct Hero
        {
            public string Name;
            public float Health;
            public float Strength;
            public float Defense;
            public float Energy;
            public Weapon currentWeapon;
        }

        bool gameOver;
        int CurrentScene = 0;

        Hero Cole;
        Hero PepperMint;
        Hero Kane;
        Hero Player;



        void Start()
        {
            //Create character and weapon stats and give weapons to specific characters
            Weapon Stellar;
            Stellar.Name = ("Stellar");
            Stellar.Damage = 20;
            Stellar.Durability = 50;
            Stellar.Weight = 20;

            Weapon Wendigo;
            Wendigo.Name = ("Wendigo");
            Wendigo.Damage = 150;
            Wendigo.Durability = 100;
            Wendigo.Weight = 50;

            Hero Cole;
            Cole.Name = ("Cole");
            Cole.Health = 100;
            Cole.Strength = 20;
            Cole.Defense = 20;
            Cole.Energy = 50;
            Cole.currentWeapon = Stellar;

            Hero PepperMint;
            PepperMint.Name = ("PepperMint");
            PepperMint.Health = 200;
            PepperMint.Strength = 40;
            PepperMint.Defense = 30;
            PepperMint.Energy = 50;
            PepperMint.currentWeapon = Wendigo;

            Hero Kane;
            Kane.Name = ("Kane");
            Kane.Health = 200;
            Kane.Strength = 50;
            Kane.Defense = 50;
            Kane.Energy = 100;
            Kane.currentWeapon = Stellar;

        }

        public void run()
        {
            void PrintStats(Hero hero)
            {
                Console.WriteLine("Name: " + hero.Name);
                Console.WriteLine("Health: " + hero.Health);
                Console.WriteLine("Strength: " + hero.Defense);
                Console.WriteLine("Defense: " + hero.Energy);

                Console.Clear();
            }
        }

        void Fight()
        {
            bool IsDefending = true;
            string battleChoice = GetInput("Choose an action", "Attack", "Defend", "run");

            if (battleChoice == "1")
            {
                Kane.Health = Attack(Player, Kane);
                Console.WriteLine("You grit your teeth.");
            }
            else if (battleChoice == "2")
            {
                Console.WriteLine("You get ready to defend");
            }

            if (IsDefending = true)
            {
                Player.Defense /= 5;
            }

        }

        string GetInput(string prompt, string option1, string option2, string option3)
        {
            string playerChoice = "";

            Console.WriteLine(prompt);
            Console.WriteLine("1: " + option1);
            Console.WriteLine("2" + option2);
            Console.WriteLine("3" + option3);
            Console.Write(">");

            playerChoice = Console.ReadLine();

            return playerChoice;
        }

        void Update()
        {
            if (CurrentScene == 0)
            {
                Fight(ref Cole, ref PepperMint);

                Console.Clear();

                Fight(ref Cole, ref PepperMint);

                Console.Clear();

                Fight(ref Cole, ref PepperMint);

                void HeroSelection()
                {
                    string HeroChoice = GetInput("Choose Your Hero", Cole.Name, PepperMint.Name, Kane.Name);

                    if (HeroChoice == "1")
                    {
                        Player = Cole;
                    }
                    else if (HeroChoice == "2")
                    {
                        Player = PepperMint;
                    }
                    else if (HeroChoice == "3")
                    {
                        Player = Kane;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey(true);
                        Console.Clear();
                        return;
                    }


                }



                //update - called every time the game loops 
                //Used to update game logic like player input, character positions, game timers, etc.

                //end - called after the main game loop exits.
                //Used to clean up memory or display end game messages.

                //start - called before the first loop
                //Used tp intialize variables at the beginning of the game.
            }
        }


        void SetArrayValue(int[] arr, int index, int value)
        {
            int[] grades = new int[5] { 22, 54, 43, 78, 2 };

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }

        }

        void TotalValue(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        } 


        

        void BattleScene1()
        {

            Start();

            while (gameOver == false)
            {
                Update();
            }
        }

        void BattleScene2()
        {
            Fight(ref Cole, ref PepperMint);

            Console.Clear();

            if (Cole.Health > 0 && PepperMint.Health <= 0)
            {
                Console.WriteLine("The winner is: " + Cole.Name);
            }
            else if (PepperMint.Health > 0 && Cole.Health <= 0)
            {
                Console.WriteLine("The winner is " + PepperMint.Name);
            }
        }
    }
}