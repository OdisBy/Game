using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    Animator CuteGirl;
    SpriteRenderer sprite;
    public float moveSpeed = 0.5f;
    public float horizontalMove;
    public float verticalMove;
    public float jumpSpeed = 0.1f;

    void Start()
    {
        CuteGirl = GetComponent<Animator> ();
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {

        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            //INDO PARA A DIREITA
            sprite.flipX = false;
            horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
            CuteGirl.SetInteger ("troca", 1);
        }
        else if(Input.GetAxisRaw("Horizontal") < 0)
        {
            //INDO PARA A ESQUERDA
            sprite.flipX = true;
            horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
            CuteGirl.SetInteger ("troca", 1);
        }
        else
        {
            //PARADA
            horizontalMove = 0;
            CuteGirl.SetInteger ("troca", 0);
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            //PULO
            verticalMove = Input.GetAxis("Vertical") * jumpSpeed;
            CuteGirl.SetInteger ("troca", 2);
        }
    }
    void FixedUpdate()
    {
        CuteGirl.transform.Translate(horizontalMove, verticalMove, 0);
    }
}

