using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorAnimator : MonoBehaviour
{
    //[SerializeField] private DialogManager _dialogScript; //����� ������ �� ������ (�������� string �� ��� �������), ������� �������� ������ �������;
    [SerializeField] private AudioPhoneManager _audioManager; //����� ������ �� ������ (�������� string �� ��� �������), ������� ��������� �������� �������� ��������;
    [SerializeField] private Phone _phone;

    private Animator _myAnimator;

    private void Awake()
    {
        _myAnimator = GetComponent<Animator>();
    }

    public void StartDialog()
    {
        _myAnimator.SetTrigger("Calling");
    }
    
    public void FinishDialog() //������ ���������� �� _dialogScript, ����� ����������� ������
    {
        _myAnimator.SetTrigger("EndOfCall");
    }
    #region Events from animation
    public void PickUpPhone()
    {
        Debug.Log("_audioManager.PlaySound(PickUpPhone)");
        _audioManager.PickUp();
        _phone.PickUp();
    }
    public void PutThePhoneDown()
    {
        Debug.Log("_audioManager.PlaySound(PutThePhoneDown)");
        _audioManager.PutDown();
    }
    #endregion
}
