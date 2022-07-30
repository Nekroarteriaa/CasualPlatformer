using Managers.Interface.GroundCollisionDetectionManager;
using UnityEngine;

namespace Managers.Behaviour.GroundCollisionDetectionManager
{
    public class GroundCollisionDetectionManagerBehaviour : MonoBehaviour, IGroundCollisionDetectionManager
    {
        public virtual void DetectCollision()
        {
            
        }
        public virtual bool IsGrounded { get; set; }
    }
}