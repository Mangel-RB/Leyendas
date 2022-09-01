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
        print(numGuess);

        if (numGuess < 5)
        {

            switch (EventSystem.current.currentSelectedGameObject.name)
            {
                case "1":
                    guess[numGuess] = 1;
                    break;
                case "2":
                    guess[numGuess] = 2;
                    break;
                case "3":
                    guess[numGuess] = 3;
                    break;
                case "4":
                    guess[numGuess] = 4;
                    break;
                case "5":
                    guess[numGuess] = 5;
                    break;
                case "6":
                    guess[numGuess] = 6;
                    break;
                case "7":
                    guess[numGuess] = 7;
                    break;
                case "8":
                    guess[numGuess] = 8;
                    break;
                case "9":
                    guess[numGuess] = 9;
                    break;
                case "0":
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

    public void guessReset()
    {
        numGuess = 0;

        for (int i = 0; i < 5; ++i)
        {
            guess[i] = 0;
        }
    }

    public void takeGuess()
    {
        guessedNum = 0;

        for (int i = 0; i < 5; ++i)
        {
            guessedNum = guessedNum * 10 + guess[i];
        }

        print(guessedNum);

        if (guessedNum == solution) print("OLEEE");
        else guessedNum = 0;
    }

}
