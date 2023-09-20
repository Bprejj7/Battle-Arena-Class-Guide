using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
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
        Hero Grayson;
        Hero Kane;
        Hero Player;
        Hero Payne;
        Hero[] Enemies;
        int CurrentEnemyIndex = 0;

        Player PlayerCharacter;


        bool gameOver;
        int CurrentScene = 0;



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


            Enemies = new Hero[4] { Kane, Grayson, Cole, Payne };

            Cole = new Hero("Cole", 100f, 5f, 20f, Stellar);
            Grayson = new Hero("Grayson", 200f, 5f, 30f, Wendigo);
            Kane = new Hero("Kane", 200f, 10f, 50, Stellar);
            Payne = new Hero("Payne", 300f, 15f, 100f, Wendigo);
        }

        void EndGameScene()
        {
            string playerChoice = PlayerCharacter.GetInput("You Died. Play Again?", "Yes", "No");

            if (playerChoice == "1") 
            {
                CurrentScene = 0;
            }
            else if (playerChoice == "2")
            {
                gameOver = true;
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

        public virtual void PrintStats(Hero hero)
        {
            Console.WriteLine("Name: " + hero.GetName());
            Console.WriteLine("Health: " + hero.GetHealth());
            Console.WriteLine("Strength: " + hero.GetDefense());
            Console.WriteLine("Defense: " + hero.GetDefense());
        }

        public void run()
        {
        }

        //Have heroes attack each other 
        void Attack(ref Hero hero1, ref Hero hero2)
        {
            hero1.GetDamage() = 5;
            hero2.GetHealth() -= hero1.GetDamage();
        }

        void HeroSelection()
        {
            PlayerCharacter = new Player();
            string HeroChoice = PlayerCharacter.GetInput("Choose Your Hero", Cole.GetName(), Grayson.GetName(), Kane.GetName(), Payne.GetName());


            Hero hero = PlayerCharacter;
            if (HeroChoice == "1")
            {
                PlayerCharacter = new Player(Cole.GetName(), Cole.GetHealth(), Cole.GetDamage(), Cole.GetDefense(), Cole.GetWeapon());
            }
            else if (HeroChoice == "2")
            {
                PlayerCharacter = new Player(Grayson.GetName(), Grayson.GetHealth(), Grayson.GetDamage(), Grayson.GetDefense(), Grayson.GetWeapon());
            }
            else if (HeroChoice == "3")
            {
                PlayerCharacter = new Player(Kane.GetName(), Kane.GetHealth(), Kane.GetDamage(), Kane.GetDefense(), Kane.GetWeapon());
            }
            else if (HeroChoice == "4")
            {
                PlayerCharacter = new Player(Payne.GetName(), Payne.GetHealth(), Payne.GetDamage(), Payne.GetDefense(), Payne.GetWeapon());
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
        void Update()
        {
            if (CurrentScene == 0)
            {
                // Fight();

                Console.Clear();

                // Fight();

                Console.Clear();

                //Fight();





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
            if (Player.GetHealth() > 0 && Enemies[CurrentEnemyIndex].GetHealth() <= 0)
            {
                Console.WriteLine("The winner is: " + Player.GetName);
            }

            //if (CurrentEnemyIndex) ;

            else if (Cole.GetHealth() > 0 && Player.GetHealth() <= 0)
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
}