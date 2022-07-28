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
        private string animatorMovementParameterName;
        
        public void IsReceivingImpulse(bool impulse,Vector3 direction)
        {
            if(impulse)
                spriteRenderer.flipX = !(direction.x > 0);
            animator.SetBool(animatorMovementParameterName, impulse);
        }

    }
}