using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerPuzzle : MonoBehaviour
{
    public bool cabezaOK = false;
    public bool ojosOK = false;
    public bool bocaOK = false;
    public bool ropaOK = false;

    public bool correct = false;
    public int vidas = 3;

    // Update is called once per frame
    void Update()
    {
        if (cabezaOK && ojosOK && bocaOK && ropaOK)
        {
            correct = true;
        }
        else
        {
            correct = false;
        }

        if (vidas <= 0)
        {
            print("PERDISTE");
        }
    }

    public void Corregir()
    {
        if (correct)
        {
            print("GANASTE");
        }
        else
        {
            vidas--;
            print("-1 VIDA");
        }
    }
}
