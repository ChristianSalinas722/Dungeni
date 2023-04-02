using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    private GameObject attackArea = default;

    private bool isAttack = false;

    private float timeToAttack = 0.25f;
    private float timer = 0f;
    void Start(){
        attackArea = transform.GetChild(0).gameObject;
    }
    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.RightClick)){
        Attack();
      }
      if(isAttack){
        timer += timer.deltaTime;
        if(time >= timeToAttack){
            timer = 0;
            isAttack = false;
            attackArea.SetActive();
        }
      }
    }
    private void Attack(){
        isAttack = true;
        attackArea.SetActive(isAttack);
    }
}
