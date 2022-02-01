using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]

    public GameObject   applePrefab;

    public float        speed = 1f;
    public float        leftAndRightEdge = 10f;
    public float        chanceToChangeDirection = 0.1f;
    public float        secondsBetweenAppleDrop = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;      
 
        pos.x += speed * Time.deltaTime;       
 
        transform.position = pos;    

        if ( pos.x < -leftAndRightEdge ) 
        {      
           speed = Mathf.Abs(speed); 
       } else if ( pos.x > leftAndRightEdge ) 
       {
           speed = -Mathf.Abs(speed); 
       }
        
    }

    void FixedUpdate() {
 
        // Changing Direction Randomly is now t
 
        if ( Random.value < chanceToChangeDirection)
        {
 
            speed *= -1;
 
        }
 
    }
 
}
