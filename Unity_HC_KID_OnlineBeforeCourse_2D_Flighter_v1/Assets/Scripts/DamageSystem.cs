using UnityEngine;

namespace KID
{
    /// <summary>
    /// 受傷系統
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("受傷音效")]
        private AudioClip soundDamage;
        [SerializeField, Header("碰到有傷害的標籤")]
        private string[] tagDamages;
        [SerializeField, Header("爆炸特效")]
        private GameObject goExplosion;
        [SerializeField, Header("爆炸音效")]
        private AudioClip soundExplosion;

        private float health = 1;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Damage(collision.tag);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Damage(collision.gameObject.tag);
        }

        /// <summary>
        /// 受傷
        /// </summary>
        /// <param name="hitTag">碰撞物件的標籤</param>
        private void Damage(string hitTag)
        {
            for (int i = 0; i < tagDamages.Length; i++)
            {
                if (hitTag == tagDamages[i])
                {
                    health--;
                    SoundManager.instance.PlaySound(soundDamage);
                    break;
                }
            }

            if (health <= 0) Dead();
        }

        /// <summary>
        /// 死亡
        /// </summary>
        protected virtual void Dead()
        {
            SoundManager.instance.PlaySound(soundExplosion);
            GameObject tempExplosion = Instantiate(goExplosion, transform.position, Quaternion.identity);
            Destroy(tempExplosion, 1);
            Destroy(gameObject);
        }
    }
}
