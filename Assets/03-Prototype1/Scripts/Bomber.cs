using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bomber : MonoBehaviour
{

    static public bool 	goalMet = false;

    [Header("Set Dynamically")]
    public Text scoreGT;
    public Text gameoverGT;
    public float speed = 25f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirection = 0.02f;

    void Start()
    {
        GameObject scoreGO = GameObject.Find("BomberPoints");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
    }

    void Update()
    {
        Vector3 pos = transform.position;      
        pos.x += speed * Time.deltaTime;       
        transform.position = pos;    

        if ( pos.x < -leftAndRightEdge ) 
        {      
           speed = Mathf.Abs(speed); 
       } else if ( pos.x > leftAndRightEdge ) {
           speed = -Mathf.Abs(speed); 
       }
    }

    void FixedUpdate() {
 
        if ( Random.value < chanceToChangeDirection)
        {
            speed *= -1;
        }
    }

    void OnCollisionEnter ( Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Bomb")
        {
            Destroy (collidedWith);

            int score = int.Parse( scoreGT.text);
            score += 1;
            scoreGT.text = score.ToString();

         if (score > HighScore.score) {
             HighScore.score = score;
 
              }

        }

        GameObject collidWith = coll.gameObject;
        if (collidedWith.tag == "Projectile")
        {
            Destroy (collidWith);
		    GameOver();
		
        }
    }

    public void GameOver()
    {
        GameObject gameoverGO = GameObject.Find("GameOver");
        gameoverGT = gameoverGO.GetComponent<Text>();
        gameoverGT.text = "Game Over";
    }

}
