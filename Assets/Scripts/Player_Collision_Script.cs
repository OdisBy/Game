using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Collision_Script : MonoBehaviour
{
    [SerializeField]
    PlayerScript playerScript;

    internal bool isGrounded = false;


    void Start()
    {   
        print("Player CollisionScript Starting");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Estrela"))
        {
            PlayerScript.stars++;
            Destroy(collision.gameObject);
        }
            
        if(collision.gameObject.CompareTag("Coracao"))
        {
            PlayerScript.lifes++;
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.CompareTag("door"))
        {
            playerScript.checkAllStars();
        }
            
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Espinho") || collision.gameObject.CompareTag("Blade") && playerScript.gameOver == false)
        {
            PlayerScript.lifes--;
            playerScript.checkGameOver();        
        }
        if(collision.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            isGrounded = false;
        }
    }
}
