using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyController : MonoBehaviour
{
    public float moveSpeed;
    public Animator cameraAnim;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("SitDown", false);
        anim.SetBool("Walking", false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") > 0)
        {
            anim.SetBool("Walking", true);
            anim.SetBool("SitDown", false);
            characterScale.x = 1;
            transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            anim.SetBool("Walking", true);
            anim.SetBool("SitDown", false);
            characterScale.x = -1;
            transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetAxis("Horizontal") == 0)
        {
            anim.SetBool("Walking", false);
            anim.SetBool("SitDown", true);
        }
        
                transform.localScale = characterScale;


    }

    void CameraShake()
    {
        cameraAnim.SetTrigger("CameraShake");
    }
}
