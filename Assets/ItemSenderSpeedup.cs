using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSenderSpeedup : MonoBehaviour
{
    // Start is called before the first frame update
    Timer timer;
    void Start()
    {
        timer = GetComponent<Timer>();
        timer.arlarmTime = 30f;
        timer.StartTime();
    }

    // Update is called once per frame
    void Update()
    {
       if(timer.isFinish){
        Destroy(this.gameObject);
       }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ReciveItems ri = other.GetComponent<ReciveItems>();
            ri.ReciveItemSpeedUp(5f);
          
            Destroy(gameObject);
        }
    }

}
