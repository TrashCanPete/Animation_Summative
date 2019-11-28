using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyController : MonoBehaviour
{
    public float moveSpeed;
    public Animator cameraAnim;
    Animator anim;
    bool moving;
    
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("SitDown", false);
        anim.SetBool("Walking", false);
        anim.SetBool("StandUp", false);
        moving = false;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 characterScale = transform.localScale;

        if(anim.GetBool("SitDown") == true  && Input.anyKey)
        {
            moving = false;
            anim.SetBool("StandUp", true);

        }

        if (Input.GetKey("d") && anim.GetBool("StandUp") == true)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("WalkCycle"))
            {
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;
                characterScale.x = 1;
            }
            
            
            anim.SetBool("Walking", true);
            anim.SetBool("SitDown", false);
        }
        else if (Input.GetKey("a") && anim.GetBool("StandUp") == true)
        {

            if (anim.GetCurrentAnimatorStateInfo(0).IsName("WalkCycle"))
            {
                transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
                characterScale.x = -1;
            }
            
            anim.SetBool("Walking", true);
            anim.SetBool("SitDown", false);
        }
        else
        {
            moving = false;
            anim.SetBool("SitDown", true);
            anim.SetBool("Walking", false);
            anim.SetBool("StandUp", false);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            anim.SetTrigger("Action");
        }



        

        
        /*if (Input.GetAxis("Horizontal") > 0)
        {
            moving = true;

            characterScale.x = 1;
            transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            moving = true;
            anim.SetBool("Walking", true);
            anim.SetBool("SitDown", false);
            characterScale.x = -1;
            transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0, 0);
        }
        if (moving ==false)
        {
            anim.SetBool("Walking", false);
            anim.SetBool("SitDown", true);
        }
        */
        //moved sprite left and right but would consider the sprite not moving when it flipped so would trigger the sit down animation which is not ideal.

        transform.localScale = characterScale;
                

    }


    void CameraShake()
    {
            int rand = Random.Range(0, 3);
            if (rand == 0)
            {
                cameraAnim.SetTrigger("CameraShake");
            }
            else if (rand == 1)
            {
                cameraAnim.SetTrigger("CameraShake02");
            }

            else if (rand == 2)
            {
                cameraAnim.SetTrigger("CameraShake03");
            }
    }
}
