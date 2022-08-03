using Collisions.Interface.NormalCollisionDetection;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Collisions.Behaviour.NormalCollisionDetection.NormalCollisionDetection2D.NormalCollisionDetection2DBase
{
    public abstract class NormalCollisionDetection2DBehaviourBase : MonoBehaviour, INormalCollisionDetection
    {
        public UnityEvent OnDetectNormalCollision => onDetectNormalCollision;

        public LayerMask LayerCollisionDetector => layerCollisionDetector;
        
        [SerializeField] 
        protected LayerMask layerCollisionDetector;

        [SerializeField] 
        protected UnityEvent onDetectNormalCollision;

        protected virtual void OnCollisionEnter2D(Collision2D col)
        {
            if (!IsHittable(col.gameObject)) return;
            DetectNormalCollision(col.contacts[0].normal);
        }
        
        public abstract void DetectNormalCollision(Vector3 normalContactPoint);

        protected bool IsHittable(GameObject hittedGameObject)
        {
            return ((layerCollisionDetector.value & (1 << hittedGameObject.layer)) > 0);
        }
    }
}