using UnityEngine;
using UnityEngine.Events;

namespace Collisions.Interface.NormalCollisionDetection
{
    public interface INormalCollisionDetection
    {
        UnityEvent OnDetectNormalCollision { get; }
        LayerMask LayerCollisionDetector { get; }
        void DetectNormalCollision(Vector3 normalContactPoint);
    }
}