using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OlderSister : MonoBehaviour
{
    public GameObject gamedaddy;
    // Start is called before the first frame update
    void Start()
    {
        gamedaddy = GameObject.Find("gameDad");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameObject enemyParent = other.gameObject.transform.parent.gameObject;
            
            enemyParent.GetComponent<enemy>().Stop();
        }
        if (other.gameObject.CompareTag("Button1"))
        {
            gamedaddy.GetComponent<gameDad>().Button1();
        }
        if (other.gameObject.CompareTag("Button2"))
        {
            gamedaddy.GetComponent<gameDad>().Button2();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameObject enemyParent = other.gameObject.transform.parent.gameObject;
            enemyParent.GetComponent<enemy>().Resume();
        }

        if (other.gameObject.CompareTag("Button1"))
        {
            gamedaddy.GetComponent<gameDad>().Button1off();
        }
        if (other.gameObject.CompareTag("Button2"))
        {
            gamedaddy.GetComponent<gameDad>().Button2off();
        }
    }
}
