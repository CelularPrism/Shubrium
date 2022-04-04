using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsScripter : MonoBehaviour
{
    [SerializeField] private Phone phone;
    [SerializeField] private AudioPhoneManager audioPhone;
    [SerializeField] private MusicManager musicManager;

    public bool isActive = false;

    private float _nextCall;
    private float _time;

    private void Start()
    {
        _nextCall = Random.Range(5f, 10f);
        _time = Time.time;
    }

    private void FixedUpdate()
    {
        if (isActive)
        {
            if (_time + _nextCall < Time.time)
            {
                isActive = false;
                audioPhone.playing = true;
                audioPhone.PlayMusic();
                musicManager.StopMusic();
                phone.enabled = true;
            } else
            {
                phone.enabled = false;
            }
        } else
        {
            _time = Time.time;
            _nextCall = Random.Range(30f, 60f);
        }
    }
}
