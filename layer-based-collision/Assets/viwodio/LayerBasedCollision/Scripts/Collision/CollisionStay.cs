using UnityEngine;

namespace viwodio.LayerBasedCollision
{
    public class CollisionStay : CollisionBase
    {
        private void OnCollisionStay(Collision collision)
        {
            if (ValidateCollision(collision.collider.gameObject))
            {
                OnCollision?.Invoke(collision);
            }
        }
    }
}