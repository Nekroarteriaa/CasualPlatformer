using System;
using UnityEngine;

namespace Collisions.Behaviour.CollisionRaycastDetectionShapes.Shapes2D.CircleCollisionDetectionShape2D
{
    [Serializable]
    public class CircleRaycasterCollisionDetector
    {
        public Vector2 DeltaPosition;
        public float CircleRadius;
        public float CircleOffsetDistance = 0.1f;
    }
}