using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDialogChanger : MonoBehaviour
{
    [SerializeField] private GameObject textGameobject;
    [SerializeField] private float timeSpeed;
    public string oldText;

    private Text textField;
    private int indexText;

    private float time;

    private void Start()
    {
        textField = textGameobject.GetComponent<Text>();
        time = Time.time;
        indexText = 0;
    }

    private void FixedUpdate()
    {
        if (textField.text != oldText && indexText <= oldText.Length - 1)
        {
            if (time + timeSpeed < Time.time)
            {
                time = Time.time;
                textField.text += oldText[indexText];
                indexText++;
            }
        }
    }

    public bool CheckNowText()
    {
        string text = textField.text.Substring(2);
        if (text == oldText)
            return true;
        else
        {
            textField.text = "- " + oldText;
            indexText = oldText.Length;
        }
        return false;
    }

    public void SetNewText(string text)
    {
        if (oldText != text)
        {
            if (textField == null)
                textField = textGameobject.GetComponent<Text>();
            textField.text = "- ";
            oldText = text;
            indexText = 0;
            /*StopAllCoroutines();
            StartCoroutine(ChangeText(text));*/
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
