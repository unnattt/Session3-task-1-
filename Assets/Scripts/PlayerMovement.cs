using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Camera _cam;
    public GameObject projectile;


    void Start()
    {
        _cam = Camera.main;
    }

    void Update()
    {
        MovementArea();
        MouseRotationArea();
        BulletArea();


        void MovementArea()
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector2.down * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
        }
        void MouseRotationArea()
        {
            if (Input.GetButton("Fire2"))
            {
                Vector2 MousePosition = _cam.ScreenToWorldPoint(Input.mousePosition);

                transform.up = MousePosition;
            }
        }

        void BulletArea()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Instantiate(projectile, transform.position, transform.rotation);
            }
        }


    }
}

