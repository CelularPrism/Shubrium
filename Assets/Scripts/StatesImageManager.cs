using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatesImageManager : MonoBehaviour
{
    [SerializeField] private Image imageState;
    [SerializeField] private Sprite[] spritesState;
    private int _nowIndexState;

    void Start()
    {
        _nowIndexState = 0;
    }

    private void SetSprite()
    {
        imageState.sprite = spritesState[_nowIndexState];
    }

    public void SetNextState()
    {
        if (_nowIndexState < spritesState.Length - 1)
            _nowIndexState++;
        SetSprite();
    }

    public void SetPrevState()
    {
        if (_nowIndexState > 0)
            _nowIndexState--;
        SetSprite();
    }
}
