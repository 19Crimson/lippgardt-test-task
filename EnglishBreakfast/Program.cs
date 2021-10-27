using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnglishBreakfast
{
    class Program
    {
        private class Mushroom
        {
            //sample class
        }

        private class Bread
        {
            //sample class
        }

        private class Egg
        {
            //sample class
        }

        private class Breakfast
        {
            //  This class contains cooked components
            private Mushroom friedMushrooms;
            private Bread friedBreadSlices;
            private Egg friedEggs;

            public Breakfast()
            {
                this.friedMushrooms = new Mushroom();
                this.friedBreadSlices = new Bread();
                this.friedEggs = new Egg();
            }

            public Breakfast(Mushroom mushrooms, Bread bread, Egg eggs)
            {
                this.friedMushrooms = mushrooms;
                this.friedBreadSlices = bread;
                this.friedEggs = eggs;
            }
        }
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting to cook breakfast!\n");            

            // Creating cooking tasks that run asynchronouslly
            var eggsTask = FryEggsAsync(2);
            var breadTask = FryBreadSlicesAsync(2);
            Mushroom cuttedMushrooms = CutMushroom(5);
            var mushroomTask = FryMushroomAsync(cuttedMushrooms); 
            var breakfastTasks = new List<Task> { mushroomTask, eggsTask, breadTask };

            // Waiting all tasks to complete
            await Task.WhenAll(breakfastTasks);

            // Recieving ready components
            var cookedMushrooms = await mushroomTask;
            var cookedBreadSlices = await breadTask;
            var cookedEggs = await eggsTask;

            // Collecting components into specific class object
            Breakfast breakfast = new Breakfast(cookedMushrooms, cookedBreadSlices, cookedEggs);

            Console.WriteLine("\nBreakfast is ready! Have a nice meal:)");
        }

        private static Mushroom CutMushroom(int amount)
        {
            for (int mushroom = 0; mushroom < amount; mushroom++)
            {
                Console.WriteLine("cutting mushroom");
            }

            return new Mushroom();
        }
        private static async Task<Mushroom> FryMushroomAsync(Mushroom mushroom)
        {
            Console.WriteLine("warming the pan for mushroom...");
            await Task.Delay(3000);
            Console.WriteLine("cooking the mushroom...");
            await Task.Delay(3000);
            Console.WriteLine("mushrooms are ready");

            return new Mushroom();
        }
        private static async Task<Egg> FryEggsAsync(int amount)
        {
            Console.WriteLine("warming the egg pan...");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {amount} eggs");
            Console.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("eggs are ready");

            return new Egg();
        }
        private static async Task<Bread> FryBreadSlicesAsync(int amount)
        {
            Console.WriteLine($"putting {amount} slices of bread in the pan");
            Console.WriteLine("cooking first side of bread slices...");
            await Task.Delay(3000);
            for (int slice = 0; slice < amount; slice++)
            {
                Console.WriteLine("flipping a slice of bread");
            }
            Console.WriteLine("cooking the second side of bread slices...");
            await Task.Delay(3000);
            Console.WriteLine("bread slices are ready");

            return new Bread();
        }
    }
}
