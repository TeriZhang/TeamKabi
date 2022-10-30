using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTurtorial : MonoBehaviour
{
    public GameObject turtorial;
    public GameObject sister, sister2;

    // Start is called before the first frame update
    void Start()
    {
        sister = GameObject.Find("Sister");
        sister2 = GameObject.Find("Sister2");
        sister.GetComponent<charController>().enabled = true;
        Destroy(turtorial);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
