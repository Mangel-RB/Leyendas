using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dropSlot : MonoBehaviour, IDropHandler
{
    public GameObject item;

    public bool funciona = false;


    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragAndDrop.itemDragging;
            item.transform.SetParent(transform);
        }
    }

    private void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
            //Añadido para resolver el puzle
            funciona = false;
        }

        //Añadido para resolver el puzle, ampliar
        if (item != null && item.transform.parent == transform && item.tag == "Ojos")
        {
            funciona = true;
        }
    }

}