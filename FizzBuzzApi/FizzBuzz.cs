using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApi
{
    public static class FizzBuzz
    {
        public static List<string> Classic()
        {
            return CustomStartAndEnd(1, 100);
        }

        public static List<string> CustomStartAndEnd(int start, int end)
        {
            List<string> results = new List<string>();

            for (int i = start; i <= end; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    results.Add(i.ToString());
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    results.Add(i + ": FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    results.Add(i + ": Fizz");
                }
                else if (i % 5 == 0)
                {
                    results.Add(i + ": Buzz");
                }
            }

            return results;
        }

        public static List<string> CustomConfig(FizzBuzzConfig gameConfig)
        {
            List<string> results = new List<string>();

            for (int i = gameConfig.Start; i <= gameConfig.End; i++)
            {
                bool hasAtLeastOneFactor = false;
                string gameResult = i + ": ";

                foreach (int factor in gameConfig.Words.Keys)
                {
                    if (i % factor != 0)
                    {
                        continue;
                    }

                    hasAtLeastOneFactor = true;

                    gameResult += gameConfig.Words[factor];
                }

                if (hasAtLeastOneFactor == false)
                {
                    results.Add(i.ToString());
                }
                else
                {
                    results.Add(gameResult);
                }
            }

            return results;
        }
    }
}
