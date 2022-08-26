using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dropOut : MonoBehaviour, IDropHandler
{
    public GameObject item;

    public void OnDrop(PointerEventData eventData)
    {
        print("aaaaaaaaah");
        if (!item)
        {
            print("uuuuh");
            item = DragAndDrop.itemDragging;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
        }
    }

}