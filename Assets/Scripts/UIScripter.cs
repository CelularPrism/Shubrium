using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScripter : MonoBehaviour
{
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject endPanel;
    [SerializeField] private TextChangerScripter textChanger;

    private GameObject nowPanel;

    private void Start()
    {
        nowPanel = startPanel;
    }

    private void FixedUpdate()
    {
        if (Input.anyKeyDown && nowPanel != null)
        {
            if (nowPanel == endPanel)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            {
                nowPanel.SetActive(false);
                nowPanel = null;
            }
        }
    }

    public void EndGame()
    {
        textChanger.EndGame();
        nowPanel = endPanel;
        nowPanel.SetActive(true);
    }
}
