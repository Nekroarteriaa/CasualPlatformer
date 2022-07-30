using UnityEngine;
using UnityEngine.Events;

namespace Impulses.Interface.MovementImpulse
{
    public interface IMovementImpulse
    {
        Vector3 MovementDirection { get; }
    }
}