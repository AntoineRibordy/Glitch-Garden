using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MusicManager : MonoBehaviour
{

    public AudioClip[] LevelMusicChangeArray;

    private AudioSource audioSource;
    // Use this for initialization
    void Awake()
    {
        GameObject.DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnLevelWasLoaded(int level)
    {
        if (LevelMusicChangeArray[level])
        {
            audioSource.clip = LevelMusicChangeArray[level];
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public void ChangeVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
