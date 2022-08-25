using UnityEngine;

namespace KID
{
    /// <summary>
    /// 敵人發射擊
    /// </summary>
    public class FlighterShootEnemy : FlighterShoot
    {
        [SerializeField, Header("發射間隔"), Range(0, 5)]
        private float intervalShoot = 2.5f;

        private void OnBecameVisible()
        {
            InvokeRepeating("Shoot", 1, intervalShoot);
        }
    }
}
