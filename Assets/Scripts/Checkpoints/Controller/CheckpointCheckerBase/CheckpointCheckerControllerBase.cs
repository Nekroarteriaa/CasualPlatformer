using Checkpoints.Behaviour.CheckpointChecker;
using Checkpoints.Interface.CheckpointChecker;
using UnityEngine;

namespace Checkpoints.Controller.CheckpointCheckerBase
{
    public abstract class CheckpointCheckerControllerBase : MonoBehaviour
    {
        protected ICheckpointChecker checkpointChecker;

        protected virtual void Awake()
        {
            checkpointChecker = new CheckpointCheckerBehaviour();
        }
    }
}