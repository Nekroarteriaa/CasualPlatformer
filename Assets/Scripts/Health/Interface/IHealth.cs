using UnityEngine.Events;

namespace Health.Interface
{
    public interface IHealth
    {
        int CurrentHealth { get; }
        int MaxHealth { get; }

        UnityEvent OnRunOutOfLife { get; }
    }
}