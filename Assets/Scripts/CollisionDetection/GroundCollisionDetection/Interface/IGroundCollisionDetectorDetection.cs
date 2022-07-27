using UnityEngine.Events;

namespace CollisionDetection.GroundCollisionDetection.Interface
{
    public interface IGroundCollisionDetectorDetection
    {
        UnityEvent<bool> OnGroundCollisionDetectedEvent { get; }
       
    }
}