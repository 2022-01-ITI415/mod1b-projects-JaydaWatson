using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_1 : MonoBehaviour
{
   static public bool 	goalMet = false;

   public float speed = 25f;
   public float leftAndRightEdge = 10f;
   public float chanceToChangeDirection = 0.02f;


	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.tag == "Projectile") {
		
			Goal.goalMet = true;

			
			Material mat = GetComponent<Renderer>().material;
			Color c = mat.color;
			c.a = 1;
			mat.color = c;
		}
    }

}
