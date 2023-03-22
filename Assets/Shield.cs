using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isProtected;
    public float activationTime;
    GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        isProtected = false;
        activationTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isProtected)
        {
            activationTime += Time.deltaTime;
            if (isProtected && activationTime >= 10)
            {
                isProtected = false;
                activationTime = 0;
            }
        }
    }
    IEnumerator DesTroyE()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
        scoreManager.instance.AddPoint();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shield")
        {
            isProtected = true;
            activationTime = 0;
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "Stone")
        {
            if (isProtected)
            {
                Destroy(collision.gameObject);
                activationTime = 0;
                isProtected = false;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "Enemy")
        {
            if (isProtected)
            {
                //collision.gameObject.GetComponent<Animator>().SetBool("EnemyDie", true);
                //StartCoroutine(DesTroyE());
                Destroy(collision.gameObject);
                activationTime = 0;
                isProtected = false;
            }
            else
            {               
                Destroy(gameObject);
            }
        }
    }
}
