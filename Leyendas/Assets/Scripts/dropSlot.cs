using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dropSlot : MonoBehaviour, IDropHandler
{
    public GameObject item;

    private void Start()
    {
        
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragAndDrop.itemDragging;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
        }
    }

    private void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
        }
    }

}
