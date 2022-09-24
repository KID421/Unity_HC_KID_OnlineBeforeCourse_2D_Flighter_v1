using UnityEngine;

namespace KID
{
    /// <summary>
    /// �԰����g��
    /// </summary>
    public class FlighterShoot : MonoBehaviour
    {
        [SerializeField, Header("�l�u")]
        private GameObject goBullet;
        [SerializeField, Header("�l�u�ͦ���m")]
        private Transform traBulletPoint;
        [SerializeField, Header("�o�g����")]
        private AudioClip soundShoot;
        [SerializeField, Header("�l�u����")]
        private Vector3 angleBullet;
        [SerializeField, Header("�l�u�t��")]
        private Vector2 speedBullet = new Vector2(10, 0);
        [SerializeField, Header("�l�u����")]
        private string tagBullet;
        [SerializeField, Header("�l�u�л\�C��")]
        private Color colorBullet = Color.white;

        /// <summary>
        /// �g��
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
