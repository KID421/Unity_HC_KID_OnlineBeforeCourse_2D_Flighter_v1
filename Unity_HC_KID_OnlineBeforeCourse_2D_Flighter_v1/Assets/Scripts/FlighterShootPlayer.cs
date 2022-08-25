using UnityEngine;

namespace KID
{
    /// <summary>
    /// �԰������a
    /// </summary>
    public class FlighterShootPlayer : FlighterShoot
    {
        private void Update()
        {
            ShootInput();
        }

        /// <summary>
        /// �o�g��J
        /// </summary>
        private void ShootInput()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Shoot();
            }
        }
    }
}

