namespace SuperFancyPants.Domain.Interface
{
    public interface IMonster
    {
        int Health { get; set; }

        void Fight();
    }
}