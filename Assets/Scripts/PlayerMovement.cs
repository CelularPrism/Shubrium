using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    public bool isMove;
    private Vector3 _point;

    void Start()
    {
        isMove = false;
    }

    void Update()
    {
        if (isMove)
        {
            if (transform.position.x != _point.x)
            {
                float posX = Vector3.MoveTowards(transform.position, _point, speed).x;

                transform.position = new Vector3(posX, transform.position.y, transform.position.z);
            } 
            else
            {
                isMove = false;
            }
        }
    }

    public void SetPoint(Vector3 point)
    {
        _point = point;
        isMove = true;
    }
}
