using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ButtonsMorgue : MonoBehaviour
{
    public GameObject Photo1, Photo2, Photo3, Photo4, solutionPanel, solutionButton1, solutionButton2;
    public GameObject Children1_1, Children1_2, Children1_3, Children2_1, Children2_2, Children2_3,
                      Children3_1, Children3_2, Children3_3, Children4_1, Children4_2, Children4_3;
    public bool active = false;
    public int solution, guessedNum;
    public int[] guess = new int[5];
    public int numGuess = 0;

    #region NumberImages

    public GameObject[] Numb1 = new GameObject[10];
    public GameObject[] Numb2 = new GameObject[10];
    public GameObject[] Numb3 = new GameObject[10];
    public GameObject[] Numb4 = new GameObject[10];
    public GameObject[] Numb5 = new GameObject[10];

    #endregion

    public void Start()
    {
        guessReset();
    }

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
            solutionButton1.SetActive(false);

            active = true;

        }else
        {
            Children1_1.SetActive(false);
            Children1_2.SetActive(false);
            Children1_3.SetActive(false);
            Photo2.SetActive(true);
            Photo3.SetActive(true);
            Photo4.SetActive(true);
            solutionButton1.SetActive(true);

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
            solutionButton1.SetActive(false);

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
            solutionButton1.SetActive(true);

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
            solutionButton1.SetActive(false);

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
            solutionButton1.SetActive(true);

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
            solutionButton1.SetActive(false);

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
            solutionButton1.SetActive(true);

            active = false;

        }
    }

    public void SolutionButton()
    {
        guessReset();

        if (!active)
        {
            Photo1.SetActive(false);
            Photo2.SetActive(false);
            Photo3.SetActive(false);
            Photo4.SetActive(false);
            solutionPanel.SetActive(true);
            solutionButton1.SetActive(false);
            solutionButton2.SetActive(true);

            active = true;
        }
        else
        {
            Photo1.SetActive(true);
            Photo2.SetActive(true);
            Photo3.SetActive(true);
            Photo4.SetActive(true);
            solutionPanel.SetActive(false);
            solutionButton1.SetActive(true);
            solutionButton2.SetActive(false);

            active = false;
        }
    }

    public void CodeButton()
    {
        if (numGuess < 5)
        {

            switch (EventSystem.current.currentSelectedGameObject.name)
            {
                case "1":
                    PrintNumbers(1, numGuess);
                    guess[numGuess] = 1;
                    break;
                case "2":
                    PrintNumbers(2, numGuess);
                    guess[numGuess] = 2;
                    break;
                case "3":
                    PrintNumbers(3, numGuess);
                    guess[numGuess] = 3;
                    break;
                case "4":
                    PrintNumbers(4, numGuess);
                    guess[numGuess] = 4;
                    break;
                case "5":
                    PrintNumbers(5, numGuess);
                    guess[numGuess] = 5;
                    break;
                case "6":
                    PrintNumbers(6, numGuess);
                    guess[numGuess] = 6;
                    break;
                case "7":
                    PrintNumbers(7, numGuess);
                    guess[numGuess] = 7;
                    break;
                case "8":
                    PrintNumbers(8, numGuess);
                    guess[numGuess] = 8;
                    break;
                case "9":
                    PrintNumbers(9, numGuess);
                    guess[numGuess] = 9;
                    break;
                case "0":
                    PrintNumbers(0, numGuess);
                    guess[numGuess] = 0;
                    break;
            }

            ++numGuess;
        }
        else
        {
            guessReset();
        }
    }

    public void PrintNumbers(int number, int numGuess)
    {
        switch (numGuess)
        {
            case 0:
                Numb1[0].SetActive(false);
                Numb1[number].SetActive(true);
                break;
            case 1:
                Numb2[0].SetActive(false);
                Numb2[number].SetActive(true);
                break;
            case 2:
                Numb3[0].SetActive(false);
                Numb3[number].SetActive(true);
                break;
            case 3:
                Numb4[0].SetActive(false);
                Numb4[number].SetActive(true);
                break;
            case 4:
                Numb5[0].SetActive(false);
                Numb5[number].SetActive(true);
                break;
        }
    }

    public void guessReset()
    {
        numGuess = 0;
        guessedNum = 0;

        for (int i = 0; i < 5; ++i)
        {
            guess[i] = 0;
        }

        for (int i = 0; i < 10; ++i)
        {
            if(i == 0) Numb1[i].SetActive(true);
            else Numb1[i].SetActive(false);
        }

        for (int i = 0; i < 10; ++i)
        {
            if (i == 0) Numb2[i].SetActive(true);
            else Numb2[i].SetActive(false);
        }

        for (int i = 0; i < 10; ++i)
        {
            if (i == 0) Numb3[i].SetActive(true);
            else Numb3[i].SetActive(false);
        }

        for (int i = 0; i < 10; ++i)
        {
            if (i == 0) Numb4[i].SetActive(true);
            else Numb4[i].SetActive(false);
        }

        for (int i = 0; i < 10; ++i)
        {
            if (i == 0) Numb5[i].SetActive(true);
            else Numb5[i].SetActive(false);
        }
    }

    public void takeGuess(string sceneName)
    {
        for (int i = 0; i < 5; ++i)
        {
            guessedNum = guessedNum * 10 + guess[i];
        }

        if (guessedNum == solution) SceneManager.LoadScene(sceneName);
        else guessReset();
    }

}
