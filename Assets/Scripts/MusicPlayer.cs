using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    static private AudioSource _audioSource;
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
        if (PlayerPrefs.GetInt("isPlaying") == 1)
            _audioSource.Play();
        else
            _audioSource.Stop();
    }
    static public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    static public void StopMusic()
    {
        _audioSource.Stop();
    }
}
