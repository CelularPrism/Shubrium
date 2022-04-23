using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] private Phone phone;
    private void OnTriggerEnter(Collider other)
    {
        phone.StartDialog();
    }
}
