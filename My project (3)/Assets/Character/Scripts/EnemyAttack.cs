using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
  private int damage = 10;

  private void OnTriggerEnter2D(Collider2D collider){
    Debug.Log("You've been hit");
    playerHealth hp = collider.GetComponent<playerHealth>();
    if(hp != null){
      hp.Damage(damage);
    }
  }
}
