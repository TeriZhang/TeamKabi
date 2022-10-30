using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTurtorial : MonoBehaviour
{
    public GameObject turtorial;
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(turtorial);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
