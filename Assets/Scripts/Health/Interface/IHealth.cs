namespace Health.Interface
{
    public interface IHealth
    {
        int CurrentHealth { get; }
        int MaxHealth { get; }
    }
}