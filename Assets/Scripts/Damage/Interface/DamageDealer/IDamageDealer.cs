using Damage.Interface.DamageReceiver;

namespace Damage.Interface.DamageDealer
{
    public interface IDamageDealer
    {
        void DealDamage(IDamageReceiver damageReceiver, int damage);

    }
}

