using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameraCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public float FollowSpeed = 2f;
    public Transform target;

    void Update()
    {
        if (target != null)
        {
            Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f);
            transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
