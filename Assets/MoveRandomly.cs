using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRandomly : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 20f; // Tốc độ di chuyển của đối tượng
    public Vector2 targetPosition; // Vị trí đích của đối tượng
    public Transform targetTransform;
    public float destroyDistance = 1f;
    void Start()
    {  
        targetPosition = new Vector2(Random.Range(-21, 24), -11);
    }
    void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

    
        if (Vector2.Distance(transform.position, targetPosition) < 0.1f)
        {
            targetPosition = new Vector2(Random.Range(-21, 24), -20);
        }
        float distanceToTarget = Vector2.Distance(transform.position, new Vector2(Random.Range(-21, 24), -11));       
        if (distanceToTarget < destroyDistance)
        {
            Destroy(gameObject);
        }        
    } 
   
    
}