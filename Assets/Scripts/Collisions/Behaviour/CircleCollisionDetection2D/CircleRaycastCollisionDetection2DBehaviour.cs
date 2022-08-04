using Collisions.Behaviour.CollisionRaycastDetectionShapes.Shapes2D.CircleCollisionDetectionShape2D;
using Collisions.Interface.RaycastCollisionDetection;
using UnityEngine;

namespace Collisions.Behaviour.CircleCollisionDetection2D
{
    public class CircleRaycastCollisionDetection2DBehaviour : IRaycastCollisionDetection
    {

        public bool HasBeenHitted => hasBeenHitted;
        public Vector3 HittedNormalPoint => hittedNormalPoint;
        public RaycastHit2D hit;
        
        private Transform originPoint;
        private CircleRaycasterCollisionDetector circleRaycasterCollisionDetector;
        private LayerMask hitMask;
        private bool hasBeenHitted;
        private Vector3 hittedNormalPoint;

        public CircleRaycastCollisionDetection2DBehaviour(Transform originPoint, CircleRaycasterCollisionDetector circleRaycasterCollisionDetector, LayerMask hitMask)
        {
            this.originPoint = originPoint;
            this.circleRaycasterCollisionDetector = circleRaycasterCollisionDetector;
            this.hitMask = hitMask;
        }



        public void DetectRaycastCollision()
        {
            hit = Physics2D.CircleCast(originPoint.position + (Vector3)circleRaycasterCollisionDetector.DeltaPosition, circleRaycasterCollisionDetector.CircleRadius, Vector2.zero, circleRaycasterCollisionDetector.CircleOffsetDistance ,hitMask);
            hasBeenHitted = (hit.collider != null) ? true : false;
            hittedNormalPoint = (hit.collider != null) ? hit.normal : default;
        }
    }
}