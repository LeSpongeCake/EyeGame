using UnityEngine;

public enum SoundType
{
    CollectSound,
    Footstep1,
    Footstep2,
}

[RequireComponent(typeof(AudioSource))]
public class Sound_Manager : MonoBehaviour
{
    [SerializeField] private AudioClip[] soundlist;
    private static Sound_Manager instance;
    private AudioSource audioSource;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public static void PlaySound(SoundType sound, float volume = 1)
    {
        instance.audioSource.PlayOneShot(instance.soundlist[(int)sound], volume);
    }
}
