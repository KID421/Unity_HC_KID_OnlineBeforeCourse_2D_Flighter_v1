using UnityEngine;

namespace KID
{
    /// <summary>
    /// 戰鬥機玩家
    /// </summary>
    public class FlighterShootPlayer : FlighterShoot
    {
        private void Update()
        {
            ShootInput();
        }

        /// <summary>
        /// 發射輸入
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

