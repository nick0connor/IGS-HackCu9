using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){

        // This is how you advance to the next scene in the queue
        // The queue order is decided by File->Build Settings
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame(){
        Debug.Log("QUIT THE GAME!");
        Application.Quit();
    }
}
