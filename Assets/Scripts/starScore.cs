using UnityEngine.UI;
using UnityEngine;

public class starScore : MonoBehaviour
{
   //public PlayerScript playerScript;
    public Text starsScore;
    // Update is called once per frame
    void Update()
    {
        starsScore.text = PlayerScript.stars.ToString();
    }
}
