using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGun : MonoBehaviour
{
    // Start is called before the first frame update
    Timer timers;

    [SerializeField]
    GameObject Gun1;
    
    

    GameObject GunX;
    int maxGun = 5;
    int count = 0;

    float P1;
    float P2;
    float P3;
    float P4;
    

    // Start is called before the first frame update
    public void Start()
    {
        timers = GetComponent<Timer>();
        timers.arlarmTime = 10;
        timers.StartTime();
    }

    // Update is called once per frame
    public void Update()
    {
        P1 = -0.3333f * Time.time + 50;
        P2 = P1 + 30;
        P3 = P2 + 0.1666f * Time.time + 15;
        P4 = P3 + 0.1666f * Time.time + 5;



        if (count < maxGun)
        {
            GunSpawn();
            count++;
        }
        if(timers.isFinish)
        {
            maxGun++;
            timers.arlarmTime = 10;
            timers.StartTime();
        }
    }

    private Bounds OrthographicBounds(Camera camera)
    {
        float screenAspect = (float)Screen.width / (float)Screen.height;
        float cameraHeight = camera.orthographicSize * 2;
        Bounds bounds = new Bounds(
            camera.transform.position,
            new Vector3(cameraHeight * screenAspect, cameraHeight, 0));
        return bounds;
    }

    public void GunSpawn()
    {
        Bounds bounds = OrthographicBounds(Camera.main);
        float X = Random.Range(bounds.min.x, bounds.max.x);
        float Y = Random.Range(bounds.min.y, bounds.max.y);
        int random = Random.Range(0, 101);
        Debug.Log(random);
        if (random <= P1)
        {
            GunX = Gun1;

        }
       
        GameObject obj = Instantiate(GunX, new Vector2(X, Y), Quaternion.identity);
        int size = Random.Range(1, 4);
        obj.transform.localScale = new Vector3(size, size, 1f);
       

    }

}
