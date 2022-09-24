using UnityEngine;

namespace KID
{
    /// <summary>
    /// ���ĺ޲z��
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
        /// ���񭵮�
        /// </summary>
        /// <param name="sound">����</param>
        /// <param name="volume">���q</param>
        public void PlaySound(AudioClip sound, float volume = 1)
        {
            aud.PlayOneShot(sound, volume);
        }
    }
}

