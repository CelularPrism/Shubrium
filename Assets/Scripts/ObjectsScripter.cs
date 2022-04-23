using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsScripter : MonoBehaviour
{
    [SerializeField] private Phone phone;
    [SerializeField] private AudioPhoneManager audioPhone;
    [SerializeField] private MusicManager musicManager;

    public bool isActive = false;

    private int _nextCall;
    private float _time;

    private void Start()
    {
        _nextCall = Random.Range(5, 10);
        _time = Time.time;
    }

    private void FixedUpdate()
    {
        if (isActive)
        {
            if (_time + _nextCall < Time.time)
            {
                isActive = false;
                phone._isEnabled = true;
                phone._isActive = true;
                audioPhone.playing = true;
                audioPhone.PlayMusic();
                //musicManager.StopMusic();
            } else
            {
                phone._isEnabled = false;
            }
        } else
        {
            _time = Time.time;
            _nextCall = Random.Range(5, 10);
        }
    }
}
