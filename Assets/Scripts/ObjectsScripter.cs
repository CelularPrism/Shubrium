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
                audioPhone.playing = true;
                audioPhone.PlayMusic();
                //musicManager.StopMusic();
                //phone.enabled = true; //see next line
                phone._setDialog = true;
                phone._isActive = true;
            } else
            {
                //phone.enabled = false; //see next line
                phone._setDialog = false;
            }
        } else
        {
            _time = Time.time;
            _nextCall = Random.Range(5, 10);
        }
    }
}
