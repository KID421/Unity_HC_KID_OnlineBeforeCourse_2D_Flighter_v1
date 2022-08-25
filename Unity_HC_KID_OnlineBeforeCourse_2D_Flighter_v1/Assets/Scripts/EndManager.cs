using UnityEngine;

namespace KID
{
    /// <summary>
    /// 終點管理器
    /// </summary>
    public class EndManager : MonoBehaviour
    {
        [SerializeField, Header("觸發終點的物件名稱")]
        private string nameTriggerObject = "戰鬥機";

        private void OnTriggerEnter2D(Collider2D collision)
        {
            End(collision.name);
        }

        /// <summary>
        /// 結束
        /// </summary>
        /// <param name="hitName">碰撞物件名稱</param>
        private void End(string hitName)
        {
            if (hitName.Contains(nameTriggerObject))
            {
                UIAndSceneManager.instance.ShowAndUpdateTitle("挑戰成功");
            }
        }
    }
}

