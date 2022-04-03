using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEffectSource : MonoBehaviour
{
    private Dictionary<string, AudioClip> _audioEffectClips = new Dictionary<string, AudioClip>();

    private AudioManager _audioManager;

    private AudioSource _audioSource;
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();

        //Find and add all possible clips of music
        _audioEffectClips.Add("Effect1", Resources.Load<AudioClip>("Effect1"));
        _audioEffectClips.Add("Effect2", Resources.Load<AudioClip>("Effect2"));
        //etc
    }

    private void Start()
    {
        _audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        _audioManager.PlayAudio(_audioEffectClips["Effect1"], _audioSource);
    }
    private void Update()
    {

    }
}
