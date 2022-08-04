using UnityEngine;

namespace Collisions.Interface.RaycastCollisionDetection
{
    public interface IRaycastCollisionDetection
    {
        public bool HasBeenHitted { get;}
        
        public Vector3 HittedNormalPoint { get;}
        
        void DetectRaycastCollision();
    }
}