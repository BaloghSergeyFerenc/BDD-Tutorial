using RandomPlayerCivPairCreator.Model;
using System;

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
            throw new Exception();
        }
    }
}
