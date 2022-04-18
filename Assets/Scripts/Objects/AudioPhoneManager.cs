using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPhoneManager : MonoBehaviour
{
    public bool playing = false;

    //[SerializeField] private MusicManager musicManager;
    //[SerializeField] private AudioSource musicSrc;
    [SerializeField] private AudioSource soundSrc;
    [SerializeField] private AudioClip[] phoneState;
    [SerializeField] private AudioClip[] psychoRings;

    private int index = 0;

    private void Update()
    {
        if (!soundSrc.isPlaying && playing)
            soundSrc.Play();
    }

    public void PickUp()
    {
        playing = false;
        //musicSrc.Stop();

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

        //musicManager.SetAudioClip();
    }

    public void PlayMusic()
    {
        soundSrc.loop = true;
        soundSrc.clip = psychoRings[index];
        soundSrc.Play();
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
