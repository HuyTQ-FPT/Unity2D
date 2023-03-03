using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireForce = 20f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Fire()
    {

        GameObject bullet1 = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        bullet1.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);

        // Tạo đối tượng bullet2
        GameObject bullet2 = Instantiate(bulletPrefab, firePoint.position + new Vector3(0, 1, 0), Quaternion.identity);
        bullet2.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
