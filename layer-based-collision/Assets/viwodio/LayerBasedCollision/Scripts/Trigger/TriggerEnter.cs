using UnityEngine;

namespace viwodio.LayerBasedCollision
{
    public class TriggerEnter : TriggerBase
    {
        private void OnTriggerEnter(Collider other)
        {
            if (ValidateCollision(other.gameObject))
            {
                OnTrigger?.Invoke(other);
            }
        }
    }
}