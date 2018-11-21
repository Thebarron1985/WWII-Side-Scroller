using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrenchGirlAnimController : MonoBehaviour
{

    public float speed = 5.0f;
    float currentSpeed = 0.0f;
    Animator anim;


 // Use this for initialization
    void Start()
    {
        anim = this.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
            float translation = Input.GetAxis("Horizontal") * speed;
            translation *= Time.deltaTime;
            

        currentSpeed += translation;
        anim.SetFloat("Speed", currentSpeed);
        transform.Translate(0, 0, translation);


        if (translation != 0)
            {
                anim.SetBool("isWalking", true);
            }
            else
            {
                anim.SetBool("isWalking", false);
                currentSpeed = 0;
            }

    }
}
