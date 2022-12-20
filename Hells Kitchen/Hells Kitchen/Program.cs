using Hells_Kitchen.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Hells_Kitchen
{
    class Program
    {

        public static bool ingredientExists(RawMaterial rawMaterial, Dictionary<RawMaterial,int> keyValuePairs)
        {
            bool x = false;
            foreach (RawMaterial r in keyValuePairs.Keys)
                if (r.name == rawMaterial.name)
                {
                    x = true;
                    break;
                }
            return x;
        }

        public static int ingredientposition(RawMaterial rawMaterial, Dictionary<RawMaterial, int> keyValuePairs)
        {
            int x = 0;
            foreach (var r in keyValuePairs)
            {
                
                if (r.Key.name == rawMaterial.name)
                {

                    return x;
                }

                x++;
            }
            return -1;
        }

        public static bool canMakeThisDish(Dictionary<RawMaterial,int> playerIngred, Recipe recipe)
        {
            bool can = true;
            foreach(var x in recipe.ingredients)
            {
                if (ingredientposition(x.Key, playerIngred) != -1)
                {
                    if (playerIngred.ElementAt(ingredientposition(x.Key, playerIngred)).Value < x.Value)
                        
                        can = false;
                }
                else
                    can = false;
            }

            return can;
        }

        public static void MakeThisDish(Player player, Recipe recipe)
        {
            int posingr;

            foreach (var x in recipe.ingredients)
            {
                posingr = ingredientposition(x.Key, player.ingredientsgiven);

                int value = player.ingredientsgiven.ElementAt(ingredientposition(x.Key, player.ingredientsgiven)).Value - x.Value;
                player.ingredientsgiven[player.ingredientsgiven.ElementAt(ingredientposition(x.Key, player.ingredientsgiven)).Key]=value;

               
            }
            player.numberOfDishesDone++;
        }


        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Spice pepper = new Spice();
            pepper.name = "pepper";
            pepper.unitMeasure = "g";
          
            Spice salt = new Spice("salt", "g");
            Spice blackPepper = new Spice("blackPepper", "g");
            Spice chickenSpice = new Spice("chickenSpice", "g");
            Spice fishSpice = new Spice("fishSpice", "g");
            Spice burgerSpice = new Spice("burgerSpice", "g");
            Spice beefSpice = new Spice("beefSpice", "g");
            Spice mayonnaise = new Spice("mayonnaise", "g");
            Spice ketchup = new Spice("ketchup", "g");
            Spice Turmeric = new Spice("Turmeric", "g");
            Spice cumin = new Spice("cumin", "g");
            Spice kapsaSpice = new Spice("kapsaSpice", "g");
            Spice caveSheet = new Spice("Cave sheet", "g");
            Spice pepperspice = new Spice("pepper spice", "g");
            Spice pigFat = new Spice("Pig fat", "g");


            Vegetable potatoe = new Vegetable("potatoe", "kg");
            Vegetable tomato = new Vegetable("tomato", "g");
            Vegetable onion = new Vegetable("onion", "g");
            Vegetable lettuce = new Vegetable("lettuce", "g");
         
            Vegetable sweetPepper = new Vegetable("sweetPepper", "g");
            
            Vegetable garlic = new Vegetable("garlic", "g");
            Vegetable limon = new Vegetable("limon", "g");
            Vegetable Eggplant = new Vegetable("Eggplant", "g");
            Vegetable carrot = new Vegetable("carrot", "g");
            Vegetable turnip = new Vegetable("turnip", "g"); 
            Vegetable celery = new Vegetable("celery", "g"); 



            Meat chickenBreasts = new Meat("chickenBreasts", "g");
            Meat chicken = new Meat("chicken", "g");
            Meat beef = new Meat("beef", "g");
            Meat burgerPieces = new Meat("burgerPieces", "g");
            Meat fish = new Meat("fish", "g");


            otherIngredient pasta = new otherIngredient("pasta", "g");
            otherIngredient tomatoPasta = new otherIngredient("tomatoPasta", "g");
            otherIngredient rice = new otherIngredient("rice", "g");
            otherIngredient oil = new otherIngredient("oil", "ml");
            otherIngredient bread = new otherIngredient("bread", "g");
            otherIngredient tunisianKoskos = new otherIngredient("tunisianKoskos", "g");
        

            Recipe pastaWithSauce = new Recipe();
            pastaWithSauce.name = "Pasta with Sauce";
            Dictionary<RawMaterial, int> pastaingredients = new Dictionary<RawMaterial, int>();
            pastaingredients.Add(pasta, 500);
            pastaingredients.Add(onion, 100);
            pastaingredients.Add(sweetPepper, 1);
            pastaingredients.Add(tomatoPasta, 200);
            pastaingredients.Add(salt, 5);
            pastaingredients.Add(blackPepper, 5);

            pastaWithSauce.ingredients = pastaingredients;

            Dictionary<RawMaterial, int> chickenWithRiceingredients = new Dictionary<RawMaterial, int>();
            chickenWithRiceingredients.Add(rice, 500);
            chickenWithRiceingredients.Add(onion, 100);
            chickenWithRiceingredients.Add(chickenBreasts, 250);
            chickenWithRiceingredients.Add(chickenSpice, 20);
            chickenWithRiceingredients.Add(tomato, 200);
            chickenWithRiceingredients.Add(salt, 10);
            chickenWithRiceingredients.Add(oil, 5);

            Recipe chickenWithRice = new Recipe("Chicken With Rice", chickenWithRiceingredients);


            Dictionary<RawMaterial, int> grilledFishingredients = new Dictionary<RawMaterial, int>();
            grilledFishingredients.Add(fish, 500);
            grilledFishingredients.Add(onion, 100);
            grilledFishingredients.Add(tomato, 100);
            grilledFishingredients.Add(salt, 10);
            grilledFishingredients.Add(oil, 5);
            grilledFishingredients.Add(cumin, 15);
            grilledFishingredients.Add(Turmeric, 10);

            Recipe grilledFish = new Recipe("Grilled Fish", grilledFishingredients);


            Dictionary<RawMaterial, int> riceAndBeefingredients = new Dictionary<RawMaterial, int>();
            riceAndBeefingredients.Add(rice, 500);
            riceAndBeefingredients.Add(onion, 100);
            riceAndBeefingredients.Add(beef, 150);
            riceAndBeefingredients.Add(beefSpice, 20);
            riceAndBeefingredients.Add(salt, 10);
            riceAndBeefingredients.Add(oil, 5);

            Recipe riceAndBeef = new Recipe("Rice And Beef", riceAndBeefingredients);


            Dictionary<RawMaterial, int> burgeringredients = new Dictionary<RawMaterial, int>();
            burgeringredients.Add(bread, 1);
            burgeringredients.Add(lettuce, 100);
            burgeringredients.Add(mayonnaise, 10);
            burgeringredients.Add(ketchup, 10);
            burgeringredients.Add(salt, 10);
            burgeringredients.Add(oil, 10);
            burgeringredients.Add(onion, 50);
            burgeringredients.Add(blackPepper, 5);

            Recipe burger = new Recipe("Burger", burgeringredients);

            Dictionary<RawMaterial, int> fishSoupingredients = new Dictionary<RawMaterial, int>();
            fishSoupingredients.Add(fish, 100);
            fishSoupingredients.Add(garlic, 10);
            fishSoupingredients.Add(fishSpice, 10);
            fishSoupingredients.Add(limon, 20);
            fishSoupingredients.Add(salt, 10);
            fishSoupingredients.Add(oil, 10);
            fishSoupingredients.Add(onion, 50);
            fishSoupingredients.Add(pepper, 5);

            Recipe fishSoup = new Recipe("Fish Soup", fishSoupingredients);


            Dictionary<RawMaterial, int> maklobaingredients = new Dictionary<RawMaterial, int>();
            maklobaingredients.Add(rice, 500);
            maklobaingredients.Add(onion, 100);
            maklobaingredients.Add(chickenBreasts, 250);
            maklobaingredients.Add(chickenSpice, 10);
            maklobaingredients.Add(Eggplant, 50);
            maklobaingredients.Add(potatoe, 150);
            maklobaingredients.Add(blackPepper, 10);
            maklobaingredients.Add(tomato, 200);
            maklobaingredients.Add(salt, 10);
            maklobaingredients.Add(oil, 5);

            Recipe makloba = new Recipe("Makloba", maklobaingredients);


            Dictionary<RawMaterial, int> kabssaingredients = new Dictionary<RawMaterial, int>();
            kabssaingredients.Add(rice, 500);
            kabssaingredients.Add(kapsaSpice, 50);
            kabssaingredients.Add(blackPepper, 10);
            kabssaingredients.Add(salt, 10);
            kabssaingredients.Add(oil, 5);

            Recipe kabessa = new Recipe("Kabessa ", kabssaingredients);


            Dictionary<RawMaterial, int> tunisianKuskussingredients = new Dictionary<RawMaterial, int>();
            tunisianKuskussingredients.Add(tunisianKoskos, 500);
            tunisianKuskussingredients.Add(onion, 100);
            tunisianKuskussingredients.Add(beef, 250);
            tunisianKuskussingredients.Add(potatoe, 200);
            tunisianKuskussingredients.Add(blackPepper, 10);
            tunisianKuskussingredients.Add(tomato, 200);
            tunisianKuskussingredients.Add(salt, 10);
            tunisianKuskussingredients.Add(oil, 5);

            Recipe tunisianKuskuss = new Recipe("Tunisian Kuskuss", tunisianKuskussingredients);

            Dictionary<RawMaterial, int> palestinianFattahingredients = new Dictionary<RawMaterial, int>();
            palestinianFattahingredients.Add(rice, 500);
            palestinianFattahingredients.Add(chickenBreasts, 250);
            palestinianFattahingredients.Add(kapsaSpice, 50);
            palestinianFattahingredients.Add(pepper, 100);
            palestinianFattahingredients.Add(limon, 40);
            palestinianFattahingredients.Add(salt, 10);
            palestinianFattahingredients.Add(oil, 5);
            palestinianFattahingredients.Add(onion, 70);
            palestinianFattahingredients.Add(caveSheet, 10);

            Recipe palestinianFattah = new Recipe("Palestinian Fattah", palestinianFattahingredients);





            Dictionary<RawMaterial, int> golyasLevesingredients = new Dictionary<RawMaterial, int>();
            golyasLevesingredients.Add(beef, 500);
            golyasLevesingredients.Add(carrot, 250);
            golyasLevesingredients.Add(onion, 50);
            golyasLevesingredients.Add(turnip, 100);
            golyasLevesingredients.Add(celery, 10);
            golyasLevesingredients.Add(salt, 10);
            golyasLevesingredients.Add(potatoe, 300);
            golyasLevesingredients.Add(pepperspice, 40);
            golyasLevesingredients.Add(pepper, 70);
            golyasLevesingredients.Add(caveSheet, 10);
            golyasLevesingredients.Add(tomato, 70);
            golyasLevesingredients.Add(garlic, 10);
            golyasLevesingredients.Add(pigFat, 50); 

            Recipe gulyàsleves = new Recipe("gulyàsleves", golyasLevesingredients);

            Dictionary<RawMaterial, int> riceSimpleingredients = new Dictionary<RawMaterial, int>();
            riceSimpleingredients.Add(rice, 200);
            riceSimpleingredients.Add(oil, 100);
            riceSimpleingredients.Add(salt, 10);


            Recipe riceSimple = new Recipe("rice Simple", riceSimpleingredients);

            Dictionary<Recipe, int> recipes = new Dictionary<Recipe, int>();
            recipes.Add(gulyàsleves,13);
            recipes.Add(kabessa,5);
            recipes.Add(palestinianFattah,9);
            recipes.Add(burger,8);
            recipes.Add(fishSoup,8);
            recipes.Add(grilledFish,7);
            recipes.Add(pastaWithSauce,6);
            recipes.Add(makloba,10);
            recipes.Add(tunisianKuskuss,8);
            recipes.Add(riceAndBeef,6);
            recipes.Add(chickenWithRice,7);
            recipes.Add(riceSimple, 3);



            Team teamA = new Team('A');
            Team teamB = new Team('B');

            int i,recipesNumber= recipes.Count, position =0 ;
            Random random = new Random();
            int nb = random.Next(1, recipesNumber);
            Player player1A = new Player("Mahmmud", 'A');
            for (i = 1; i <= nb; i++)
            {
                position = random.Next(1, recipesNumber);
                if(player1A.knownRecipes.Contains(recipes.Keys.ElementAt(position)))
                    {
                    i--;
                }
                else
                player1A.knownRecipes.Add(recipes.Keys.ElementAt(position));
            }
            Console.WriteLine("***************************************************");
 
            Console.WriteLine(player1A.name + " knows how to cook " + nb + " dishes :");
          
            foreach (Recipe r in player1A.knownRecipes)
            {
                Console.WriteLine("- " + r.name);
            }

            nb = random.Next(1, recipesNumber);
            Player player2A = new Player("Mark", 'A');
            for (i = 1; i <= nb; i++)
            {
                position = random.Next(1, recipesNumber);
                if (player2A.knownRecipes.Contains(recipes.Keys.ElementAt(position)))
                {
                    i--;
                }
                else
                    player2A.knownRecipes.Add(recipes.Keys.ElementAt(position));
            }
            Console.WriteLine("");
            Console.WriteLine("***************************************************");
            Console.WriteLine(player2A.name+" knows how to cook " + nb + " dishes:");
            
            foreach (Recipe r in player2A.knownRecipes)
            {
                Console.WriteLine("- "+r.name);

            }



            teamA.teamPlayers.Add(player1A);
            teamA.teamPlayers.Add(player2A);


            nb = random.Next(1, recipesNumber);
            Player player1B = new Player("Marton", 'B');
            for (i = 1; i <= nb; i++)
            {
                position = random.Next(1, recipesNumber);
                if (player1B.knownRecipes.Contains(recipes.Keys.ElementAt(position)))
                {
                    i--;
                }
                else
                    player1B.knownRecipes.Add(recipes.Keys.ElementAt(position));
            }
            Console.WriteLine("");
            Console.WriteLine("***************************************************");
            Console.WriteLine(player1B.name + " knows how to cook " + nb + " dishes:");

            foreach (Recipe r in player1B.knownRecipes)
            {
                Console.WriteLine("- " + r.name);

            }


            nb = random.Next(1, recipesNumber);
            Player player2B = new Player("Robert", 'B');
            for (i = 1; i <= nb; i++)
            {
                position = random.Next(1, recipesNumber);
                if (player2B.knownRecipes.Contains(recipes.Keys.ElementAt(position)))
                {
                    i--;
                }
                else
                    player2B.knownRecipes.Add(recipes.Keys.ElementAt(position));
            }
            Console.WriteLine("");
            Console.WriteLine("***************************************************");
            Console.WriteLine(player2B.name + " knows how to cook " + nb + " dishes:");

            foreach (Recipe r in player2B.knownRecipes)
            {
                Console.WriteLine("- " + r.name);

            }

            teamB.teamPlayers.Add(player1B);
            teamB.teamPlayers.Add(player2B);


            int quantityIngredients = random.Next(4000, 6000);
            quantityIngredients -= 3250;

            List<Player> players = new List<Player>();
            players.Add(player1A);
            players.Add(player1B);
            players.Add(player2A);
            players.Add(player2B);

            foreach (Player player in players)
            {


                player.ingredientsgiven.Add(oil, 400);
              
                player.ingredientsgiven.Add(onion, 400);
               
                player.ingredientsgiven.Add(salt, 50);
           
                player.ingredientsgiven.Add(tomato, 400);
               
                player.ingredientsgiven.Add(rice, 2000);


                int ingredientsNumber = RawMaterial.ingredientsList.Count;
                int tmpqty = 0;
                int playerqty = quantityIngredients;
                nb = random.Next(1, ingredientsNumber);
                bool allQtyused = false;
                for (i = 1; i <= nb && allQtyused == false; i++)
                {
                    position = random.Next(1, ingredientsNumber);


                    if (ingredientExists(RawMaterial.ingredientsList.ElementAt(position), player.ingredientsgiven))
                    {
                        i--;
                    }
                    else if (nb == i)
                    {

                        player.ingredientsgiven.Add(RawMaterial.ingredientsList.ElementAt(position), playerqty);
                        playerqty = 0;
                    }
                    else
                    {
                        if (RawMaterial.ingredientsList.ElementAt(position).GetType().FullName == (typeof(Spice).FullName))
                        {
                            if (playerqty >= 50)
                                tmpqty = random.Next(1, 50);
                            else tmpqty = random.Next(1, playerqty);
                        }
                        else
                            tmpqty = random.Next(1, playerqty);
                        playerqty -= tmpqty;
                        player.ingredientsgiven.Add(RawMaterial.ingredientsList.ElementAt(position), tmpqty);

                    }

                    if (playerqty == 0)
                        allQtyused = true;
                }
                Console.WriteLine("*****************************");
                Console.WriteLine(player.name+" given ingredients are :");
                int tot = 0;
                foreach (var r in player.ingredientsgiven)
                {
                    tot += r.Value;
                    Console.WriteLine("---"+r.Key.name + " : " + r.Value);
                }

                // Console.WriteLine(quantityIngredients + 3250);
                //  Console.WriteLine(tot);
           

                foreach (var r in player.knownRecipes)
                {
                    if (canMakeThisDish(player.ingredientsgiven, r))
                    {
                        MakeThisDish(player, r);
                        Console.WriteLine("--------"+player.name + " made this dish :" + r.name);
                    }
                }
                Console.WriteLine("___________________________");
                Console.WriteLine(player.name + " made :" + player.numberOfDishesDone+ " dishes in total");
                Console.WriteLine("___________________________");


            }
            Console.WriteLine("___________________________");
            if (player1A.numberOfDishesDone + player1B.numberOfDishesDone > player2A.numberOfDishesDone + player2B.numberOfDishesDone)
                Console.WriteLine("Team A won");
            else if(player1A.numberOfDishesDone + player1B.numberOfDishesDone == player2A.numberOfDishesDone + player2B.numberOfDishesDone)
                Console.WriteLine("Team A and Team B Draw");
            else
                Console.WriteLine("Team B won");


            Console.Write("Press any key to continue");
            Console.ReadKey();

        }
    }
}
