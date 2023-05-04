using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
  private int damage = 10;

  private void OnTriggerEnter2D(Collider2D collider){
    Debug.Log("You've been hit");
    GetComponent<AudioSource>().pitch = Random.Range(.8f, 1.1f);
    GetComponent<AudioSource>().Play();
    playerHealth hp = collider.GetComponent<playerHealth>();
    if(hp != null){
      hp.Damage(damage);
    }
  }
}
