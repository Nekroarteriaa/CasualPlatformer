using Impulses.Interfaces;
using UnityEngine;

namespace Impulses.BaseImplementation.JumpImpulse
{
    public abstract class JumpImpulseBase : MonoBehaviour , IJumpImpulse
    {
        public abstract bool CanJump { get; }

       
    }
}