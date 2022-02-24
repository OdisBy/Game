using UnityEngine.UI;
using UnityEngine;

public class vidaScore : MonoBehaviour
{
    public Text lifeScore;

    // Update is called once per frame
    void Update()
    {
        lifeScore.text = PlayerScript.lifes.ToString();
    }
}
