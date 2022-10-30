using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    public GameObject sisterIcon,gameDad,hideSister;
    public Transform leftS, rightS, topS, bottomS;

    public bool hidden,left, right, top, bottom;
    // Start is called before the first frame update
    void Start()
    {
        gameDad = GameObject.Find("gameDad");
        sisterIcon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(hidden == true)
        {
            if(gameDad.GetComponent<gameDad>().sister == true)
            {
                if (Input.GetKeyDown(KeyCode.A) && left == true)
                {
                    hideSister.transform.position = leftS.position;
                    hideSister.SetActive(true);
                    sisterIcon.SetActive(false);
                    hidden = false;
                }
                if (Input.GetKeyDown(KeyCode.D) && right == true)
                {
                    hideSister.transform.position = rightS.position;
                    hideSister.SetActive(true);
                    sisterIcon.SetActive(false);
                    hidden = false;
                }
                if (Input.GetKeyDown(KeyCode.W) && top == true)
                {
                    hideSister.transform.position = topS.position;
                    hideSister.SetActive(true);
                    sisterIcon.SetActive(false);
                    hidden = false;
                    
                }
                if (Input.GetKeyDown(KeyCode.S) && bottom == true)
                {
                    hideSister.transform.position = bottomS.position;
                    hideSister.SetActive(true);
                    sisterIcon.SetActive(false);
                    hidden = false;
                }
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Sister2"))
        {
            hidden = true;
            hideSister = other.gameObject;
            hideSister.SetActive(false);
            sisterIcon.SetActive(true);
        }
    }
}
