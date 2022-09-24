using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;
using UnityEngine.UI;

namespace KID
{
    /// <summary>
    /// 介面與場景管理
    /// </summary>
    public class UIAndSceneManager : MonoBehaviour
    {
        public static UIAndSceneManager instance;

        private FlighterControl flighterControl;
        private FlighterShootPlayer flighterShootPlayer;
        private BackgroundMove backgroundMove;

        /// <summary>
        /// 結束標題
        /// </summary>
        private TextMeshProUGUI textTitle;
        /// <summary>
        /// 重新遊戲
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
            textTitle = GameObject.Find("結束標題").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("重新遊戲").GetComponent<Button>();
            btnReplay.onClick.AddListener(Replay);
        }

        /// <summary>
        /// 顯示並更新標題
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
        /// 顯示介面
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
        /// 重新遊戲
        /// </summary>
        private void Replay()
        {
            SceneManager.LoadScene("遊戲場景");
        }
    }
}

