using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChangerScripter : MonoBehaviour
{
    [SerializeField] private Text endGame;
    [SerializeField] private Text thanksGame;
    [SerializeField] private float timeNextChar;

    private Text _nowTextField;
    private string _nowText = "";

    private string _textEnd = "END GAME";
    private string _textThanks = "Thanks for playing";

    private int _indexString = 0;
    private float _time = 0f;

    void Update()
    {
        if (_nowText != "")
        {
            if (_nowTextField.text != _textThanks)
            {
                if (_indexString < _nowText.Length)
                {
                    if (_time + timeNextChar < Time.time)
                    {
                        _nowTextField.text += _nowText[_indexString];
                        _time = Time.time;
                        _indexString++;
                    }
                }
                else
                {
                    _indexString = 0;
                    _nowText = _textThanks;
                    _nowTextField = thanksGame;
                    //timeNextChar /= 2;
                }
            }
        }
    }

    public void EndGame()
    {
        _nowText = _textEnd;
        _nowTextField = endGame;
        _time = Time.time;
    }
}
