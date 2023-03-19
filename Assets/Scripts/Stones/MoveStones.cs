using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStones : MonoBehaviour
{
    public float moveSpeed = 20f; // Tốc độ di chuyển của đối tượng
    public Vector2 targetPosition; // Vị trí đích của đối tượng
    public Transform targetTransform;
    public float destroyDistance = 1f;
    void Start()
    {
        targetPosition = new Vector2(Random.Range(-62, 51), -33);
    }
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);


        if (Vector2.Distance(transform.position, targetPosition) < 0.1f)
        {
            targetPosition = new Vector2(Random.Range(-62, 51), -33);
        }
        float distanceToTarget = Vector2.Distance(transform.position, new Vector2(Random.Range(-62, 51), -33));
        if (distanceToTarget < destroyDistance)
        {
            Destroy(gameObject);
        }
    }
}
