using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private AudioSource musicSrc;
    [SerializeField] private AudioSource audioSrc;
    [SerializeField] private AudioClip[] audioPsycho;
    [SerializeField] private AudioClip endGameAudio;

    private int nowIndexAudio;
    private int nextIndexAudio;
    private bool _endGame = false;

    private void FixedUpdate()
    {
        if (nowIndexAudio != nextIndexAudio && !_endGame)
        {
            Invoke("SetAudioClip", musicSrc.clip.length - musicSrc.time);
        }
    }

    private void SetAudioClip()
    {
        if (!musicSrc.isPlaying)
        {
            nowIndexAudio = nextIndexAudio;
            musicSrc.clip = audioPsycho[nowIndexAudio];
            musicSrc.Play();
        }
    }

    public void PlayMusic()
    {
        musicSrc.Play();
    }

    public void StopMusic()
    {
        musicSrc.Stop();
    }

    public void EndGame()
    {
        _endGame = true;
        musicSrc.clip = endGameAudio;
        musicSrc.loop = true;
        PlayMusic();
    }

    public void SetAudioClip(AudioClip audioClip = null)
    {
        if (audioClip != null)
        {
            musicSrc.clip = audioClip;
            musicSrc.Play();
        } else
        {
            SetAudioClip();
        }
    }

    public void PlayRing(AudioClip audioClip)
    {
        audioSrc.loop = true;
        audioSrc.clip = audioClip;
        audioSrc.Play();
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
