using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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
            bool success = TryMove(movementInput);
        
            if(!success){
                success = TryMove(new Vector2(movementInput.x,0));
                if(!success){
                    success = TryMove(new Vector2(0,movementInput.y));
                }
            }
            if(movementInput.x > 0){
            animator.SetBool("isMovingRight", success);
            }
            if(movementInput.y < 0){
                animator.SetBool("isMovingDown", success);
            }
            if(movementInput.y > 0){
                animator.SetBool("isMovingUp", success);
            }
            if(movementInput.x < 0){
                animator.SetBool("isMovingLeft", success);
            }
       }
       else{
        animator.SetBool("isMovingRight", false);
        animator.SetBool("isMovingLeft", false);
        animator.SetBool("isMovingDown", false);
        animator.SetBool("isMovingUp", false);
       }
    }
    private bool TryMove(Vector2 direction){
           int count = rb2d.Cast(
            movementInput, 
            movementFilter,
            castCollisions, 
            speed * Time.fixedDeltaTime + collisionOffset);
            if (count == 0){
                rb2d.MovePosition(rb2d.position + movementInput * speed * Time.fixedDeltaTime);
                return true;
            }
            else {
                return false;
            }
        
       }
    void OnMove(InputValue movementValue){
        movementInput = movementValue.Get<Vector2>();
    }
}
