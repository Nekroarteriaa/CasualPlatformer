using CollisionDetection.GroundCollisionDetection.Interface;
using UnityEngine;

namespace CollisionDetection.GroundCollisionDetection.GroundCollisionDetectionManager
{
    public class GroundCollisionDetectorManager : MonoBehaviour, IGroundCollisionDetectorManager
    {
        public virtual void DetectCollision()
        {
            
        }
        public virtual bool IsGrounded { get; set; }
    }
}