using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaximizedScript : MonoBehaviour
{
    public GameObject parent, sibling_1, Sibling_2, sibling_3, uvImg, bisturiImg, maxImg;
    public GameObject eventSystem;

    public void MaxButton()
    {
        sibling_1.SetActive(true);
        Sibling_2.SetActive(true);
        sibling_3.SetActive(true);
        parent.SetActive(true);
        gameObject.SetActive(false);
    }

    public void UVButton()
    {
        if (!uvImg.activeInHierarchy)
        {
            maxImg.SetActive(false);
            bisturiImg.SetActive(false);
            uvImg.SetActive(true);
        }
        else
        {
            maxImg.SetActive(true);
            bisturiImg.SetActive(false);
            uvImg.SetActive(false);
        }
    }

    public void BisturiButton()
    {
        if (!bisturiImg.activeInHierarchy)
        {
            maxImg.SetActive(false);
            uvImg.SetActive(false);
            bisturiImg.SetActive(true);
        }
        else
        {
            maxImg.SetActive(true);
            uvImg.SetActive(false);
            bisturiImg.SetActive(false);
        }
    }
}
