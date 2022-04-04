using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorAnimator : MonoBehaviour
{
    [SerializeField] private string _dialogScript; //����� ������ �� ������ (�������� string �� ��� �������), ������� �������� ������ �������;
    [SerializeField] private string _audioManager; //����� ������ �� ������ (�������� string �� ��� �������), ������� ��������� �������� �������� ��������;

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
    }
    public void PutThePhoneDown()
    {
        Debug.Log("_audioManager.PlaySound(PutThePhoneDown)");
    }
    #endregion
}
