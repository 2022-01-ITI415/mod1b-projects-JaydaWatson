using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour
{
    [Header("Set Inspector")]

    public static float bottomY = -9f;

    void Update()
    {

         if (transform.position.y < bottomY)
        {
            Destroy (this.gameObject);

        }
    }

     void OnCollisionEnter ( Collision collect)
    {
        GameObject collidedWith = collect.gameObject;
        if (collidedWith.tag == "Bomb")
        {
            Destroy (this.gameObject);
        }
    }

}
