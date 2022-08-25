using UnityEngine;

namespace KID
{
    /// <summary>
    /// 戰鬥機控制
    /// </summary>
    public class FlighterControl : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Range(0, 100)]
        private float speed = 3.5f;

        private Rigidbody2D rig;

        private void Awake()
        {
            rig = GetComponent<Rigidbody2D>();
        }

        private void OnDisable()
        {
            rig.velocity = Vector3.zero;
        }

        private void Update()
        {
            Move();
        }

        /// <summary>
        /// 移動
        /// </summary>
        private void Move()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            rig.velocity = (Vector3.up * v + Vector3.right * h) * speed;
        }
    }
}

