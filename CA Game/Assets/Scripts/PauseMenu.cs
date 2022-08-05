using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI; //Reference to the pause UI so we can control it. 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameIsPaused) //If the game is already paused - so if GameIsPaused is equal to true. 
            {
                Resume();
            }
            else  //If the game is not paused, resume it. 
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true); //Activates pause menu UI
        Time.timeScale = 0f;  //freezes time
        GameIsPaused = true; //sets boolean to true so the game knows it is currently paused.
    }
    public void Resume () //set it to public so it cn be used w/ the "Resume" button.
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void LoadMenu ()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Debug.Log("Game quit");
        Application.Quit();
    }
}
