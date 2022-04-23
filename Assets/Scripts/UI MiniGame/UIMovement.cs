using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMovement : MonoBehaviour
{
    [SerializeField] private UIMovementManager movementManager;
    [SerializeField] private float speed;
    private Vector3 _newPos;
    private RectTransform _trans;

    private void Start()
    {
        _trans = transform.GetComponent<RectTransform>();
        _newPos = movementManager.GetNewPos(_trans.localPosition);
    }

    void Update()
    {
        if (_trans.localPosition != _newPos)
        {
            _trans.localPosition = Vector3.MoveTowards(_trans.localPosition, _newPos, speed * Time.deltaTime);
        } else
        {
            _newPos = movementManager.GetNewPos(_trans.localPosition);
        }
    }
}
