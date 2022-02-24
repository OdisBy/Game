using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_Script : MonoBehaviour
{
    [SerializeField]
    PlayerScript playerScript;
    
    
    void Start()
    {
        print("Player MovementScript Starting");
    }

    void Update()
    {
        if(playerScript.inputScript.Direita && playerScript.gameOver == false)
        {
            MovePlayerDireita();
        }
        else if (playerScript.inputScript.Esquerda && playerScript.gameOver == false)
        {
            MovePlayerEsquerda();
        }
        else
        {
            StopMovement();
            
        }
        if (playerScript.inputScript.Pulo && playerScript.gameOver == false)
        {
            PlayerPulo();
        }
    }


    private void MovePlayerDireita()
    {
        playerScript.player.transform.Translate(playerScript.moveSpeed * Time.deltaTime, 0, 0);
        playerScript.sprite.flipX = false;

        if(playerScript.collisionScript.isGrounded)
                playerScript.ChangeState(playerScript.PLAYER_ANDANDO);
        
    }
    
    private void MovePlayerEsquerda()
    {
        playerScript.player.transform.Translate(-playerScript.moveSpeed * Time.deltaTime, 0, 0);
        playerScript.sprite.flipX = true;

        if(playerScript.collisionScript.isGrounded)
                playerScript.ChangeState(playerScript.PLAYER_ANDANDO);
    }
    
    private void PlayerPulo()
    {
        playerScript.player.transform.Translate(0, playerScript.jumpSpeed, 0);
        if(playerScript.collisionScript.isGrounded)
        {
            playerScript.ChangeState(playerScript.PLAYER_PULANDO);
        }
    }

    private void StopMovement()
    {
        if(playerScript.gameOver == false && playerScript.collisionScript.isGrounded)
            playerScript.ChangeState(playerScript.PLAYER_IDLE);
    }
}
