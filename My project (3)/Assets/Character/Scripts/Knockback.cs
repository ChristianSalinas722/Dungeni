using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Knockback : MonoBehaviour
{
    [SerializeField] private float strength = 16, delay = 0.15f;

    public UnityEvent OnBegin, OnDone;

    public GameObject attackArea;

    public void OnTriggerEnter2D(Collider2D other){
        PlayFeedback(other.gameObject);
    }
    public void PlayFeedback(GameObject victim){
        StopAllCoroutines();
        OnBegin?.Invoke();

        if(victim.GetComponent<Rigidbody2D>() == null){
            return;
        }
        Debug.Log("push");
        Vector2 direction = (transform.position-victim.transform.position).normalized;
        victim.GetComponent<Rigidbody2D>().AddForce(direction * strength, ForceMode2D.Impulse);
        StartCoroutine(Reset(victim));
    }

    private IEnumerator Reset(GameObject victim){
        yield return new WaitForSeconds(delay);
        if(victim != null){
        victim.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
        OnDone?.Invoke();
    }
}
