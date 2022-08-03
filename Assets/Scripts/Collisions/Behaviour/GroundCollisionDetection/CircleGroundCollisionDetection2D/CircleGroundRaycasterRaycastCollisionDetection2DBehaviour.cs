using Collisions.Behaviour.GroundCollisionDetection.GroundCollisionDetectionShapes.Shapes2D.CircleCollisionDetectionShape2D;
using Collisions.Interface.GroundRaycastCollisionDetection;
using UnityEngine;

namespace Collisions.Behaviour.GroundCollisionDetection.CircleGroundCollisionDetection2D
{
    public class CircleGroundRaycasterRaycastCollisionDetection2DBehaviour : IGroundRaycasterRaycastCollisionDetection
    {
        public bool IsGrounded { get; private set; }

        public RaycastHit2D hit;
        
        private Transform originPoint;
        private CircleRaycasterCollisionDetector circleRaycasterCollisionDetector;
        private LayerMask hitMask;

        public CircleGroundRaycasterRaycastCollisionDetection2DBehaviour(Transform originPoint, CircleRaycasterCollisionDetector circleRaycasterCollisionDetector, LayerMask hitMask)
        {
            this.originPoint = originPoint;
            this.circleRaycasterCollisionDetector = circleRaycasterCollisionDetector;
            this.hitMask = hitMask;
        }

        
        public void DetectRaycastCollision()
        {
            hit = Physics2D.CircleCast(originPoint.position + (Vector3)circleRaycasterCollisionDetector.DeltaPosition, circleRaycasterCollisionDetector.CircleRadius, Vector2.zero, circleRaycasterCollisionDetector.CircleOffsetDistance ,hitMask);
            IsGrounded = (hit.collider != null) ? true : false;
        }
    }
}