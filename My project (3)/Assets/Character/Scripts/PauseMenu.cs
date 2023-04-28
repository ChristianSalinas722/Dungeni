using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private string Menu;
    
   public static bool GameIsPaused = false;
   public GameObject pauseMenuUi;

   public GameObject HealthBar;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }
    public void Resume(){
        pauseMenuUi.SetActive(false);
        HealthBar.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause(){
        pauseMenuUi.SetActive(true);
        HealthBar.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu(){
        Debug.Log("Loading menu");
       Time.timeScale = 1f;
        SceneManager.LoadScene(Menu);
    }
    public void QuitGame(){
        Debug.Log("Quitting Game");
        Application.Quit();
    }
}
