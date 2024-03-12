using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public UnityEvent OnRestart;
    public static void QuitToMainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void RestartGame()
    {
        OnRestart?.Invoke();
    }
}
