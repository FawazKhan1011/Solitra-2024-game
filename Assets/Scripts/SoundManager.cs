using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioSource coinSource;
    public AudioSource winSource;
    public AudioClip coinSound;
    public AudioClip winSound;
    public float volumeMultiplier = 2.0f;

    private AudioSource musicSource; // Reference to the background music AudioSource

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        coinSource = GetComponent<AudioSource>();
        musicSource = transform.Find("music").GetComponent<AudioSource>(); // Find the AudioSource component of the "music" GameObject
    }

    // Function to play coin collision sound
    public void PlayCoinSound()
    {
        coinSource.PlayOneShot(coinSound);
    }

    // Function to play win sound
    public void PlayWinSound()
    {
        winSource.PlayOneShot(winSound, winSource.volume * volumeMultiplier);
    }

    // Function to stop the background music
    public void StopMusic()
    {
        if (musicSource != null)
        {
            musicSource.Stop();
        }
        else
        {
            Debug.LogWarning("Background music AudioSource component not found!");
        }
    }
}
