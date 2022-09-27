using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject code1, code2;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OpenCode(string codeNum)
    {
        switch (codeNum)
        {
            case "1":
                code1.SetActive(true);
                code2.SetActive(false);
                break;
            case "2":
                code2.SetActive(true);
                code1.SetActive(false);
                break;
        }
    }

    public void LeaveGame()
    {
        Application.Quit();
    }
}
