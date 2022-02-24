using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input_Script : MonoBehaviour
{
    [SerializeField]
    PlayerScript playerScript;

    internal bool Direita;
    internal bool Esquerda;
    internal bool Pulo;


    void Start()
    {
        print("Player InputScript Starting");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            Direita = true;
        }
        else
        {
            Direita = false;
        }

        if(Input.GetAxisRaw("Horizontal") < 0)
        {
            Esquerda = true;
        }
        else
        {
            Esquerda = false;
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            Pulo = true;
        }
        else
        {
            Pulo = false;
        }
    }
}
