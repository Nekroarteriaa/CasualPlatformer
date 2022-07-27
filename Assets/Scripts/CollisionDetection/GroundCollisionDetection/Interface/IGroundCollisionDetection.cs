using CollisionDetection.InterfaceBase;
using UnityEngine.Events;

namespace CollisionDetection.GroundCollisionDetection.Interface
{
    public interface IGroundCollisionDetection : ICollisionDetection
    {
        UnityEvent<bool> OnGroundCollisionDetectedEvent { get; }
        bool IsGrounded { get; set; }
    }
}