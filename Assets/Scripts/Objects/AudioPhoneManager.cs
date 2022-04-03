using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPhoneManager : MonoBehaviour
{
    [SerializeField] private AudioSource playerSrc;
    [SerializeField] private AudioClip[] phoneState;
    [SerializeField] private AudioClip[] psychoRings;

    private int index = 0;

    public void Update()
    {
        if (!playerSrc.isPlaying)
            playerSrc.Play();
    }

    public void PickUp()
    {
        playerSrc.loop = false;
        playerSrc.clip = phoneState[0];
        playerSrc.Play();
    }

    public void PutDown()
    {
        playerSrc.loop = false;
        playerSrc.clip = phoneState[1];
        playerSrc.Play();
    }

    public void PlayMusic()
    {
        playerSrc.loop = true;
        playerSrc.clip = psychoRings[index];
        playerSrc.Play();
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
