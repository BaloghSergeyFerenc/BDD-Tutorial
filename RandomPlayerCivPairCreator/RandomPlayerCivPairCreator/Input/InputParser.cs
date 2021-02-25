using Newtonsoft.Json;
using RandomPlayerCivPairCreator.Model;
using System.Collections.Generic;
using System.IO;

namespace RandomPlayerCivPairCreator.Input
{
    class InputParser
    {
        public PlayerCivPairModel Parse(string input)
        {
            PlayerCivPairModel playerCivPairModel = JsonConvert.DeserializeObject<PlayerCivPairModel>(File.ReadAllText(input));
            playerCivPairModel.Pairs = new Dictionary<string, string>();
            return playerCivPairModel;
        }
    }
}
