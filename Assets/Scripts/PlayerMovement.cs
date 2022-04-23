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
            if (transform.position.z != _point.z)
            {
                float pos = Vector3.MoveTowards(transform.position, _point, speed).z;

                transform.position = new Vector3(transform.position.x, transform.position.y, pos);
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
