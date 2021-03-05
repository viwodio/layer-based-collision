using UnityEngine;
using System.Collections;

namespace viwodio.LayerBasedCollision
{
    public class CollisionExit : CollisionBase
    {
        private void OnCollisionExit(Collision collision)
        {
            if (ValidateCollision(collision.collider.gameObject))
            {
                OnCollision?.Invoke(collision);
            }
        }
    }
}