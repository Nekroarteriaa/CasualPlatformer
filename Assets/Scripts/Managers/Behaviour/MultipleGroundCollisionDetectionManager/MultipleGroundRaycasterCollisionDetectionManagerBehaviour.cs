using System.Collections.Generic;
using System.Linq;
using Collisions.Controller.GroundCollisionDetection.GroundCollisionDetectionBase;
using Managers.Behaviour.GroundCollisionDetectionManager;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Managers.Behaviour.MultipleGroundCollisionDetectionManager
{
    public class MultipleGroundRaycasterCollisionDetectionManagerBehaviour : GroundRaycasterCollisionDetectionManagerBehaviour
    {
        [SerializeField] 
        private BoolVariable groundCollisionDetectorBoolVariable;
        [SerializeField] 
        private List<GroundRaycasterCollisionDetectionControllerBase> groundCollisionDetectionControllerBases;


        public override bool IsGrounded 
        {  
            get => isGrounded;
            set => isGrounded = value;
        }
        
        private bool isGrounded;
        
        
        public override void DetectCollision()
        {
           IsGrounded = IsDetectingGround();
           groundCollisionDetectorBoolVariable.Value = IsGrounded;
        }
        
        private void OnEnable()
        {
            foreach (var groundDetectorScriptableVariableBool in groundCollisionDetectionControllerBases)
            {
                groundDetectorScriptableVariableBool.OnGroundCollisionDetected.AddListener(OnGroundCollisionDetectedEventHandler);
            }
        }
        
        private void OnDisable()
        {
            foreach (var groundDetectorScriptableVariableBool in groundCollisionDetectionControllerBases)
            {
                groundDetectorScriptableVariableBool.OnGroundCollisionDetected.RemoveListener(OnGroundCollisionDetectedEventHandler);
            }
        }
        
        private void OnGroundCollisionDetectedEventHandler(bool isGrounded)
        {
           if(isGrounded == IsGrounded) return;
           DetectCollision();
        }
        
        private bool IsDetectingGround()
        {
            return groundCollisionDetectionControllerBases.Any(x => x.IsGrounded);
        }
        
    }
}