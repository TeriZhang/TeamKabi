using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class gameDad : MonoBehaviour
{
    public GameObject sister1, sister2, currentSister;
    public bool sister;

    public CinemachineVirtualCamera mainCam;
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
                sister1.GetComponent<charController>().enabled = false;
                sister2.GetComponent<charController>().enabled = true;
                currentSister = sister2;
                return;
            }
            if(sister == true)
            {
                sister = false;
                sister1.GetComponent<charController>().enabled = true;
                sister2.GetComponent<charController>().enabled = false;
                currentSister = sister1;
                return;
            }

        }
    }

    
}
