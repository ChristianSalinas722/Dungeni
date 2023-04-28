using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerHealth : MonoBehaviour
{
    [SerializeField] private int hp = 100;
    public Slider slider;
      

    private int MAX_HEALTH = 100;

     void Update(){
        if(Input.GetKeyDown(KeyCode.D)){
           // Damage(10);
        }
        if(Input.GetKeyDown(KeyCode.H)){
           // Heal(10);
        }
    }
    public void SetHealth(){
        slider.value = hp;
    }
     public void Damage(int amount){
     if(amount < 0){
         throw new System.ArgumentOutOfRangeException("Your attack did nothing mortal");
        }
        this.hp -= amount;
        SetHealth();
        if(hp <= 0){
            
            Die();
        }
    }
     public void Heal(int amount){
     if(amount < 0){
        throw new System.ArgumentOutOfRangeException("Your Healing failed");
     }
        bool isOverMaxHealth = hp + amount > MAX_HEALTH;
        if(isOverMaxHealth){
         this.hp = MAX_HEALTH;
        }
        else{
            this.hp += amount;   
        }
        SetHealth();
    }
     private void Die(){
        Debug.Log("I am Dead");
        Destroy(gameObject);
    }
}
