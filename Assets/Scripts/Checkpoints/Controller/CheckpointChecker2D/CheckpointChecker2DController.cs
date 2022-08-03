using Checkpoints.Controller.CheckpointCheckerBase;
using Checkpoints.Interface.Checkpoint;
using UnityEngine;

namespace Checkpoints.Controller.CheckpointChecker2D
{
    public class CheckpointChecker2DController : CheckpointCheckerControllerBase
    {
        private void OnTriggerExit2D(Collider2D other)
        {
            other.gameObject.TryGetComponent(out ICheckpoint checkpoint);
            if(checkpoint == null) return;
            checkpointChecker.CheckpointReaching(checkpoint);
        }
    }
}