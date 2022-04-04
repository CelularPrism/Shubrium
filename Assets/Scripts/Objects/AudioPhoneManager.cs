using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPhoneManager : MonoBehaviour
{
    public bool playing;

    [SerializeField] private MusicManager musicManager;
    [SerializeField] private AudioSource musicSrc;
    [SerializeField] private AudioSource soundSrc;
    [SerializeField] private AudioClip[] phoneState;
    [SerializeField] private AudioClip[] psychoRings;

    private int index = 0;

    public void Update()
    {
        if (!musicSrc.isPlaying && playing)
            musicSrc.Play();
    }

    public void PickUp()
    {
        playing = false;
        musicSrc.Stop();

        soundSrc.loop = false;
        soundSrc.clip = phoneState[0];
        soundSrc.Play();
    }

    public void PutDown()
    {
        playing = false;
        soundSrc.loop = false;
        soundSrc.clip = phoneState[1];
        soundSrc.Play();

        musicManager.SetAudioClip();
    }

    public void PlayMusic()
    {
        musicSrc.loop = true;
        musicSrc.clip = psychoRings[index];
        musicSrc.Play();
    }

    public void SetNextPsychoRing()
    {
        if (index < psychoRings.Length - 1)
        {
            index++;
        }
    }

    public void SetPreviouslyRing()
    {
        if (index > 0)
        {
            index--;
        }
    }
}
