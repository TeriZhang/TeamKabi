using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class gameDad : MonoBehaviour
{
    public GameObject sister1, sister2, currentSister;
    public bool sister;

    public CinemachineVirtualCamera mainCam;

    public bool level2, button1, button2, pressed;

    // Start is called before the first frame update
    void Start()
    {
        currentSister = sister1;
        sister1.GetComponent<charController>().enabled = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        //camera move
        mainCam.LookAt = currentSister.transform;
        mainCam.Follow = currentSister.transform;
        //switch move
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(sister == false)
            {
                sister = true;
                sister1.GetComponent<charController>().Stop();
                sister1.GetComponent<charController>().enabled = false;
                sister2.GetComponent<charController>().enabled = true;
                currentSister = sister2;
                return;
            }
            if(sister == true)
            {
                sister = false;
                sister1.GetComponent<charController>().enabled = true;
                sister2.GetComponent<charController>().Stop();
                sister2.GetComponent<charController>().enabled = false;
                currentSister = sister1;
                return;
            }

        }

        if(level2 == true)
        {
            Level2();
        }
    }

    public void Level2()
    {
        if(button1 && button2)
        {
            if(pressed == true)
            {
                return;
            }
            GameObject gate = GameObject.Find("Gate");
            gate.SetActive(false);
            pressed = true;
        }
        else
        {
            
        }
    }

    public void Button1()
    {
        button1 = true;
    }

    public void Button2()
    {
        button2 = true;
    }

    public void Button1off()
    {
        button1 = false;
    }

    public void Button2off()
    {
        button2 = false;
    }

}
