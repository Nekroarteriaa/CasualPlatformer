using Detection.Behaviour.GroundCollisionDetection.GroundCollisionDetectionShapes.Shapes2D.CircleCollisionDetectionShape2D;
using Detection.Interface.GroundCollisionDetection;
using UnityEngine;

namespace Detection.Behaviour.GroundCollisionDetection.CircleGroundCollisionDetection2D
{
    public class CircleGroundCollisionDetection2DBehaviour : IGroundCollisionDetection
    {
        public bool IsGrounded { get; private set; }

        public RaycastHit2D hit;
        
        private Transform originPoint;
        private CircleCollisionDetector circleCollisionDetector;
        private LayerMask hitMask;

        public CircleGroundCollisionDetection2DBehaviour(Transform originPoint, CircleCollisionDetector circleCollisionDetector, LayerMask hitMask)
        {
            this.originPoint = originPoint;
            this.circleCollisionDetector = circleCollisionDetector;
            this.hitMask = hitMask;
        }

        
        public void DetectCollision()
        {
            hit = Physics2D.CircleCast(originPoint.position + (Vector3)circleCollisionDetector.DeltaPosition, circleCollisionDetector.CircleRadius, Vector2.zero, circleCollisionDetector.CircleOffsetDistance ,hitMask);
            IsGrounded = (hit.collider != null) ? true : false;
        }
    }
}