using SuperFancyPants.Domain.Interface;

namespace SuperFancyPants.Domain
{
    public class HardMonster : IMonster
    {
        public int Health { get { return 100; } set { Health = value; } }
        public void Fight()
        {
            Health -= 25;
        }
    }
}