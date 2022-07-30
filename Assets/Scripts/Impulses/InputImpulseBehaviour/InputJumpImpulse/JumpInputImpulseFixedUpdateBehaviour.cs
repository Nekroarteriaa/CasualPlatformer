using Impulses.Interface.JumpImpulse;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Impulses.InputImpulseBehaviour.InputJumpImpulse
{
    public class JumpInputImpulseFixedUpdateBehaviour : MonoBehaviour ,IJumpImpulse
    {
        public bool CanJump => canJump;

        [SerializeField] 
        private BoolVariable jumpImpulseScriptableVariable;
        
        private bool canJump;

        private void FixedUpdate()
        {
            canJump = Input.GetKey(KeyCode.Space);
            if(jumpImpulseScriptableVariable == null) return;
            jumpImpulseScriptableVariable.Value = canJump;
        }
    }
}