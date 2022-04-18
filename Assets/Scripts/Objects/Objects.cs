using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Objects : MonoBehaviour, ObjectsInterface
{
    [SerializeField] private ObjectsManager objectsManager;
    public bool _isActive { get; set; } = false;
    public bool _isEnabled { get; set; }

    protected GameObject _mainCharacter;

    private Transform _objectTransform;
    private Transform _mainCharacterTransform;

    private float _currentDistance;
    private float _previousDistance;

    public void Start()
    {
        _isEnabled = true;
        _mainCharacterTransform = GameObject.Find("Doctor").GetComponent<Transform>();
        _objectTransform = GetComponent<Transform>();
        Debug.Log(_objectTransform.transform.position);
    }

    public virtual void OnMouseDown()
    {
        if (_isEnabled)
        {
            _isActive = true;
            if (this.enabled)
                _currentDistance = Vector3.Distance(_mainCharacterTransform.transform.position, _objectTransform.transform.position);
            objectsManager.DisableActive(this);
        }
    }
    public virtual void OnTriggerEnter(Collider other)
    {

    }

    public Vector3 GetPoint()
    {
        return transform.position;
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
