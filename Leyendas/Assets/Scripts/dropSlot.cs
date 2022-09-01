using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dropSlot : MonoBehaviour, IDropHandler
{
    public GameObject item;

    public bool funciona = false;

    public bool cabezaOK = false;
    public bool ojosOK = false;
    public bool bocaOK = false;
    public bool ropaOK = false;

    public GameManagerPuzzle gmp;


    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragAndDrop.itemDragging;
            item.transform.SetParent(transform);
            item.transform.position = item.transform.parent.position;
        }
    }

    private void Update()
    {
        if (item != null && item.transform.parent != transform && item.tag == "Ojos" && tag == "SlotOjos")
        {
            item = null;
            //Añadido para resolver el puzle
            gmp.ojosOK = false;
        }

        //Añadido para resolver el puzle, ampliar
        if (item != null && item.transform.parent == transform && item.tag == "Ojos" && tag == "SlotOjos")
        {
            gmp.ojosOK = true;
        }

        if (item != null && item.transform.parent != transform && item.tag == "Cabeza" && tag == "SlotCabeza")
        {
            item = null;
            //Añadido para resolver el puzle
            gmp.cabezaOK = false;
        }

        //Añadido para resolver el puzle, ampliar
        if (item != null && item.transform.parent == transform && item.tag == "Cabeza" && tag == "SlotCabeza")
        {
            gmp.cabezaOK = true;
        }

        if (item != null && item.transform.parent != transform && item.tag == "Boca" && tag == "SlotBoca")
        {
            item = null;
            //Añadido para resolver el puzle
            gmp.bocaOK = false;
        }

        //Añadido para resolver el puzle, ampliar
        if (item != null && item.transform.parent == transform && item.tag == "Boca" && tag == "SlotBoca")
        {
            gmp.bocaOK = true;
        }

        if (item != null && item.transform.parent != transform && item.tag == "Ropa" && tag == "SlotRopa")
        {
            item = null;
            //Añadido para resolver el puzle
            gmp.ropaOK = false;
        }

        //Añadido para resolver el puzle, ampliar
        if (item != null && item.transform.parent == transform && item.tag == "Ropa" && tag == "SlotRopa")
        {
            gmp.ropaOK = true;
        }
    }



}