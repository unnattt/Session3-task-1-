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
    Vector2 fingertouchPoint;
    Quaternion rotater;
    float ScreenWidth;

    private bool isJoystickTouch;

    void Start()
    {
        cam = Camera.main;
        ScreenWidth = Screen.width;
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
        if(Input.touchCount>0)
        {
            Touch thetouch = Input.GetTouch(0);
            if (thetouch.phase == TouchPhase.Began)
            {
                fingertouchPoint = thetouch.position;
                rotater = transform.rotation;
            }
            else if(thetouch.phase == TouchPhase.Moved && isJoystickTouch== false)
            {
                float diffrence = (thetouch.position - fingertouchPoint).x;
                transform.rotation = rotater * Quaternion.Euler(Vector3.forward * (diffrence / ScreenWidth) * 360);

            }
                
            
        }
        // Another 
        //if (Input.touchCount >= 0 && isJoystickTouch == false)
        //{
        //    Touch theTouch = Input.GetTouch(0);

        //    if (theTouch.phase == TouchPhase.Moved)
        //    {
        //        Vector2 TouchPosition = cam.ScreenToWorldPoint(Input.GetTouch(0).position);

        //        transform.up = TouchPosition - (Vector2)transform.position;

        //    }}
    }

           

         
    

        public void BulletFireArea()
        {
          
            Instantiate(bullets, transform.position, transform.rotation);


        }
    }

    
