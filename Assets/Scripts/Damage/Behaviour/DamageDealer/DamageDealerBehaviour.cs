using Damage.Interface.DamageDealer;
using Damage.Interface.DamageReceiver;

namespace Damage.Behaviour.DamageDealer
{
    public class DamageDealerBehaviour : IDamageDealer
    {
        public void DealDamage(IDamageReceiver damageReceiver, int damage)
        {
            damageReceiver.ReceiveDamage(damage);
        }
    }
}