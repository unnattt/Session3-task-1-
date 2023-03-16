using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public float speed;
    public float distance;
   
    Vector2 initialPos;
    
    void Start()
    {
        initialPos= transform.position;
    }
   

    void Update()
    {
        transform.Translate(Vector2.up*speed*Time.deltaTime);
        destoryFunction();
    }
    void destoryFunction()
    { 

        if(Vector2.Distance(initialPos, transform.position) > distance)
        {
            Destroy(gameObject);
        }
     }
 }
       
       
        // Destroy(gameObject, distance/speed);
        // }

    

    