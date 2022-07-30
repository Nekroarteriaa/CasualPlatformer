using UnityEngine.Events;

namespace CollisionDetection.DamageCollisionDetection.Interface
{
    public interface IDamageCollisionDetection
    {
        UnityEvent OnDamageDetection { get; }
    }
}