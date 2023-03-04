using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Weapon weapon;
    Vector2 mouseDirection;
    Vector2 mousePosition;
    public float timeSpawn =0f;
    public float timeDelay = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        mouseDirection = new Vector2(moveX, moveY).normalized;
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.timeSpawn += Time.deltaTime;
        if (timeSpawn < timeDelay)
        {
            return;
        }
        else
        {
            weapon.Fire();
            timeSpawn = 0;
        }
       

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(mouseDirection.x * moveSpeed, mouseDirection.y * moveSpeed);
        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
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

   
}
