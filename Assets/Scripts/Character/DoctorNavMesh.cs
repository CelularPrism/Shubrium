using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DoctorNavMesh : MonoBehaviour
{
    private NavMeshAgent _myNavMeshAgent;

    private LayerMask _interactableLayerMask;

    private void Awake()
    {
        _myNavMeshAgent = GetComponent<NavMeshAgent>();

        _interactableLayerMask = 1 << 7; //layer seven for interactable object
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SetDestinationToMousePosition();
        }
    }
    void SetDestinationToMousePosition()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, _interactableLayerMask))
        {
            _myNavMeshAgent.SetDestination(hit.transform.GetChild(0).position);
        }
    }
}
