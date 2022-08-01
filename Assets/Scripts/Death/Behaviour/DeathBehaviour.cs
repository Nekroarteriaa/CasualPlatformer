using Kill.Interface;
using UnityEngine;

namespace Kill.Behaviour
{
    public class DeathBehaviour : MonoBehaviour , IDeath
    {
        public void DoDie()
        {
            Destroy(gameObject);
        }
    }
}