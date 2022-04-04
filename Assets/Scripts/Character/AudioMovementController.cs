using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(DoctorNavMesh))]
public class AudioMovementController : MonoBehaviour
{
    [SerializeField] private AudioClip[] clips;
    [SerializeField] private AudioSource audioSource;
    private DoctorNavMesh _doctorNavMesh;

    private void Start()
    {
        _doctorNavMesh = GetComponent<DoctorNavMesh>();
    }

    void Update()
    {
        if (_doctorNavMesh.isMove)
        {
            if (!audioSource.isPlaying && clips.Length > 0)
                PlayRandomSound();
        }
    }

    private AudioClip GetRandomClip()
    {
        return clips[Random.Range(0, clips.Length)];
    }

    private void PlayRandomSound()
    {
        AudioClip audioClip = GetRandomClip();
        audioSource.PlayOneShot(audioClip);
    }
}
