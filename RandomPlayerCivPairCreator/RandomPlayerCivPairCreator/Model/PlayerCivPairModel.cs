using Newtonsoft.Json;
using System.Collections.Generic;

namespace RandomPlayerCivPairCreator.Model
{
    class PlayerCivPairModel
    {
        public IList<string> Players { get; set; }
        public IList<string> Civs { get; set; }
        [JsonIgnore]
        public IDictionary<string, string> Pairs { get; set; }
    }
}
