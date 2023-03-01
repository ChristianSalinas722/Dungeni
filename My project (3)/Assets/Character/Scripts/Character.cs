using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    public ContactFilter2D movementFilter;

    public float collisionOffset = 0.05f;
    public float speed = 2f;
    Vector2 movementInput;
    Rigidbody2D rb2d;
    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();
    Animator animator;
    SpriteRenderer sr;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate(){
       if (movementInput != Vector2.zero){
        int count = rb2d.Cast(
            movementInput, 
            movementFilter,
            castCollisions, 
            speed * Time.fixedDeltaTime + collisionOffset);
       }
    }
}
