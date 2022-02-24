using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public int star = 0;
    public int lifes = 3;

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Estrela"))
        {
            star += 1;
            Debug.Log(star);
            Destroy(collision.gameObject);
        }
            
        if(collision.gameObject.CompareTag("Coracao"))
        {
            lifes += 1;
            Debug.Log(lifes);
            Destroy(collision.gameObject);
        }
            
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Espinho") || collision.gameObject.CompareTag("Blade"))
        {
            lifes -= 1;
            Debug.Log(lifes);
            checkGameOver();
        }

    }

    public void checkGameOver()
    {
        if(lifes == 0)
        {
            Time.timeScale = 0;
        }
    }
}
