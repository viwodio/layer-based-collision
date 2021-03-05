using UnityEngine;
using System.Collections;

namespace viwodio.ExtensionMethods
{
    public static class LayerMaskExtensions
    {
        public static bool IsSelected(this LayerMask layerMask, int layer)
        {
            return ((1 << layer) & layerMask.value) != 0;
        }
    }
}