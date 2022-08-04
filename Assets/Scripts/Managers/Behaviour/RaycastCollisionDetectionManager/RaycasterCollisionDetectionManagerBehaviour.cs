using UnityEngine;

namespace Managers.Behaviour.RaycastCollisionDetectionManager
{
    public class RaycasterCollisionDetectionManagerBehaviour : MonoBehaviour
    {
        public virtual void DetectCollision()
        {
            
        }
        public virtual bool HasBeenHitted { get; set; }
        public void DetectRaycastCollision()
        {
            throw new System.NotImplementedException();
        }
    }
}