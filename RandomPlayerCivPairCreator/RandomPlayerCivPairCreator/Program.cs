using RandomPlayerCivPairCreator.Result;
using RandomPlayerCivPairCreator.Model;
using RandomPlayerCivPairCreator.Pairing;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using RandomPlayerCivPairCreator.Input;

[assembly: InternalsVisibleTo("Test")]
namespace RandomPlayerCivPairCreator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("RandomPlayerGenerator executed.");
            InputParser inputParser = new InputParser();
            ResultHandler outputParser = new ResultHandler();
            RandomGenerator randomGenerator = new RandomGenerator();
            PairCreator pairCreator = new PairCreator(randomGenerator);

            PlayerCivPairModel model = inputParser.Parse(args[0]);
            pairCreator.Create(model);
            string result = outputParser.Parse(model);
            Console.WriteLine(result);
            File.AppendAllText(args[1], result);
        }
    }
}
