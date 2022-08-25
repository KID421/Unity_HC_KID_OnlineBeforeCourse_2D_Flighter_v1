using UnityEngine;

namespace KID
{
    /// <summary>
    /// �԰�������
    /// </summary>
    public class FlighterControl : MonoBehaviour
    {
        [SerializeField, Header("���ʳt��"), Range(0, 100)]
        private float speed = 3.5f;
        [Header("�԰����Ϥ��G�W���U")]
        [SerializeField] private Sprite spriteUp;
        [SerializeField] private Sprite spriteMiddle;
        [SerializeField] private Sprite spriteDwon;

        private Rigidbody2D rig;
        private SpriteRenderer spr;

        private void Awake()
        {
            rig = GetComponent<Rigidbody2D>();
            spr = GetComponent<SpriteRenderer>();
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
        /// ����
        /// </summary>
        private void Move()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            rig.velocity = (Vector3.up * v + Vector3.right * h) * speed;

            if (v > 0) spr.sprite = spriteUp;
            else if (v < 0) spr.sprite = spriteDwon;
            else spr.sprite = spriteMiddle;
        }
    }
}

