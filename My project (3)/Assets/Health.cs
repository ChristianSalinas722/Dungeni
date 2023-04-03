using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

     void Update(){
        if(Input.GetKeyDown(KeyCode.D)){
            Damage(10);
        }
        if(Input.GetKeyDown(KeyCode.H));
    }
     public void Damage(int amount){
     if(amount < 0){
         throw new System.ArgumentOutOfRangeException("Your attack did nothing mortal");
        }
        this.hp -= amount;
    }
     public void Heal(int amount){
     if(amount < 0){
        throw new System.ArgumentOutOfRangeException("Your Healing failed");
     }
        bool isOverMaxHealth = hp + amount > MAX_HEALTH;
        if(hp + amount > MAX_HEALTH){
         this.hp = MAX_HEALTH;
        }
        else{
            this.hp += amount;   
        }
    }
     private void Die(){
        Debug.Log("I am Dead");
        Destroy(gameObject);
    }
}

