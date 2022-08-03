using UnityEngine;

namespace Managers.Behaviour.GroundCollisionDetectionManager
{
    public class GroundRaycasterCollisionDetectionManagerBehaviour : MonoBehaviour
    {
        public virtual void DetectCollision()
        {
            
        }
        public virtual bool IsGrounded { get; set; }
        public void DetectRaycastCollision()
        {
            throw new System.NotImplementedException();
        }
    }
}