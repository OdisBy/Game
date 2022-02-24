using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_GameController : MonoBehaviour
{
    public static Player_GameController playerController;
    [SerializeField]
    PlayerScript playerScript;
    public int Starscore;
    public int LifeScore;

    private void Awake()
    {
        if (playerController == null)
        {
            playerController = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (playerController != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // Starscore = playerScript.stars;
        // LifeScore = playerScript.lifes;
    }
}
