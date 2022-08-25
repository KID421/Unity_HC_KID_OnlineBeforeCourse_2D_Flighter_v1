using UnityEngine;

namespace KID
{
    /// <summary>
    /// ���I�޲z��
    /// </summary>
    public class EndManager : MonoBehaviour
    {
        [SerializeField, Header("Ĳ�o���I������W��")]
        private string nameTriggerObject = "�԰���";

        private void OnTriggerEnter2D(Collider2D collision)
        {
            End(collision.name);
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="hitName">�I������W��</param>
        private void End(string hitName)
        {
            if (hitName.Contains(nameTriggerObject))
            {
                UIAndSceneManager.instance.ShowAndUpdateTitle("�D�Ԧ��\");
            }
        }
    }
}

