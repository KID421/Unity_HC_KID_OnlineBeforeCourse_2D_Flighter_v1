using UnityEngine;

namespace KID
{
    /// <summary>
    /// ­I´º²¾°Ê
    /// </summary>
    public class BackgroundMove : MonoBehaviour
    {
        [SerializeField, Header("­I´º²¾°Ê"), Range(0, 10)]
        private float speed = 3.5f;

        private void Update()
        {
            Move();
        }

        /// <summary>
        /// ²¾°Ê
        /// </summary>
        private void Move()
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }
}
