using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace CoinBox.Behaviour
{
    public class CoinBoxBehaviour : MonoBehaviour
    {
        [SerializeField] 
        private IntReference maxCoins;
        [SerializeField] 
        private IntReference remainingCoins;

        [SerializeField] 
        private IntReference coinsValue;

        [SerializeField] 
        private IntReference currentCoins;

        [SerializeField] 
        private UnityEvent onAddingCoin;
        [SerializeField] 
        private UnityEvent onNoRemainingCoins;

        private void Awake()
        {
            remainingCoins.Value = maxCoins.Value;
        }

        public void OnHitCoinBox()
        {
            if(remainingCoins.Value <= 0) return;
            AddCoinToCurrentCoins();
            
            if (remainingCoins.Value > 0) return;
           RunOutOfCoins();
        }


        void AddCoinToCurrentCoins()
        {
            remainingCoins.Value--;
            currentCoins.Value += coinsValue.Value;
            onAddingCoin.Invoke();
        }

        void RunOutOfCoins()
        {
            remainingCoins.Value = Math.Min(0, maxCoins.Value);
            onNoRemainingCoins.Invoke();
        }
    }
}