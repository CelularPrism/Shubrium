using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScriptManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip endGame;
/*
    public void EndGame()
    {
        audioSource.loop = false;
        audioSource.clip = endGame;
        audioSource.Play();
    }*/
}
