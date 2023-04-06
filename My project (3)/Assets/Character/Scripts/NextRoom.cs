using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextRoom : MonoBehaviour
{
    [SerializeField] private string sceneName;
    public void OnTriggerEnter2D(Collider2D other){
        SceneManager.LoadScene(sceneName);
   } 
}
