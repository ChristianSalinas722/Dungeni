using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    private GameObject attackArea = default;

    private bool isAttack = false;
    public Animator animator;

    private float timeToAttack = 0.25f;
    private float timer = 0f;
    private void Start(){
        attackArea = transform.GetChild(0).gameObject;
    }
    // Update is called once per frame
    private void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space)){
        Attack();
         GetComponent<AudioSource>().pitch = Random.Range(.8f, 1.1f);
         GetComponent<AudioSource>().Play();
      }
      if(isAttack){
        timer += Time.deltaTime;
        if(timer >= timeToAttack){
            timer = 0;
            isAttack = false;
            attackArea.SetActive(isAttack);
        }
      }
    }
    private void Attack(){
        isAttack = true;
        attackArea.SetActive(isAttack);
    }
}
