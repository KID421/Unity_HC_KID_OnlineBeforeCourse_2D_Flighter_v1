using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ĤH�o�g��
    /// </summary>
    public class FlighterShootEnemy : FlighterShoot
    {
        [SerializeField, Header("�o�g���j"), Range(0, 5)]
        private float intervalShoot = 2.5f;

        private void OnBecameVisible()
        {
            InvokeRepeating("Shoot", 1, intervalShoot);
        }
    }
}
