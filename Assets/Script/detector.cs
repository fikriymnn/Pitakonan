using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detector : MonoBehaviour
{
    private bool isJump = false;
    public playermovement playermovement;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isJumping", false);
        animator.SetBool("isFalling", false);
        if ((playermovement.isMoving) && (playermovement.groundPlayer))
        {
            playermovement.isMoving = true;
            animator.SetBool("isWalk", true);

        }
        else
        {
            playermovement.isMoving = false;
            animator.SetBool("isWalk", false);
            if (playermovement.isMoving && (playermovement.groundPlayer == false))
            {
                animator.SetBool("isJumping", true);

            }
            else
            {
                if (playermovement.groundPlayer == false && playermovement.velocity.y < 5f)
                {
                    animator.SetBool("isFalling", true);
                    animator.SetBool("isJumping", false);
                }
            }
        }

       
//
       // (isJump)
       //
       //   animator.SetBool("isJumping", true);
       //
      //lse
        //
        //  animator.SetBool("isJumping", false);
        //
        if (playermovement.playerInput.PlayerMain.Jump.triggered && playermovement.groundPlayer) { 
            animator.SetBool("isJumping", true) ;
            animator.SetBool("isWalk", false);
            
        }
        else
        {
            if (playermovement.groundPlayer == false && playermovement.velocity.y < 5f)
            {
                animator.SetBool("isFalling", true);
                animator.SetBool("isJumping", false);
            }
        }



        


    }

    
    

}
