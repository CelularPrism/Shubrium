using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PsychoController : MonoBehaviour
{
    [SerializeField] private float psychoChanger;

    [SerializeField] private float nowPsycho;
    [SerializeField] private float nowFatigue;
    [SerializeField] private float nextCondition;
    [SerializeField] private MusicManager musicManager;

    private float prevPsycho;

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Mouse0))
            ChangePsycho(psychoChanger);

        if (Input.GetKeyDown(KeyCode.Mouse1))
            ChangePsycho(-psychoChanger);*/
    }

    public void ChangePsycho(float psycho)
    {
        nowPsycho += psycho;

        if (nowPsycho - prevPsycho >= nextCondition)
        {
            musicManager.SetNextAudio();
            prevPsycho = nowPsycho;
        } else if (prevPsycho - nowPsycho >= nextCondition)
        {
            musicManager.SetPrevAudio();
            prevPsycho = nowPsycho;
        }
    }

    public void ChangeFatigue(float fatigue)
    {
        nowFatigue += fatigue;
    }
}
