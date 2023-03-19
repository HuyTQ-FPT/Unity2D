using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSenderArmor : MonoBehaviour
{
    // Start is called before the first frame update
    Timer timer;
    // public List<GameObject> items;
    void Start()
    {
        timer = GetComponent<Timer>();
        timer.arlarmTime = 30f;
        timer.StartTime();
        // this.items = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.isFinish){
            Destroy(this.gameObject);
        }
    }
  
}
