using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aliens : MonoBehaviour
{
    [Header("Set in Inspector")]

    public GameObject bombPrefab;

    public float speed = 20f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirection = 0.02f;
    public float secondsBetweenBombDrop = 10f;
    
    
    void Start()
    {
       Invoke ("DropBomb", 2f); 
    }

    void DropBomb()
    {

        GameObject bomb = Instantiate < GameObject> (bombPrefab);
        bomb.transform.position = transform.position;
        Invoke ("DropBomb", secondsBetweenBombDrop);
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
}
