using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Objects : MonoBehaviour, ObjectsInterface
{
    [SerializeField] protected ObjectsManager objectsManager;
    [SerializeField] protected GameObject checkPoint;
    public bool _isActive { get; set; } = false;
    public bool _isEnabled { get; set; }

    protected GameObject _mainCharacter;
    protected DoctorAnimator _mainCharacterAnimator;
    protected DoctorMovement _mainCharacterMovement;
    protected Transform _mainCharacterTransform;

    protected Light _objectLight;
    protected MeshRenderer _objectRender;

    protected Color _defaultObjectColor;
    protected Color _newObjectColor;

    public virtual void Awake()
    {
        _objectLight = GetComponent<Light>();
        _objectRender = GetComponent<MeshRenderer>();

        _defaultObjectColor = _objectRender.material.color; ;
    }
    public void Start()
    {
        _isEnabled = true;

        _mainCharacter = GameObject.Find("Doctor");
        _mainCharacterAnimator = _mainCharacter.GetComponent<DoctorAnimator>();
        _mainCharacterMovement = _mainCharacter.GetComponent<DoctorMovement>();
        _mainCharacterTransform = _mainCharacter.GetComponent<Transform>();
    }
    public virtual void OnMouseEnter()
    {
        _objectLight.enabled = true;
        _objectRender.material.color = _newObjectColor;
    }
    public virtual void OnMouseExit()
    {
        _objectLight.enabled = false;
        _objectRender.material.color = _defaultObjectColor;
    }
    public virtual void OnMouseDown()
    {
        _isActive = true;
        objectsManager.DisableActive(this);  // this function also calls the method SetPoint from PlayerMovement
    }
    public virtual void OnTriggerEnter(Collider other)
    {
        _mainCharacterTransform.position = new Vector3(_mainCharacterTransform.position.x, _mainCharacterTransform.position.y, transform.position.z);
        _mainCharacterMovement.AllowedMove = false;

        _isActive = false;
    }
    public Vector3 GetPoint()
    {
        return checkPoint.transform.position;
    }
}
