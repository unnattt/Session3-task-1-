using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ForMobileGame : MonoBehaviour
{
    public float speed;
    public Camera cam;
    public GameObject bullets;
    public Joystick joystick;

    private bool isJoystickTouch;
    
    
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
       

      if (joystick.Horizontal != 0f || joystick.Vertical != 0f)
    {
        isJoystickTouch = true;

        Vector2 direction = new Vector2(joystick.Horizontal, joystick.Vertical);
        transform.Translate(direction * speed * Time.deltaTime);
    }
    else
    {
        isJoystickTouch = false;
    }

    }

    void TouchRotateArea()
    {
        if(isJoystickTouch)return;
        if(Input.touchCount >= 0)
        {
            Touch theTouch = Input.GetTouch(0);
            
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

