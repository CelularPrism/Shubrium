using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private string _currentObjectName;

    public string CurrentObjectName
    {
        get { return _currentObjectName; }
        set { _currentObjectName = value;  }
    }    
}
