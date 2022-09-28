using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenuScript : MonoBehaviour
{
    public bool cabezaOK = false;
    public bool ojosOK = false;
    public bool bocaOK = false;
    public bool ropaOK = false;

    public bool correct = false;

    void Update()
    {
        print(cabezaOK);
        if (cabezaOK && ojosOK && bocaOK && ropaOK)
        {
            correct = true;
        }
        else
        {
            correct = false;
        }
    }

    public void BTM()
    {
        if(correct) SceneManager.LoadScene("Menu");
    }
}
