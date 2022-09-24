using UnityEngine;

namespace KID
{
    /// <summary>
    /// �I������
    /// </summary>
    public class BackgroundMove : MonoBehaviour
    {
        [SerializeField, Header("�I������"), Range(0, 10)]
        private float speed = 3.5f;

        private void Update()
        {
            Move();
        }

        /// <summary>
        /// ����
        /// </summary>
        private void Move()
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }
}
