using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject itSpeedUp;
   
    GameObject getItem;
    List<GameObject> items;

    Timer timer;

    // Update is called once per frame
    private void Start()
    {
        timer = GetComponent<Timer>();
        timer.arlarmTime = 3;
        timer.StartTime();
        this.items = new List<GameObject>();
    }
    void Update()
    {

        this.Spawn();
       // this.CheckMinionDeath();
    }
    private void Spawn()
    {
        Bounds bounds = OrthographicBounds(Camera.main);
        float X = Random.Range(bounds.min.x, bounds.max.x);
        float Y = Random.Range(bounds.min.y, bounds.max.y);
        if (timer.isFinish)
        {
            int rand = Random.Range(1, 11);
            // if (this.items.Count > 3)
            // {
            //     Debug.Log("vào đây if");
            //     return;
            // }

            // int index = this.items.Count + 1;
            Debug.Log("vào else");
            if (rand > 3 && rand < 8)
            {
                getItem = itSpeedUp;
            }
            else
            {
                return;
            }

            GameObject item = Instantiate(this.getItem);
            item.transform.position = new Vector2(X, Y);
            items.Add(getItem);
            Debug.Log(items.Count);
            timer.arlarmTime = 3;
            timer.StartTime();
        }
        else return;
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
    
}
