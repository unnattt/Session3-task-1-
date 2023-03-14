using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForMobile : MonoBehaviour
{
 
    public float speed = 5f;
    public Camera _cam;
    public GameObject bullets;

    public Joystick joystick;
    void Start()
{
    _cam = Camera.main;
}

void Update()
{
    MovementArea();
    MousePositionArea();
    BulletArea();
}

void MovementArea()
{
    // Replace keyboard inputs with joystick inputs
    float horizontalInput = joystick.Horizontal;
    float verticalInput = joystick.Vertical;

    // Move the player based on the joystick input
    Vector2 direction = new Vector2(horizontalInput, verticalInput);
    transform.Translate(direction * speed * Time.deltaTime);
}

void MousePositionArea()
{
    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
    {
        // Get the touch position and convert it to world space
        Vector2 touchPosition = _cam.ScreenToWorldPoint(Input.GetTouch(0).position);

        // Set the player's rotation to face the touch position
        transform.up = touchPosition - (Vector2)transform.position;
    }
}

void BulletArea()
{
    if (Input.touchCount > 1 && Input.GetTouch(1).phase == TouchPhase.Began)
    { 
        // Spawn a bullet at the player's position
        Instantiate(bullets, transform.position, transform.rotation);
    }
}
}




