using UnityEngine;
using UnityEngine.Events;

namespace Impulses.Interfaces
{
    public interface IMovementImpulse
    {
        Vector3 MovementDirection { get; }
        UnityEvent<bool, Vector3> ImpulseDirection { get; }
    }
}