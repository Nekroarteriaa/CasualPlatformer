using NoCallbackVariables.Vector3Variable;
using UnityEngine;

namespace Animation.MovementAnimation
{
    public class HorizontalMovementAnimationController : MonoBehaviour
    {
        [SerializeField] 
        private Animator animator;

        [SerializeField]
        private SpriteRenderer spriteRenderer;

        [SerializeField] 
        private Vector3NoCallbackVariable movementVector3Variable;

        [SerializeField]
        private string animatorMovementParameterName;

        private void FixedUpdate()
        {
            if(movementVector3Variable == null) return;
            if (movementVector3Variable.Value.x != 0)
            {
                spriteRenderer.flipX = !(movementVector3Variable.Value.x > 0);
                animator.SetBool(animatorMovementParameterName, true);
            }
            else
            {
                animator.SetBool(animatorMovementParameterName, false);
            }
        }
    }
}