using UnityEngine;

namespace KID
{
    /// <summary>
    /// ���a���˨t��
    /// </summary>
    public class DamageSystemPlayer : DamageSystem
    {
        protected override void Dead()
        {
            base.Dead();

            UIAndSceneManager.instance.ShowAndUpdateTitle("�D�ԥ��ѡI");
        }
    }
}
