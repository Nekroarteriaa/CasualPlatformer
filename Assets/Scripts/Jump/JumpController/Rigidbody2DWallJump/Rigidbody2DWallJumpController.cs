using Jump.Behaviour.Rigibody2DWallJumpBehaviour;
using Jump.Behaviour.Rigidbody2DJump;
using Jump.Interface;
using NoCallbackVariables.Vector3Variable;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Jump.JumpController.Rigidbody2DWallJump
{
    public class Rigidbody2DWallJumpController : MonoBehaviour
    {
        [SerializeField] 
        private BoolReference jumpInputPlayerOneVariable;
        
        [SerializeField] 
        private BoolReference detectionManagerVariable;
        
        [SerializeField] 
        private BoolReference groundedDetectionManagerVariable;
        
        [SerializeField]
        private Rigidbody2D rigidbody2D;

        [SerializeField]
        private Vector3NoCallbackVariable currentHittedWallNormalDirection;


        [SerializeField] [Range(0f,1f)] 
        private float jumpRecoil;

        [SerializeField] 
        private float jumpImpulse;

        private IWallJump playerWallJump;
        private float nextJump;
        
        private void Awake()
        {
            playerWallJump = new Rigibody2DWallJumpBehaviour(rigidbody2D);
            
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if(jumpInputPlayerOneVariable == null || detectionManagerVariable == null) return;
            if (!jumpInputPlayerOneVariable.Value || !detectionManagerVariable.Value || !(Time.time > nextJump)) return;
            playerWallJump.DoWallJump(new Vector3(currentHittedWallNormalDirection.Value.x, 1), jumpImpulse);
            nextJump = Time.time + jumpRecoil;

        }
    }
}