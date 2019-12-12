using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AZRIController : MonoBehaviour
{
    Animator anim;
    public float moveSpeed;
  

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("FIDGET"))
            {
                anim.SetTrigger("DrawSword");
            }
        }

        if (Input.GetButtonDown("Fire2"))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("IDLE"))
            {
                anim.SetTrigger("DrawSword");
            }
        }

        if (Input.GetButtonDown("Fire1") ^ Input.GetButtonDown("Fire2"))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("RUN"))
            {
                anim.SetTrigger("DrawSword");
            }
        }
        if (Input.GetButtonDown("Fire2"))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("SHEATH"))
            {
                anim.SetTrigger("DrawSword");
            }
        }

        if (Input.GetButtonDown("Fire2"))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("COMBAT IDLE"))
            {
                anim.SetTrigger("Sheath");
            }
        }

        if (Input.GetButtonDown("Fire2"))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("COMBAT WALK"))
            {
                anim.SetTrigger("Sheath");
            }
        }

        if (Input.GetButtonDown("Fire2"))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("ATTACK"))
            {
                anim.SetTrigger("Sheath");
            }
        }
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("Attack", true);
        }
        else
        {
            anim.SetBool("Attack", false);
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("COMBAT IDLE"))
            {
                anim.SetBool("CombatWalk", true);
                anim.SetBool("StopCombatWalking", false);
            }
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("FIDGET"))
            {
                anim.SetBool("Run", true);
                anim.SetBool("StopRunning", false);
            }
        }

        if (Input.GetAxis("Horizontal") <= 0)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("COMBAT WALK"))
            {
                anim.SetBool("CombatWalk", false);
                anim.SetBool("StopCombatWalking", true);
            }
        }
        if (Input.GetAxis("Horizontal") <= 0)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("ATTACK"))
            {
                anim.SetBool("CombatWalk", false);
                anim.SetBool("StopCombatWalking", true);
            }
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("IDLE"))
            {
                anim.SetBool("Run", true);
                anim.SetBool("StopRunning", false);
            }
        }

        if (Input.GetAxis("Horizontal") <= 0)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("RUN"))
            {
                anim.SetBool("StopRunning", true);
                anim.SetBool("Run", false);
            }
        }
    }
}
