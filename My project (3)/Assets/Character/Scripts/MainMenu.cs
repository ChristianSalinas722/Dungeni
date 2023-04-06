using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject options;
    public GameObject Menu;
public void Start(){
    options.SetActive(false);
    Menu.SetActive(true);
}
   public void ChangeScence(string sceneName){
        PauseMenu.GameIsPaused = false;
        SceneManager.LoadScene(sceneName);
   } 
   public void  Quit(){
    Application.Quit();
    Debug.Log("Game Has Ended");
   }

}
