using System;
using UnityEngine;

namespace Detection.Behaviour.GroundCollisionDetection.GroundCollisionDetectionShapes.Shapes2D.CircleCollisionDetectionShape2D
{
    [Serializable]
    public class CircleCollisionDetector
    {
        public Vector2 DeltaPosition;
        public float CircleRadius;
        public float CircleOffsetDistance = 0.1f;
    }
}