using System;
using Damage.Interface.DamageReceiver;
using Health.Interface;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Health.Controller
{
    public class HealthController : MonoBehaviour, IHealth, IDamageReceiver
    {
        public UnityEvent OnRunOutOfLife => onRunOutOfLife;
        public int CurrentHealth => currentHealth.Value;
        public int MaxHealth => maxHealth;
        
        [SerializeField] 
        private IntReference currentHealth;

        [SerializeField] 
        private IntReference maxHealth;

        [SerializeField]
        private UnityEvent onRunOutOfLife;

        private void Awake()
        {
            currentHealth.Value = maxHealth.Value;
        }

        public void ReceiveDamage(int damage)
        {
            if(currentHealth.Value <= 0) return;
            currentHealth.Value -= damage;

            if (currentHealth.Value > 0) return;
            currentHealth.Value = Math.Min(0, maxHealth);
            onRunOutOfLife.Invoke();

        }
    }
}