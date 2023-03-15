using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ForMobileGame : MonoBehaviour
{
    public float speed;
    public Camera cam;
    public GameObject bullets;
    public Joystick joystick;
    
    
    void Start()
    {
        cam = Camera.main;
    }

    
    void Update()
    {
        MovementArea();
        TouchRotateArea();
    }

    void MovementArea()
    {
        float InputHorizontal = joystick.Horizontal;
        float InputVertical = joystick.Vertical;

        Vector2 direction = new Vector2(InputHorizontal, InputVertical);
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void TouchRotateArea()
    {
        if(Input.touchCount >= 0)
        {
            Touch theTouch = Input.GetTouch(0);
            if
            if(theTouch.phase== TouchPhase.Moved)
            {
                Vector2 TouchPosition = cam.ScreenToWorldPoint(Input.GetTouch(0).position);

                transform.up = TouchPosition - (Vector2)transform.position;

            }
        }
    }

    public void BulletFireArea()
    {
        Instantiate(bullets, transform.position, transform.rotation);
    }

    
}
