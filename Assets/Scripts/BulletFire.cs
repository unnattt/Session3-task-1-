using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public float speed;
    public float distance;
    public GameObject bullet;
    Vector2 initialPos;
   

    private void Start()
    {
       initialPos = transform.position;

    }
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        destoryFunction();
    }
    void destoryFunction()
    {
        Vector2 lastPos = bullet.transform.position;
        if (Vector2.Distance(initialPos, lastPos) >= distance)
        {
            Destroy(gameObject);
        }
    }
 }

//amtToMove = projectileSpeed * Time.deltaTime;
//transform.Translate(Vector3.up * amtToMove);
//if (transform.localPosition.y >= distance)
//
//Destroy(gameObject);
//}
//GameObject.Destroy(gameObject, 2f);


