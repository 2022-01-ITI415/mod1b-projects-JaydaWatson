using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]

    public GameObject applePrefab;

    public float speed = 20f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirection = 0.02f;
    public float secondsBetweenAppleDrop = 0.5f;
    
    
    void Start()
    {
        Invoke ("DropApple", 2f);
    }

    void DropApple()
    {
        // question about this code

        GameObject apple = Instantiate < GameObject> (applePrefab);
        apple.transform.position = transform.position;
        Invoke ("DropApple", secondsBetweenAppleDrop);
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
