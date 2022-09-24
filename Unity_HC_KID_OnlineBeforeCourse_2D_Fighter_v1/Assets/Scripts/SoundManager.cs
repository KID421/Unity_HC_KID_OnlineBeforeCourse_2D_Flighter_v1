using UnityEngine;

namespace KID
{
    /// <summary>
    /// 音效管理器
    /// </summary>
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager instance;

        private AudioSource aud;

        private void Awake()
        {
            instance = this;

            aud = GetComponent<AudioSource>();
        }

        /// <summary>
        /// 播放音效
        /// </summary>
        /// <param name="sound">音效</param>
        /// <param name="volume">音量</param>
        public void PlaySound(AudioClip sound, float volume = 1)
        {
            aud.PlayOneShot(sound, volume);
        }
    }
}

