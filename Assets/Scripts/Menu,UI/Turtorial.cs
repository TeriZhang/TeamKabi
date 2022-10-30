using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtorial : MonoBehaviour
{
    public GameObject jiaocheng;
    
    public List<GameObject> ttt;
    public int current;


    // Start is called before the first frame update
    void Start()
    {
        current = 0;
        jiaocheng.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextSlide()
    {
        current += 1;
        

        for (int i = 0; i < 6; i++)
        {
            ttt[i].gameObject.SetActive(false);
            ttt[current].gameObject.SetActive(true);
        }

    }
}
