using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
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
}
