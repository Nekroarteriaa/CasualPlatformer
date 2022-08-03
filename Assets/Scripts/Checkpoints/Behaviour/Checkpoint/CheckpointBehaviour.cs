using Checkpoints.Interface.Checkpoint;
using NoCallbackVariables.Vector3Variable;
using UnityEngine;

namespace Checkpoints.Behaviour.Checkpoint
{
    public class CheckpointBehaviour : MonoBehaviour, ICheckpoint
    {
        public bool HasBeenChecked => hasBeenChecked;
        public Vector3 CheckedPosition => checkedPosition.Value;

        [SerializeField]
        private Vector3NoCallbackVariable checkedPosition;
        private bool hasBeenChecked = false;
        
        public void DoCheck(Vector3 checkingPoint)
        {
            checkedPosition.Value = checkingPoint;
            hasBeenChecked = true;
        }

        public void DoCheck()
        {
            DoCheck(transform.position);
        }
    }
}