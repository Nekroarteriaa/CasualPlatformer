using Checkpoints.Interface.Checkpoint;
using Checkpoints.Interface.CheckpointChecker;

namespace Checkpoints.Behaviour.CheckpointChecker
{
    public class CheckpointCheckerBehaviour : ICheckpointChecker
    {
        public void CheckpointReaching(ICheckpoint checkpoint)
        {
            checkpoint.DoCheck();
        }
    }
}