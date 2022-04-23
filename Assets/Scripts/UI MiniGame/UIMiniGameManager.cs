using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMiniGameManager : MonoBehaviour
{
    public Transform panel;
    [SerializeField] private Transform panelDialog;
    [SerializeField] private Transform panelDialogChanger;
    [SerializeField] private GameObject btnMiniGame;
    [SerializeField] private int nextMiniGame;

    [SerializeField] private ObjectsManager objectsManager;

    private DialogManager _dialogManager;
    private int _dialog;
    private float _nowTime;

    private void Awake()
    {
        _dialogManager = panelDialog.GetComponent<DialogManager>();
        _dialog = 0;
        _nowTime = Time.time;
    }

    private void FixedUpdate()
    {
        /*if (_nowTime + 5f < Time.time)
        {
            StartDialog();
            Debug.Log(_dialog);
            _nowTime = Time.time;
        }*/
    }

    private void CheckLimitMiniGame()
    {
        if (_dialog % nextMiniGame == 0)
        {
            btnMiniGame.SetActive(true);
        }
        else
        {
            btnMiniGame.SetActive(false);
        }
    }

    private int GetCorrectVariant(SOVariant[] variants)
    {
        int a = 0;

        foreach (SOVariant variant in variants)
        {
            if (variant.psycho > 0)
            {
                break;
            }
            a++;
        }

        return a;
    }

    private void SetCorrectVariant()
    {
        SODialog dialog = _dialogManager.GetDialog();
        int[] index = new int[2];
        index[0] = Random.Range(0, dialog.variants.Length);
        index[1] = GetCorrectVariant(dialog.variants);

        while (index[0] == index[1])
            index[0] = Random.Range(0, dialog.variants.Length);

        for (int i = 0; i < dialog.variants.Length; i++)
        {
            if (i != index[0] && i != index[1])
            {
                panelDialog.GetChild(0).GetChild(i).gameObject.SetActive(false);
            }
        }
    }

    public void StartDialog()
    {
        CheckLimitMiniGame();
        _dialog++;
    }

    public void DisableMiniGame()
    {
        if (_dialogManager.GetDialog() != null)
        {
            panel.gameObject.SetActive(false);
            objectsManager.miniGameActive = false;

            SetCorrectVariant();
        }
    }

    public void EnableMiniGame()
    {
        panel.gameObject.SetActive(true);
    }

    public void DisableDialog()
    {
        foreach (Transform trans in panel)
        {
            trans.gameObject.SetActive(true);
        }

        panelDialog.gameObject.SetActive(false);
        panelDialogChanger.gameObject.SetActive(false);

        objectsManager.EnabledObjects();
        objectsManager.miniGameActive = true;
    }

    public void EnableDialog()
    {
        CheckLimitMiniGame();
        Debug.Log(_dialog);
        panelDialog.gameObject.SetActive(true);
        panelDialogChanger.gameObject.SetActive(true);
    }
}