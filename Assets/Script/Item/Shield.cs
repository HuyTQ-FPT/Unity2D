using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public bool isProtected = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shield")
        {
            isProtected = true;
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "")
        {
            if (!isProtected)
            {
                //code may bay no
            }
        }
    }
}
