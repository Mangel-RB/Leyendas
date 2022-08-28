using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsMorgue : MonoBehaviour
{
    public GameObject Photo1, Photo2, Photo3, Photo4;
    public GameObject Children1_1, Children1_2, Children1_3, Children2_1, Children2_2, Children2_3,
                      Children3_1, Children3_2, Children3_3, Children4_1, Children4_2, Children4_3;
    public bool active = false;

    public void Photo1Button()
    {
        if (!active)
        {
            Children1_1.SetActive(true);
            Children1_2.SetActive(true);
            Children1_3.SetActive(true);
            Photo2.SetActive(false);
            Photo3.SetActive(false);
            Photo4.SetActive(false);

            active = true;

        }else
        {
            Children1_1.SetActive(false);
            Children1_2.SetActive(false);
            Children1_3.SetActive(false);
            Photo2.SetActive(true);
            Photo3.SetActive(true);
            Photo4.SetActive(true);

            active = false;

        }
    }

    public void Photo2Button()
    {
        if (!active)
        {
            Children2_1.SetActive(true);
            Children2_2.SetActive(true);
            Children2_3.SetActive(true);
            Photo1.SetActive(false);
            Photo3.SetActive(false);
            Photo4.SetActive(false);

            active = true;

        }
        else
        {
            Children2_1.SetActive(false);
            Children2_2.SetActive(false);
            Children2_3.SetActive(false);
            Photo1.SetActive(true);
            Photo3.SetActive(true);
            Photo4.SetActive(true);

            active = false;

        }
    }

    public void Photo3Button()
    {
        if (!active)
        {
            Children3_1.SetActive(true);
            Children3_2.SetActive(true);
            Children3_3.SetActive(true);
            Photo2.SetActive(false);
            Photo1.SetActive(false);
            Photo4.SetActive(false);

            active = true;

        }
        else
        {
            Children3_1.SetActive(false);
            Children3_2.SetActive(false);
            Children3_3.SetActive(false);
            Photo2.SetActive(true);
            Photo1.SetActive(true);
            Photo4.SetActive(true);

            active = false;

        }
    }

    public void Photo4Button()
    {
        if (!active)
        {
            Children4_1.SetActive(true);
            Children4_2.SetActive(true);
            Children4_3.SetActive(true);
            Photo2.SetActive(false);
            Photo3.SetActive(false);
            Photo1.SetActive(false);

            active = true;

        }
        else
        {
            Children4_1.SetActive(false);
            Children4_2.SetActive(false);
            Children4_3.SetActive(false);
            Photo2.SetActive(true);
            Photo3.SetActive(true);
            Photo1.SetActive(true);

            active = false;

        }
    }
}