using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReciveItems : MonoBehaviour
{
    // Start is called before the first frame update

    PlayerController js;
    float totalSpeed;
    private float timeSpawn = 0;
    private float timeDlay = 5;
    public bool hasBeenCalled = false;
    public bool checkArmor;
    void Start()
    {
        js = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()       
    {   
        if(hasBeenCalled == true)
        {
            Debug.Log("đã vào hàm check");
            this.timeSpawn += Time.deltaTime;
            if (this.timeSpawn < this.timeDlay) return;
            else
            {
                this.timeSpawn = 0;
                speedReduce();
                Debug.Log("đã vào reduce");
            }
        }
    }
    void speedReduce()
    {
        ReciveItemSpeedUp(-5f);
        hasBeenCalled = false;
    }
    public virtual void ReciveItemSpeedUp(float spUp)
    {
        totalSpeed = js.getSpeed();
        totalSpeed += spUp;
        if(totalSpeed >= 15){
            totalSpeed = 15;
        }
        js.setSpeed(totalSpeed);
        hasBeenCalled = true;
    }
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            if (checkArmor == true)
            {
                checkArmor = false;
            }
            else
            {
                Destroy(gameObject);
            }

        }
    }
}
