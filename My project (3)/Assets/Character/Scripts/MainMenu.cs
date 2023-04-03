using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void ChangeScence(string sceneName){
        SceneManager.LoadScene(sceneName);
   } 
   public void  Quit(){
    Application.Quit();
    Debug.Log("Game Has Ended");
   }
}
