using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public float speed;
   

    void Update()
    { 
        transform.Translate(Vector2.up * speed *Time.deltaTime);
        GameObject.Destroy(gameObject, 0.5f* Time.deltaTime);
    }

    //void AtDistanceDestory()
   // {

    //}
}
