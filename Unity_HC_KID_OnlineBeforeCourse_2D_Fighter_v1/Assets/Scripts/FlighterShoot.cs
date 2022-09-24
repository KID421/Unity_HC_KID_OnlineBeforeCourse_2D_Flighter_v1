using UnityEngine;

namespace KID
{
    /// <summary>
    /// 戰鬥機射擊
    /// </summary>
    public class FlighterShoot : MonoBehaviour
    {
        [SerializeField, Header("子彈")]
        private GameObject goBullet;
        [SerializeField, Header("子彈生成位置")]
        private Transform traBulletPoint;
        [SerializeField, Header("發射音效")]
        private AudioClip soundShoot;
        [SerializeField, Header("子彈角度")]
        private Vector3 angleBullet;
        [SerializeField, Header("子彈速度")]
        private Vector2 speedBullet = new Vector2(10, 0);
        [SerializeField, Header("子彈標籤")]
        private string tagBullet;
        [SerializeField, Header("子彈覆蓋顏色")]
        private Color colorBullet = Color.white;

        /// <summary>
        /// 射擊
        /// </summary>
        protected void Shoot()
        {
            SoundManager.instance.PlaySound(soundShoot, 1);
            GameObject tempBullet = Instantiate(goBullet, traBulletPoint.position, Quaternion.Euler(angleBullet));
            tempBullet.GetComponent<ConstantForce2D>().force = speedBullet;
            tempBullet.tag = tagBullet;
            tempBullet.GetComponent<SpriteRenderer>().color = colorBullet;
        }
    }
}
