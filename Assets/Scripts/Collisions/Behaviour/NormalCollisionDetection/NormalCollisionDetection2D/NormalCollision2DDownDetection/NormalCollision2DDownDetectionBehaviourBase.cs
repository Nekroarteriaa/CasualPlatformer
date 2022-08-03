using Collisions.Behaviour.NormalCollisionDetection.NormalCollisionDetection2D.NormalCollisionDetection2DBase;
using UnityEngine;

namespace Collisions.Behaviour.NormalCollisionDetection.NormalCollisionDetection2D.NormalCollision2DDownDetection
{
    public class NormalCollision2DDownDetectionBehaviourBase : NormalCollisionDetection2DBehaviourBase
    {
        public override void DetectNormalCollision(Vector3 normalContactPoint)
        { 
            if(normalContactPoint.y > 0)
                onDetectNormalCollision.Invoke();
        }
    }
}