using System;
using Impulses.BaseImplementation.JumpImpulse;
using UnityEngine;

namespace Impulses.InputImplementation.InputJumpImplementation
{
    public class JumpInputImpulse : JumpImpulseBase
    {
        public override bool CanJump => canJump;
        
        private bool canJump;

        private void FixedUpdate()
        {
            canJump = Input.GetKey(KeyCode.Space);
        }
    }
}