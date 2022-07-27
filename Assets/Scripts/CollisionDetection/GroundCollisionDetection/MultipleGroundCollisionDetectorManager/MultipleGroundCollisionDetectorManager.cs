using System;
using System.Collections.Generic;
using System.Linq;
using CollisionDetection.GroundCollisionDetection.BaseImplementation;
using CollisionDetection.GroundCollisionDetection.GroundCollisionDetectionManager;
using UnityEngine;

namespace CollisionDetection.GroundCollisionDetection.MultipleGroundCollisionDetectorManager
{
    public class MultipleGroundCollisionDetectorManager : GroundCollisionDetectorDetectorManager
    {
        [SerializeField] 
        private List<GroundCollisionDetectionBase> groundCollisionDetectionBases;

        public override bool IsGrounded 
        {  
            get => isGrounded;
            set => isGrounded = value;
        }
        private  bool isGrounded;
        
        public override void DetectCollision()
        {
            IsGrounded = IsDetectingGround();
        }

        private void OnEnable()
        {
            foreach (var groundCollisionDetectionBase in groundCollisionDetectionBases)
            {
                groundCollisionDetectionBase.OnGroundCollisionDetectedEvent.AddListener(OnGroundCollisionDetectedEventHandler);
            }
        }

        private void OnDisable()
        {
            foreach (var groundCollisionDetectionBase in groundCollisionDetectionBases)
            {
                groundCollisionDetectionBase.OnGroundCollisionDetectedEvent.RemoveListener(OnGroundCollisionDetectedEventHandler);
            }
        }

        private void OnGroundCollisionDetectedEventHandler(bool isGrounded)
        {
           if(isGrounded == IsGrounded) return;
           DetectCollision();
        }

        bool IsDetectingGround()
        {
            return groundCollisionDetectionBases.Any(x => x.IsGrounded);

        }
    }
}