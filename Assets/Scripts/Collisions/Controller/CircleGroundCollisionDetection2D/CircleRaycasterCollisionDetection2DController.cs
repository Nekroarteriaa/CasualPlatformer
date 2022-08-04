using Collisions.Behaviour.CircleCollisionDetection2D;
using Collisions.Behaviour.CollisionRaycastDetectionShapes.Shapes2D.CircleCollisionDetectionShape2D;
using Collisions.Controller.RaycastCollisionDetectionBase;
using NoCallbackVariables.Vector3Variable;
using UnityEngine;
using UnityEngine.Events;

namespace Collisions.Controller.CircleGroundCollisionDetection2D
{
    public class CircleRaycasterCollisionDetection2DController : RaycasterCollisionDetectionControllerBase
    {
        public override UnityEvent<bool> OnCollisionDetected => onCollisionDetected;
        public override Vector3 HittedNormalPoint { get; protected set; }

        [SerializeField] 
        private Transform originPoint;
        [SerializeField]
        private CircleRaycasterCollisionDetector circleRaycasterCollisionDetector;

        [SerializeField] 
        private Vector3NoCallbackVariable hitttedNormalPoint;
        [SerializeField]
        private UnityEvent<bool> onCollisionDetected;
        
       
        

        public override bool HasBeenHitted
        {
            get => hasBeenHitted;
            protected set
            {
                if(hasBeenHitted == value) return;
                hasBeenHitted = value;
                onCollisionDetected.Invoke(value);
            }
        }


        private bool hasBeenHitted;

        private void Awake()
        {
            RaycastCollisionDetection = new CircleRaycastCollisionDetection2DBehaviour(originPoint, circleRaycasterCollisionDetector, hitMask);
        }

        private void FixedUpdate()
        {
            RaycastCollisionDetection.DetectRaycastCollision();
            HasBeenHitted = RaycastCollisionDetection.HasBeenHitted;
            HittedNormalPoint = RaycastCollisionDetection.HittedNormalPoint;
            if(hitttedNormalPoint == null || !HasBeenHitted) return;
            hitttedNormalPoint.Value = HittedNormalPoint;
        }
        
        private void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(originPoint.position + (Vector3) circleRaycasterCollisionDetector.DeltaPosition, circleRaycasterCollisionDetector.CircleRadius );
        }

        
    }
}