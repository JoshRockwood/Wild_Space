using UnityEngine;
using UnityEngine.Events;

public class OutOfBoundsDestroy : MonoBehaviour
{
   public float rightBound;
   public float leftBound;

     void Update()
   {
       if (transform != null)
       {
           if (transform.position.x > rightBound || transform.position.x < leftBound)
           {
               Destroy(gameObject);
           }
       }
   }
}
