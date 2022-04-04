using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorAnimator : MonoBehaviour
{
    [SerializeField] private string _dialogScript; //Здесь ссылка на скрипт (заменить string на тип скрипта), который вызывает начало диалога;
    [SerializeField] private string _audioManager; //Здесь ссылка на скрипт (заменить string на тип скрипта), который управляет запуском звуковых эффектов;

    private Animator _myAnimator;

    private void Awake()
    {
        _myAnimator = GetComponent<Animator>();
    }
    public void StartDialog()
    {
        _myAnimator.SetTrigger("Calling");
    }

    public void FinishDialog() //Должен вызываться из _dialogScript, когда завершиться диалог
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
