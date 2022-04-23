using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DoctorMovement : MonoBehaviour
{
    [SerializeField] private float maxDistance = 0.005f;
    [SerializeField] private float speed = 0.5f;

    [SerializeField] private bool _movingAllowed;

    private DoctorAnimator _myCharacterAnimator;
    private CharacterController _myCharacterController; //delete, if it isn't used

    private Vector3 _targetPosition;

    public bool AllowedMove
    {
        set { _movingAllowed = value; }
    }

    private void Awake()
    {
        _movingAllowed = false;
        
        _myCharacterController = GetComponent<CharacterController>();
        _myCharacterAnimator = GetComponent<DoctorAnimator>();
    }
    void Update()
    {
        if (_movingAllowed)
        {
            if (_myCharacterAnimator.DoctorAnimatorController.GetCurrentAnimatorStateInfo(0).IsName("Moving") && (Vector3.Distance(transform.position, _targetPosition) > maxDistance))
            {
                float step = speed * Time.deltaTime;
                float newZPos = Vector3.MoveTowards(transform.position, _targetPosition, step).z;

                Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, newZPos);
                transform.LookAt(newPosition);
                transform.position = newPosition;
            }
            //else
            //{
            //    _movingAllowed = false;
            //}
        }
    }
    public void SetRotation()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0f, -90f, 0f));
        //transform.LookAt(Camera.main.transform.position);
    }
    public void SetPoint(Vector3 point)
    {
        _targetPosition = point;
        _movingAllowed = true;
    }
}
