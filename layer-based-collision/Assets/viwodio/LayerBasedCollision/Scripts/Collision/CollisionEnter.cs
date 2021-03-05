using UnityEngine;

namespace viwodio.LayerBasedCollision
{
    public class CollisionEnter : CollisionBase
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (ValidateCollision(collision.collider.gameObject))
            {
                OnCollision?.Invoke(collision);
            }
        }
    }
}
