using Checkpoints.Interface.Checkpoint;

namespace Checkpoints.Interface.CheckpointChecker
{
    public interface ICheckpointChecker
    {
        void CheckpointReaching(ICheckpoint checkpoint);
    }
}