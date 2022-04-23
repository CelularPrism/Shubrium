using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorAnimator : MonoBehaviour
{
    [SerializeField] private ObjectsManager _objectsManager;
    [SerializeField] private AudioPhoneManager _audioManager;
    [SerializeField] private Phone _phone;
    [SerializeField] private Chair _chair;
    [SerializeField] private GameObject _doctor;

    private Animator _myAnimator;

    private DoctorMovement _doctorMovement;

    public Animator DoctorAnimatorController    
    {
        get { return _myAnimator; }
    }

    private void Awake()
    {
        _myAnimator = GetComponent<Animator>();

        _doctorMovement = _doctor.GetComponent<DoctorMovement>();
    }

    public void StartDialog() //call from script pickupphone, when mouse button down
    {
        _myAnimator.SetTrigger("Calling"); //It is parameters from previous version of animator controller
    }
    
    public void FinishDialog() //call from script dialogscripter
    {
        _myAnimator.SetTrigger("EndOfCall"); //It is parameters from previous version of animator controller
    }
    public void GoToTarget()
    {
        _myAnimator.SetTrigger("Moving");
    }
    #region Events from animation
    public void PickUpPhone() // Events from animation "Take the phone"
    {
        Debug.Log("_audioManager.PlaySound(PickUpPhone)");
        _audioManager.PickUp();
        _phone.PickUp();
    }
    public void PutThePhoneDown() //Events from animation "Put the phone"
    {
        Debug.Log("_audioManager.PlaySound(PutThePhoneDown)");
        _audioManager.PutDown();
        FinishAllAnimation();
    }
    public void FinishAllAnimation() //Events from animation "DrinkCoffee" (end) and "Standing" (en)
    {
        _objectsManager.EnabledObjects();
        if(DoctorAnimatorController.GetCurrentAnimatorStateInfo(0).IsName("PutThePhone"))
        {
            _chair._isEnabled = false;
        }
        _doctorMovement.SetRotation();
    }
    #endregion
}
