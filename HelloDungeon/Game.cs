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

            Console.WriteLine("Pick your class player: ");

            
        }

        //End of the game
        void End()
        {
            Console.WriteLine("Thanks for playing");
        }

        internal void Run()
        {
            throw new NotImplementedException();
        }



        //update - called every time the game loops 
        //Used to update game logic like player input, character positions, game timers, etc.

        //end - called after the main game loop exits.
        //Used to clean up memory or display end game messages.

        //start - called before the first loop
        //Used tp intialize variables at the beginning of the game.



    }
}
