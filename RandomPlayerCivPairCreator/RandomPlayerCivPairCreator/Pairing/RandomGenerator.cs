using System;

namespace RandomPlayerCivPairCreator.Pairing
{
    class RandomGenerator
    {
        private readonly Random m_Random = new Random();

        public int Generate(int interval)
        {
            return m_Random.Next(interval);
        }
    }
}
