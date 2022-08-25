using UnityEngine;

namespace KID
{
    /// <summary>
    /// ���˨t��
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("���˭���")]
        private AudioClip soundDamage;
        [SerializeField, Header("�I�즳�ˮ`������")]
        private string[] tagDamages;
        [SerializeField, Header("�z���S��")]
        private GameObject goExplosion;
        [SerializeField, Header("�z������")]
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
        /// ����
        /// </summary>
        /// <param name="hitTag">�I�����󪺼���</param>
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
        /// ���`
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
