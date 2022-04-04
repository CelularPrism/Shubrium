using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PsychoController : MonoBehaviour
{
    public bool isLive = true;

    [SerializeField] private float psychoChanger;

    [SerializeField] private float[] psychoState;
    [SerializeField] private float nowPsycho;
    [SerializeField] private float nowFatigue;
    [SerializeField] private float nextCondition;
    [SerializeField] private MusicManager musicManager;
    [SerializeField] private StatesImageManager statesImageManager;

    private float prevPsycho;
    private int indexPrevPsycho;
    private int indexNextPsycho;

    private void Start()
    {
        indexPrevPsycho = 0;
        indexNextPsycho = 1;
    }

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Mouse0))
            ChangePsycho(psychoChanger);

        if (Input.GetKeyDown(KeyCode.Mouse1))
            ChangePsycho(-psychoChanger);*/
    }

    public void ChangePsycho(float psycho)
    {
        /*nowPsycho += psycho;

        if (nowPsycho - prevPsycho >= nextCondition)
        {
            musicManager.SetNextAudio();
            prevPsycho = nowPsycho;
        } else if (prevPsycho - nowPsycho >= nextCondition)
        {
            musicManager.SetPrevAudio();
            prevPsycho = nowPsycho;
        }*/

        nowPsycho += psycho;
        if (nowPsycho > psychoState[indexNextPsycho])
        {
            musicManager.SetNextAudio();
            statesImageManager.SetNextState();
            if (indexNextPsycho < psychoState.Length - 1)
            {
                indexNextPsycho++;
            }

            indexPrevPsycho = indexNextPsycho - 1;
        }
        else if (nowPsycho < psychoState[indexPrevPsycho])
        {
            musicManager.SetPrevAudio();
            statesImageManager.SetPrevState();
            if (indexPrevPsycho > 0)
                indexPrevPsycho--;

            indexNextPsycho = indexPrevPsycho + 1;
        }

        if (nowPsycho < 0)
            nowPsycho = 0;
        else if (nowPsycho > psychoState[psychoState.Length - 1])
        {
            nowPsycho = psychoState[psychoState.Length - 1];
            isLive = false;
        }
    }

    public void ChangeFatigue(float fatigue)
    {
        nowFatigue += fatigue;
    }
}
