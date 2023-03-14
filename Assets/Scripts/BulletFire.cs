using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public float speed;
    public float distance;
   

    void Update()
    {
        transform.Translate(Vector2.up*speed*Time.deltaTime);
        destoryFunction();
    }
    void destoryFunction()
    {
        var amtToMove = speed * Time.deltaTime;
        transform.Translate(Vector3.forward * amtToMove);
        if(transform.localPosition.z >= distance)
        {
        Destroy(gameObject);
        }

     }
 }

    

    