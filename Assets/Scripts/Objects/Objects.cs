using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Objects : MonoBehaviour, ObjectsInterface
{
    public bool isActive { get; set; } = false;
    //[SerializeField] private ObjectsManager objectsManager;

    private GameObject _mainCharacter;

    private Transform _objectTransform;
    private Transform _mainCharacterTransform;

    private float _currentDistance;
    private float _previousDistance;

    public void Start()
    {
        //_mainCharacterTransform = GameObject.Find("Doctor").GetComponent<Transform>();
        _objectTransform = GetComponent<Transform>();
        Debug.Log(_objectTransform.transform.position);
    }

    public void OnMouseDown()
    {
        //isActive = true;
        //if (this.enabled)
            //_currentDistance = Vector3.Distance(_mainCharacterTransform.transform.position, _objectTransform.transform.position);
        //objectsManager.DisableActive(this);
        //GameObject ob
    }
    public virtual void OnTriggerEnter(Collider other)
    {

    }
    /*public void Update()
    {
        if (isActive)
        {
            _previousDistance = _currentDistance;
            _currentDistance = Vector3.Distance(_mainCharacterTransform.transform.position, _objectTransform.transform.position);

            if (_currentDistance > _previousDistance)
            {
                isActive = false;
                Debug.Log("Is Active = " + isActive);
            }
        }
    }*/
}
