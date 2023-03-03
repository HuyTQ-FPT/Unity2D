using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireForce = 20f;
    public AudioSource gun;
    public AudioClip bullet1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        gun.PlayOneShot(bullet1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
