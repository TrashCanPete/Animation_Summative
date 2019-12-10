using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AZRIController : MonoBehaviour
{
    Animator anim;
  

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            anim.SetTrigger("DrawSword");
            
        }
        if (Input.GetKey(KeyCode.R))
        {
            anim.SetTrigger("Sheath");
        }
    }
}
