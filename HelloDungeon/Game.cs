using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    struct Weapon
    {
        public string Name;
        public float Damage;
        public float Durability;
        public float Weight;
    }
    class Game
    {


        Hero Cole;
        Hero PepperMint;
        Hero Kane;
        Hero Player;
        Hero[] Enemies;
        int CurrentEnemyIndex = 0;


        bool gameOver;
        int CurrentScene = 0;



        void Start()
        {
            Cole = new Hero("Kane", 100f, 5f, 20f, Stellar);
            PepperMint = new Hero("PepperMint", 200f, 5f, 30f, Wendigo);
            Kane = new Hero("Kane", 200f, 10f, 50, Stellar);

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


            Enemies = new Hero[3] { Kane, PepperMint, Cole };


        }

        void EndGameScene()
        {
            string playerChoice = GetInput("You Died. Play Again?", "Yes", "No", "");

            if (playerChoice == "1") ;
            {
                CurrentScene = 0;
            }
            else if (playerChoice == "2")
            {
            }
        }



        public void run()
        {
            void PrintStats(Hero hero)
            {
                Console.WriteLine("Name: " + hero.Name);
                Console.WriteLine("Health: " + hero.Health);
                Console.WriteLine("Strength: " + hero.Defense);
                Console.WriteLine("Defense: " + hero.GetEnergy);

                Console.Clear();
            }
        }

        //Have heroes attack each other 
        void Attack(ref Hero hero1, ref Hero hero2)
        {
            hero1.GetDamage = 5;
            hero2.GetHealth -= hero1.GetDamage;
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
                Fight();

                Console.Clear();

                Fight();

                Console.Clear();

                Fight();

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

        void WinResultsScene()
        {
            if (Player.GetHealth > 0 && Enemies[CurrentEnemyIndex].GetHealth <= 0)
            {
                Console.WriteLine("The winner is: " + Player.GetName);
            }

            if (CurrentEnemyIndex) ;

            else if (Cole.GetHealth > 0 && Player.GetHealth <= 0)
            {
                Console.WriteLine("The winner is: " + Cole.GetName);
            }
            Console.ReadKey(true);
            Console.Clear();
        }


        void SetArrayValue(int[] arr, int index, int value)
        {
            int[] grades = new int[5] { 22, 54, 43, 78, 2 };

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }

        }

        //Have an array print out the highest number.
        void HighestInt(int[] arr)
        {
            int currentNumber = 0;
            for (int count = 0; count < arr.Length; count++)
            {
                if (arr[count] <= currentNumber)
                {

                }
                else 
                {
                    currentNumber = arr[count];
                }

            }
 
            Console.WriteLine(currentNumber);
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
    }
