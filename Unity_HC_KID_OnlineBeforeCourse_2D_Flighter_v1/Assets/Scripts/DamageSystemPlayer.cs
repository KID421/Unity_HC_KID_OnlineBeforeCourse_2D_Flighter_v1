using UnityEngine;

namespace KID
{
    /// <summary>
    /// 玩家受傷系統
    /// </summary>
    public class DamageSystemPlayer : DamageSystem
    {
        protected override void Dead()
        {
            base.Dead();

            UIAndSceneManager.instance.ShowAndUpdateTitle("挑戰失敗！");
        }
    }
}
