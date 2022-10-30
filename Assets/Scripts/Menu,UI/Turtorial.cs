using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtorial : MonoBehaviour
{
    public GameObject jiaocheng;
    
    public List<GameObject> ttt;
    public int current;
    public GameObject sister, sister2;


    // Start is called before the first frame update
    void Start()
    {
        sister = GameObject.Find("Sister");
        sister2 = GameObject.Find("Sister2");
        sister.GetComponent<charController>().enabled = false;
        sister2.GetComponent<charController>().enabled = false;
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
