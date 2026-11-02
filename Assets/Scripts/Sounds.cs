using UnityEngine;

public class Sounds : MonoBehaviour
{
    private AudioSource audioSource;
    
    public AudioClip FallingSound;
    public AudioClip PillSound;
    public AudioClip BeerSound;
    public AudioClip MoonshineSound;
    public AudioClip PoopSound;
    public AudioClip BoneSound;

    public void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayFallingSound()
    {
        audioSource.PlayOneShot(FallingSound);
    }

    public void PlayPoopSound()
    {
        audioSource.PlayOneShot(PoopSound);
    }

    public void PlayBoneSound()
    {
        audioSource.PlayOneShot(BoneSound);
    }

    public void PlayPillSound()
    {
        audioSource.PlayOneShot(PillSound);
    }

    public void PlayBeerSound()
    {
        audioSource.PlayOneShot(BeerSound);
    }

    public void PlayMoonshineSound()
    {
        audioSource.PlayOneShot(MoonshineSound);
    }
}
