using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;
using UnityEngine.UI;

namespace KID
{
    /// <summary>
    /// �����P�����޲z
    /// </summary>
    public class UIAndSceneManager : MonoBehaviour
    {
        public static UIAndSceneManager instance;

        private FlighterControl flighterControl;
        private FlighterShootPlayer flighterShootPlayer;
        private BackgroundMove backgroundMove;

        /// <summary>
        /// �������D
        /// </summary>
        private TextMeshProUGUI textTitle;
        /// <summary>
        /// ���s�C��
        /// </summary>
        private Button btnReplay;
        private CanvasGroup canvasGroup;

        private void Awake()
        {
            instance = this;

            flighterControl = FindObjectOfType<FlighterControl>();
            flighterShootPlayer = FindObjectOfType<FlighterShootPlayer>();
            backgroundMove = FindObjectOfType<BackgroundMove>();

            canvasGroup = GetComponent<CanvasGroup>();
            textTitle = GameObject.Find("�������D").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("���s�C��").GetComponent<Button>();
            btnReplay.onClick.AddListener(Replay);
        }

        /// <summary>
        /// ��ܨç�s���D
        /// </summary>
        /// <param name="title"></param>
        public void ShowAndUpdateTitle(string title)
        {
            textTitle.text = title;

            flighterControl.enabled = false;
            flighterShootPlayer.enabled = false;
            backgroundMove.enabled = false;

            StartCoroutine(ShowUI());
        }

        /// <summary>
        /// ��ܤ���
        /// </summary>
        private IEnumerator ShowUI()
        {
            for (int i = 0; i < 10; i++)
            {
                canvasGroup.alpha += 0.1f;
                yield return new WaitForSeconds(0.02f);
            }

            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
        }

        /// <summary>
        /// ���s�C��
        /// </summary>
        private void Replay()
        {
            SceneManager.LoadScene("�C������");
        }
    }
}

