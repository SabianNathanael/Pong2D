using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }
    void GoBall()
    {
        float rand = Random.Range(0,2);
        if(rand < 1)
        {
            rb2d.AddForce(new Vector2(200, -15));
            Debug.Log("0");

        }
        else
        {
            rb2d.AddForce(new Vector2(-200, -15));
             Debug.Log("1");
        }
    }

}
