using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablerScripts : MonoBehaviour
{
    private bool _isPause;

    private void Start()
    {
        _isPause = false;
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_isPause)
            {
                Time.timeScale = 1;
                Debug.Log("Return");
            }
            else
            {
                Time.timeScale = 0;
                Debug.Log("Pause");
            }

            _isPause = !_isPause;
        }
    }
}
