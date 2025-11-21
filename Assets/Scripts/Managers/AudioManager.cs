using UnityEngine;

namespace GAMEPLAY
{
    public class AudioManager : MonoBehaviour
    {
        [Header("Audio Clips")]
        [SerializeField] private AudioClip _audioDestroy;
        [SerializeField] private AudioClip _audioRepulsion;

        [Header("Audio Source")]
        [SerializeField] private AudioSource _audioSource;
        
        public static AudioManager Instance = null;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }

        public void PlayDestroySound()
        {
            if (_audioDestroy != null)
            {
                _audioSource.PlayOneShot(_audioDestroy, 0.5f);
            }
        }

        public void PlayAudioRepulsion()
        {
            if (_audioRepulsion != null)
            {
                _audioSource.PlayOneShot(_audioRepulsion, 0.5f);
            }
        }
    }
}
