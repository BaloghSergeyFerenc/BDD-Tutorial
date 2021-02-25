using RandomPlayerCivPairCreator.Model;
using System.Collections.Generic;

namespace RandomPlayerCivPairCreator.Pairing
{
    class PairCreator
    {
        private readonly RandomGenerator m_RandomGenerator;

        public PairCreator(RandomGenerator randomGenerator)
        {
            m_RandomGenerator = randomGenerator;
        }

        public void Create(PlayerCivPairModel model)
        {
            IList<string> ageofUsers = new List<string>(model.Players);

            while (ageofUsers.Count != 0)
            {
                string player = ageofUsers[m_RandomGenerator.Generate(ageofUsers.Count)];
                string civ = model.Civs[m_RandomGenerator.Generate(model.Civs.Count)];
                model.Pairs[player] = civ;
                ageofUsers.Remove(player);
            }
        }
    }
}
