using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YoungerSister : MonoBehaviour
{
    public float deathTimer,deathTime;
    public int speed;
    public GameObject gamedaddy;
    // Start is called before the first frame update
    void Start()
    {
        gamedaddy = GameObject.Find("gameDad");
    }

    // Update is called once per frame
    void Update()
    {
        DeathTimer(speed);
        if(deathTime < 0)
        {
            deathTime = 0;
        }
        if(deathTime > deathTimer)
        {
            SceneManager.LoadScene("Scene_Lose");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameObject enemyParent = other.gameObject.transform.parent.gameObject;

            enemyParent.GetComponent<enemy>().Detected();
            speed = 1;
        }

        if (other.gameObject.CompareTag("Exit"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); ;
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
            speed = -1;
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

    public void DeathTimer(int speed)
    {
        deathTime += speed * Time.deltaTime;
    }
}
