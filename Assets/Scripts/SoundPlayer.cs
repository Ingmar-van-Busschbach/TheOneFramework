using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundPlayer : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private bool randomizeSound = false;
    [SerializeField] private AudioClip[] audioClips;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlaySound()
    {
        if (randomizeSound)
        {
            audioSource.clip = audioClips[Random.Range(0, audioClips.Length-1)];
        }
        audioSource.Play();
    }
}
