using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    private Queue<string> _dialogue;

    private bool _dialogueIsPlaying;

    private Text _name, _message, _answer1, _answer2, _answer3;

    private void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
