using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMax : MonoBehaviour
{
    public GameObject parent, sibling_1, Sibling_2, sibling_3, maxImg;

    public void PhotoButton()
    {
            maxImg.SetActive(true);
            sibling_1.SetActive(false);
            Sibling_2.SetActive(false);
            sibling_3.SetActive(false);
            parent.SetActive(false);
    }
}
