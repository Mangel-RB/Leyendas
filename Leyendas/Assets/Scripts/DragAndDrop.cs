using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public static GameObject itemDragging;

    Vector3 startPosition;
    Transform startParent;
    Transform dragParent;

    private void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("InBeginDrag");
        itemDragging = gameObject;

        startPosition = transform.position;
        startParent = transform.parent;
        transform.SetParent(dragParent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        itemDragging = null;

        if (transform.parent == dragParent)
        {
            //if (transform.position.x > 270)
            //{
            //    transform.position = new Vector3(270f, Input.mousePosition.y, transform.position.z);
            //}

            //else if (transform.position.x < -270)
            //{
            //    transform.position = new Vector3(-270f, Input.mousePosition.y, transform.position.z);
            //}

            //else if (transform.position.y > 60)
            //{
            //    transform.position = new Vector3(Input.mousePosition.x, 60, transform.position.z);
            //}

            //else if (transform.position.y < -280)
            //{
            //    transform.position = new Vector3(Input.mousePosition.x, -280f, transform.position.z);
            //}

            //else
            //{
            //    transform.position = Input.mousePosition;
            //}

            transform.position = Input.mousePosition;
            transform.SetParent(startParent);
        }
    }

}
