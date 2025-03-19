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

     void ResetBall() //ini kita buat nilai transform jadi 0
    {
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void RestartGame()
    {
        //Debug.Log("Restart!");
        ResetBall();
        Invoke("GoBall", 1);
    }

    [SerializeField] private int wallCollisionCount;
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "King") //jika terkena player
        {
            //Debug.Log("King Punch!");
            rb2d.AddForce(new Vector2(20,-15));
            wallCollisionCount = 0;

        }
        else if (coll.gameObject.name == "Pig") //jika terkena enemy
        {
            //Debug.Log("Pig Punch!");
            rb2d.AddForce(new Vector2(-20,-15));
            wallCollisionCount = 0;
        }
        else //jika terkena wall
        {
            wallCollisionCount = wallCollisionCount + 1;
            Debug.Log("Wall Collision! = " + wallCollisionCount);
            if (wallCollisionCount > 6) GoBall();
        }
    }

}
