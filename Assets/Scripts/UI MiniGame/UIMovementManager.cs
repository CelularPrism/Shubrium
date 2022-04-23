using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMovementManager : MonoBehaviour
{
    [SerializeField] private RectTransform panel;
    [SerializeField] private Transform player;

    private Vector2 _rightUpCorner;
    private Vector2 _leftDownCorner;
    void Start()
    {
        float axisX = panel.localPosition.x + panel.sizeDelta.x / 2;
        float axisY = panel.localPosition.y + panel.sizeDelta.y / 2;

        _rightUpCorner = new Vector2(axisX, axisY);

        axisX = panel.localPosition.x - panel.sizeDelta.x / 2;
        axisY = panel.localPosition.y - panel.sizeDelta.y / 2;

        _leftDownCorner = new Vector2(axisX, axisY);
    }

    private void FixedUpdate()
    {
        //transform.position = new Vector3(player.position.x, transform.position.y, player.position.z);
    }

    public void ClickOnObject(Transform transform)
    {
        Debug.Log("Click on: " + transform.name);
    }

    public Vector2 GetNewPos(Vector2 nowPos)
    {
        float posX = Random.Range(_leftDownCorner.x, _rightUpCorner.x);
        float posY = Random.Range(_leftDownCorner.y, _rightUpCorner.y);

        Vector2 newPos = new Vector2(posX, posY);
        return newPos;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(_leftDownCorner, 10f);
        Gizmos.DrawSphere(_rightUpCorner, 10f);
    }
}
