using System.Collections.Generic;
using System.Linq;
using Collisions.Controller.RaycastCollisionDetectionBase;
using Managers.Behaviour.RaycastCollisionDetectionManager;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Managers.Behaviour.MultipleRaycastCollisionDetectionManager
{
    public class MultipleRaycasterCollisionDetectionManagerBehaviour : RaycasterCollisionDetectionManagerBehaviour
    {
        [SerializeField] 
        private BoolVariable collisionDetectorBoolVariable;
        [SerializeField] 
        private List<RaycasterCollisionDetectionControllerBase> collisionDetectionControllerBases;
        
        private RaycasterCollisionDetectionControllerBase hittedRaycast;
        
        public override bool HasBeenHitted 
        {  
            get => hasBeenHitted;
            set => hasBeenHitted = value;
        }
        
        private bool hasBeenHitted;
        
        
        public override void DetectCollision()
        {
            HasBeenHitted = IsDetectingGround();
            collisionDetectorBoolVariable.Value = HasBeenHitted;
        }
        
        private void OnEnable()
        {
            foreach (var groundDetectorScriptableVariableBool in collisionDetectionControllerBases)
            {
                groundDetectorScriptableVariableBool.OnCollisionDetected.AddListener(OnCollisionDetectedHandler);
            }
        }
        
        private void OnDisable()
        {
            foreach (var groundDetectorScriptableVariableBool in collisionDetectionControllerBases)
            {
                groundDetectorScriptableVariableBool.OnCollisionDetected.RemoveListener(OnCollisionDetectedHandler);
            }
        }
        
        private void OnCollisionDetectedHandler(bool hasDetectACollision)
        {
           if(hasDetectACollision == HasBeenHitted) return;
           DetectCollision();
        }
        
        private bool IsDetectingGround()
        {
            return collisionDetectionControllerBases.Any(x => x.HasBeenHitted);
        }
        
    }
}
