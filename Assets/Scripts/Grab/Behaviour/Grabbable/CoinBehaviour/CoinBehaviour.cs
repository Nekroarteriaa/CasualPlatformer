using Grab.Interface.Grabbable;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Grab.Behaviour.Grabbable.CoinBehaviour
{
    public class CoinBehaviour : MonoBehaviour, IGrabbable
    {
        public UnityEvent OnGrabbed => onGrabbed;
        [SerializeField] 
        private IntReference currentCoins;
        [SerializeField] 
        private IntReference coinValue;

        [SerializeField] 
        private UnityEvent onGrabbed;


        public void Grabbed()
        {
            currentCoins.Value += coinValue.Value;
            onGrabbed.Invoke();
        }
    }
}