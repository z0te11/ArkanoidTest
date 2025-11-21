using UnityEngine;

public class AudioBlockController : MonoBehaviour
{
    private ISound _Isound;

    private void Awake()
    {
        _Isound = GetComponent<ISound>();
    }
    private void OnEnable()
    {
        _Isound.OnRepulsion += CallSoundRepulsion;
        _Isound.OnDestroyed += CallSoundDestroy;
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
