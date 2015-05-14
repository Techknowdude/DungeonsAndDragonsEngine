using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace EngineMain
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Attribute> attributes = new List<Attribute>();
            Unit player = new Unit("Brandon");
            string[] attrNames = new[] { "Strength", "Constitution", "Wisdom", "Intelligence", "Dextarity", "Charisma" };

            while (true)
            {
                int totalMod = 0;
                int rolls = 0;
                bool failed = false;
                do
                {
                    failed = false;
                    attributes.Clear();
                    ++rolls;
                    Console.Clear();
                    totalMod = 0;
                    Dice d8 = new Dice(6);
                    for (int a = 0; a < 6; ++a)
                    {
                        List<int> values = new List<int>();
                        for (int i = 0; i < 4; ++i)
                        {
                            d8.Roll();
                            values.Add(d8.LastRoll);
                            Console.WriteLine(string.Format("{0} Rolled: {1}", d8, d8.LastRoll));
                        }

                        Console.WriteLine("Getting best 3 rolls...");

                        values.Remove(values.Min());

                        Attribute newAttribute = Attribute.CreateAttribute(values.Sum(), attrNames[a]);
                        attributes.Add(newAttribute);
                        Console.WriteLine(String.Format("Attribute {0}: {1} ({2})", newAttribute.Name, newAttribute.Value, newAttribute.Modifier));

                        totalMod += newAttribute.Modifier;
                        if (newAttribute.Modifier < -1)
                        {
                            failed = true;
                            a = 4;
                        }
                    }
                    Console.WriteLine(String.Format("Total mod: {0}. Rolls: {1}", totalMod, rolls));
                } while (failed || totalMod > 6 || totalMod < 2);

                Console.WriteLine(String.Format("Final Attributes"));
                foreach (Attribute attribute in attributes)
                {
                    Console.WriteLine(attribute);
                }

                player.Attributes = attributes.ToArray();

                Console.WriteLine(player);
                Console.ReadLine();
            }
        }
    }
}
