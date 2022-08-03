using UnityEngine;

namespace Checkpoints.Interface.Checkpoint
{
    public interface ICheckpoint
    {
        bool HasBeenChecked { get; }
        Vector3 CheckedPosition { get; }

        void DoCheck(Vector3 checkingPoint);

        void DoCheck();
    }
}