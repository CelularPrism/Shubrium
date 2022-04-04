using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChangerScripter : MonoBehaviour
{
    [SerializeField] private Text endGame;
    [SerializeField] private Text thanksGame;

    private string _textEnd = "END GAME";
    private string _textThanks = "Thanks for playing";

    private string _nowText = "";

    private void Start()
    {
        _nowText = _textEnd;
    }

    void Update()
    {
        
    }
}
