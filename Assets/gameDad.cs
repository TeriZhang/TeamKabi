using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameDad : MonoBehaviour
{
    public GameObject sister1, sister2, currentSister;
    public bool sister;
    // Start is called before the first frame update
    void Start()
    {
        sister1.GetComponent<charController>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(sister == false)
            {
                sister = true;
                sister1.GetComponent<charController>().enabled = false;
                sister2.GetComponent<charController>().enabled = true;
                return;
            }
            if(sister == true)
            {
                sister = false;
                sister1.GetComponent<charController>().enabled = true;
                sister2.GetComponent<charController>().enabled = false;
                return;
            }

        }
    }

    
}
