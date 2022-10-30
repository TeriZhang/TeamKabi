using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;
    public int currentSpot;
    public int totalSpot;
    public float waitTime;
    public List<GameObject> spots;

    public GameObject altered, talking;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, spots[currentSpot].transform.position, Time.deltaTime * speed);

        if (Vector2.Distance(transform.position, spots[currentSpot].transform.position) <0.2f)
        {
            currentSpot += 1;
            if(currentSpot >= totalSpot)
            {
                currentSpot = 0;
            }
        }
    }

    public void Stop()
    {
        speed = 0;
        talking.SetActive(true);
    }

    public void Detected()
    {
        speed = 0;
        altered.SetActive(true);
    }

    public void Resume()
    {
        speed = 3;
        talking.SetActive(false);
        altered.SetActive(false);
    }
}
