using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMusicSource : MonoBehaviour
{
    private Dictionary<string, AudioClip> _audioMusicClips = new Dictionary<string, AudioClip>();

    private AudioManager _audioManager;

    private AudioSource _audioSource;
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();

        //Find and add all possible clips of music
        _audioMusicClips.Add("Music1", Resources.Load<AudioClip>("Music1"));
        _audioMusicClips.Add("Music2", Resources.Load<AudioClip>("Music2"));
        //etc
    }

    private void Start()
    {
        _audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        _audioManager.PlayAudio(_audioMusicClips["Music1"], _audioSource);
    }
    private void Update()
    {
        
    }
}
