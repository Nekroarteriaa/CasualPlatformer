using Impulses.Interfaces;
using UnityEngine;
using UnityEngine.Events;

namespace Impulses.BaseImplementation.MovementImpulse
{
    public abstract class MovementImpulseBase : MonoBehaviour, IMovementImpulse
    {
        public abstract Vector3 MovementDirection { get; }
        public abstract UnityEvent<bool,Vector3> ImpulseDirection { get; }
    }
}