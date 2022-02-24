using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //Referencia aos outros scripts
    [SerializeField]
    internal Player_Input_Script inputScript;

    [SerializeField]
    internal Player_Collision_Script collisionScript;

    [SerializeField]
    internal Player_Movement_Script movementScript;
    [SerializeField]
    internal Player_GameController playerController;
    [SerializeField]
    
    internal LevelManager levelManager;


    //Referencia de componente
    [SerializeField]
    internal Animator player;
    internal Rigidbody2D rb2d;
    internal SpriteRenderer sprite;


    //Propriedades principais do player
    public static int lifes;
    public static int stars;
    public int starsScore;
    public int lifesScore;
    public float moveSpeed = 20f;
    public float jumpSpeed = 0.3f;


    //Propriedades de animação
    internal string PLAYER_IDLE = "parada";
    internal string PLAYER_ANDANDO = "andando";
    internal string PLAYER_PULANDO = "pulando";
    internal string PLAYER_MORRENDO = "morrendo";

    //Outras propriedades
    internal string currentState;
    private bool Direita;
    private bool Esquerda;
    internal bool gameOver;
    public int AllStars;
    


    private void Awake()
    {
        print("Main PlayerScript Awake");
        player = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        //controller = GetComponent<CharacterController>();
    }
    void Start()
    {
        print("Main PlayerScript Starting");
        currentState = PLAYER_IDLE;
        lifes = 3;
        stars = 0;
        // playerController.LifeScore = 3;
        // playerController.Starscore = 0;
        gameOver = false;

        GameObject[] starsCount = GameObject.FindGameObjectsWithTag("Estrela");
        AllStars = starsCount.Length-1;
    }
    


    //Maquina de estados
    internal void ChangeState(string newState)
    {
        if (newState != currentState)
        {
            player.Play (newState);
            currentState = newState;
        }
    }

    internal void checkGameOver()
    {
        if (lifes == 0)
        {
            gameOver = true;
            ChangeState(PLAYER_MORRENDO);
            Invoke("GameOver", 3.0f);
            // levelManager.ManageScene("GameOver");
            
        }
    }

    public void GameOver()
    {
        levelManager.ManageScene("GameOver");
    }
    public void checkAllStars()
    {
        if(stars == AllStars)
        {
            levelManager.ManageScene("Success");
        }
    }
    public void Win()
    {
        levelManager.ManageScene("Success");
    }
}
