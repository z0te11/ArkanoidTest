using UnityEngine;

namespace GAMEPLAY
{
    public class AudioBlockController : MonoBehaviour
    {
        private ISound _iSound;

        private void Awake()
        {
            _iSound = GetComponent<ISound>();
        }

        private void OnEnable()
        {
            _iSound.OnRepulsion += CallSoundRepulsion;
            _iSound.OnDestroyed += CallSoundDestroy;
        }

        private void OnDisable()
        {
            _iSound.OnRepulsion -= CallSoundRepulsion;
            _iSound.OnDestroyed -= CallSoundDestroy;
        }

        private void CallSoundRepulsion()
        {
            AudioManager.Instance.PlayAudioRepulsion();
        }

        private void CallSoundDestroy()
        {
            AudioManager.Instance.PlayDestroySound();
        }
    }
}
