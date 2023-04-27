using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
  private int damage = 10;

  private void OnTriggerEnter2D(Collider2D collider){
   
    Health hp = collider.GetComponent<Health>();
    if(hp != null){
      hp.Damage(damage);
    }
  }
}
