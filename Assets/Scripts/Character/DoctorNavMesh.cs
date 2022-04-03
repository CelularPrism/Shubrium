using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DoctorNavMesh : MonoBehaviour
{
    [SerializeField] private float maxDistance;
    public bool isMove = false;
    private NavMeshAgent _myNavMeshAgent;

    private LayerMask _interactableLayerMask;
    private Vector3 posTransform;

    private void Awake()
    {
        _myNavMeshAgent = GetComponent<NavMeshAgent>();
        posTransform = transform.position;

        _interactableLayerMask = 1 << 7; //layer seven for interactable object
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SetDestinationToMousePosition();
        }
        float distance = Vector3.Distance(transform.position, posTransform);
        if(distance <= maxDistance)
        {
            isMove = false;
        } else
        {
            isMove = true;
        }
    }
    void SetDestinationToMousePosition()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, _interactableLayerMask))
        {
            posTransform = hit.transform.GetChild(0).position;
            _myNavMeshAgent.SetDestination(posTransform);
        }
    }
}
