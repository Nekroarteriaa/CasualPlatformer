using System;
using UnityEngine;

namespace CollisionDetection.GroundCollisionDetection.CircleImplementation
{
    [Serializable]
    public class CircleCollisionDetector
    {
        public Vector2 DeltaPosition;
        public float CircleRadius;
        public float CircleOffsetDistance = 0.1f;
    }
}