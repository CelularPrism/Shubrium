using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScripter : MonoBehaviour
{
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject endPanel;

    private GameObject nowPanel;

    private void Start()
    {
        nowPanel = startPanel;
    }

    private void FixedUpdate()
    {
        if (Input.anyKeyDown && nowPanel != null)
        {
            nowPanel.SetActive(false);
            nowPanel = null;
        }
    }

    public void EndGame()
    {
        nowPanel = endPanel;
        nowPanel.SetActive(true);
    }
}
