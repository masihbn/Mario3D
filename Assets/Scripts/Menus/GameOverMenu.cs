using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }
}
