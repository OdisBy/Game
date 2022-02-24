using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBG : MonoBehaviour
{
    public float speed = 0.05f;
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * speed, 0f);
        gameObject.GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
