using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private AudioSource musicSrc;
    [SerializeField] private AudioClip[] audioPsycho;

    private int nowIndexAudio;
    private int nextIndexAudio;

    private void FixedUpdate()
    {
        if (nowIndexAudio != nextIndexAudio)
        {
            Invoke("SetAudioClip", musicSrc.clip.length - musicSrc.time);
        }
    }

    private void SetAudioClip()
    {
        nowIndexAudio = nextIndexAudio;
        musicSrc.clip = audioPsycho[nowIndexAudio];
        musicSrc.Play();
    }

    public void PlayMusic()
    {
        musicSrc.Play();
    }

    public void StopMusic()
    {
        musicSrc.Stop();
    }

    public void SetAudioClip(AudioClip audioClip)
    {
        musicSrc.clip = audioClip;
        musicSrc.Play();
    }

    public void SetNextAudio()
    {
        if (nextIndexAudio != audioPsycho.Length - 1)
            nextIndexAudio++;
    }

    public void SetPrevAudio()
    {
        if (nextIndexAudio > 0)
            nextIndexAudio--;
    }
}
