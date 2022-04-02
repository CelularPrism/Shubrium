using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDialogChanger : MonoBehaviour
{
    [SerializeField] private GameObject textGameobject;

    private Text textField;
    private string oldText;

    private void Start()
    {
        textField = textGameobject.GetComponent<Text>();
    }

    public bool CheckNowText()
    {
        if (textField.text == oldText)
            return true;
        return false;
    }

    public bool CheckOldText(string text)
    {
        if (oldText == text)
            return true;

        return false;
    }

    public void SetNewText(string text)
    {
        if (oldText != text)
        {
            oldText = text;
            StopAllCoroutines();
            StartCoroutine(ChangeText(text));
        }
    }

    IEnumerator ChangeText(string text)
    {
        textField.text = "";
        foreach (char ch in text)
        {
            textField.text += ch;
            yield return null;
        }
    }
}
