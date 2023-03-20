using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public FixedJoystick Joystick;
    Rigidbody2D rb;
    Vector2 move;
    public float moveSpeed;
    public bool armor = false;
    private float minX = -113f;
    private float maxX = 135f;
    private float minY = -80f;
    private float maxY = 80f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Joystick.Horizontal;
        move.y = Joystick.Vertical;
        Vector3 newPosition = transform.position + new Vector3(move.x, move.y, 0f) * Time.deltaTime * moveSpeed;
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);
        transform.position = newPosition;
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
        if (rb.transform.position.x > 8 && move.x > 0)
        {
            move.x = 0;
            move.y = 0;
            return;
        }
    }
    public float getSpeed()
    {
        return moveSpeed;
    }
    public float setSpeed(float value)
    {
        moveSpeed = value;
        return moveSpeed;
    }

    public bool getArmor()
    {
        return armor;
    }
    public bool setArmor(bool value)
    {
        armor = value;
        return armor;
    }


}
