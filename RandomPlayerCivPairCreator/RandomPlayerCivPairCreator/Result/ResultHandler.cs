using Newtonsoft.Json;
using RandomPlayerCivPairCreator.Model;

namespace RandomPlayerCivPairCreator.Result
{
    class ResultHandler
    {
        public string Parse(PlayerCivPairModel model)
        {
            return JsonConvert.SerializeObject(model.Pairs, Formatting.Indented);
        }
    }
}
