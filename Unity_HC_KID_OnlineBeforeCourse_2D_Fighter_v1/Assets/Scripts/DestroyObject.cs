using UnityEngine;

namespace KID
{
    /// <summary>
    /// §R°£ª«¥ó
    /// </summary>
    public class DestroyObject : MonoBehaviour
    {
        private bool visible;

        private void OnBecameVisible()
        {
            visible = true;
        }

        private void OnBecameInvisible()
        {
            if (visible) Destroy(gameObject);
        }
    }
}

