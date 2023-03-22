using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    int heal = 3;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator= GetComponent<Animator>();
    }
    IEnumerator DesTroyE()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
        scoreManager.instance.AddPoint();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //bullet1
        if (collision.CompareTag("Bullet1"))
        {
            heal--;

            Destroy(collision.gameObject);
            if (heal <= 0)
            {
                animator.SetBool("EnemyDie", true);
                StartCoroutine(DesTroyE());
                
            }
      
        }

        //bullet2
        if (collision.CompareTag("Bullet2"))
        {
            heal -= 2;

            Destroy(collision.gameObject);
            if (heal <= 0)
            {
                animator.SetBool("EnemyDie", true);
                StartCoroutine(DesTroyE());
            }

        }
        //bullet3
        if (collision.CompareTag("Bullet3"))
        {
            heal -= 3;

            Destroy(collision.gameObject);
            if (heal <= 0)
            {
                animator.SetBool("EnemyDie", true);
                StartCoroutine(DesTroyE());
            }

        }
        //bullet4
        if (collision.CompareTag("Bullet4"))
        {
            heal -= 5;

            Destroy(collision.gameObject);
            if (heal <= 0)
            {
                animator.SetBool("EnemyDie", true);
                StartCoroutine(DesTroyE());
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
