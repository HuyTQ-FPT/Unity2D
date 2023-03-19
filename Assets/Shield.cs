using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isProtected;
    public float activationTime;
    // Start is called before the first frame update
    void Start()
    {
        isProtected = false;
        activationTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        activationTime += Time.deltaTime;
        if (isProtected && activationTime >= 10)
        {
            isProtected = false;
            activationTime = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shield")
        {
            isProtected = true;
            activationTime = 0;
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "Stone" || collision.gameObject.tag == "Enemy")
        {
            if (!isProtected)
            {
                Destroy(gameObject);
            }
        }
    }
}
