using Damage.Interface.DamageReceiver;
using Health.Interface;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Health.Controller
{
    public class HealthController : MonoBehaviour, IHealth, IDamageReceiver
    {
        public int CurrentHealth => currentHealth;
        public int MaxHealth => maxHealth;
        
        [SerializeField] 
        private IntReference currentHealth;

        [SerializeField] 
        private IntReference maxHealth;

        [SerializeField] 
        private IntEventReference onReceivedDamage;

        [SerializeField]
        private VoidBaseEventReference onDeath;

        private void Start()
        {
            currentHealth.Value = maxHealth.Value;
        }

        public void ReceiveDamage(int damage)
        {
            if(currentHealth < 0) return;
            currentHealth.Value -= damage;
            
            if(currentHealth > 0)
                onReceivedDamage.Event.Raise(damage);
            else
                onDeath.Event.Raise();

        }
    }
}