using Newtonsoft.Json;
using RandomPlayerCivPairCreator.Input;
using RandomPlayerCivPairCreator.Model;
using RandomPlayerCivPairCreator.Pairing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace Test
{
    public class BddTests : IDisposable
    {
        private const string m_InputTestFile = @"D:\InputTestFile.json";

        public void Dispose()
        {
            if (File.Exists(m_InputTestFile))
            {
                File.Delete(m_InputTestFile);
            }
        }

        // Test_R1_UC1 - Create pairs from given players and civilizations 
        // Given 3 players and 6 civs
        // When start pairing
        // Then
        //    3 pairs are created
        //    there is no empty item in pairs
        //    there is no missing or additional player
        [Fact]
        public void Test_R1_UC1()
        {
            //Given
            PlayerCivPairModel model = CreateTestModel();
            PairCreator pairCreator = new PairCreator(new RandomGenerator());
            //When
            pairCreator.Create(model);
            //Then
            Assert.True(model.Pairs.Count == model.Players.Count, "Not all pairs created.");
            Assert.True(CheckValidVaulesOfPairs(model), "Not all civs are valid in pairs.");
            Assert.True(CheckAllPlayersIncluded(model), "Not all players are included.");
        }

        // Test_R1_UC2 - Parse the given inputfile into the model object of BusinessLogic
        //Given
        //    a JSON file name as input
        //    and the file with the following content
        //        {
        //        "Players": [
        //        "Adam",
        //        "Bela",
        //        "Cecil"
        //        ],
        //        "Civs": [
        //        "A",
        //        "B",
        //        "C",
        //        "D",
        //        "E",
        //        "F"
        //        ]
        //        }
        //When the file is parsed
        //Then all contents are loaded
        [Fact]
        public void Test_R1_UC2()
        {
            //Given
            PlayerCivPairModel initialModel = CreateTestModel();
            File.WriteAllText(m_InputTestFile, JsonConvert.SerializeObject(initialModel, Formatting.Indented));
            InputParser inputParser = new InputParser();
            //When
            PlayerCivPairModel parsedModel = inputParser.Parse(m_InputTestFile);
            //Then
            Assert.True(AreModelsEqual(initialModel, parsedModel));
        }

        #region Private
        private bool AreModelsEqual(PlayerCivPairModel initialModel, PlayerCivPairModel parsedModel)
        {
            return
                initialModel.Civs.SequenceEqual(parsedModel.Civs) &&
                initialModel.Players.SequenceEqual(parsedModel.Players) &&
                initialModel.Pairs.SequenceEqual(parsedModel.Pairs);
        }

        private static PlayerCivPairModel CreateTestModel()
        {
            return new PlayerCivPairModel()
            {
                Players = new List<string>()
                    {
                        "Adam",
                        "Bela",
                        "Cecil"
                    },
                Civs = new List<string>()
                    {
                        "A",
                        "B",
                        "C",
                        "D",
                        "E",
                        "F"
                    },
                Pairs = new Dictionary<string, string>()
            };
        }

        private bool CheckAllPlayersIncluded(PlayerCivPairModel model)
        {
            bool result = true;
            foreach (var item in model.Pairs)
            {
                if (!model.Players.Contains(item.Key))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private bool CheckValidVaulesOfPairs(PlayerCivPairModel model)
        {
            bool result = true;
            foreach (var item in model.Pairs)
            {
                if (!model.Civs.Contains(item.Value))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        #endregion Private
    }
}
