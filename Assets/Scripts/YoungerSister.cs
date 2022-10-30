using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YoungerSister : MonoBehaviour
{
    public float deathTimer,deathTime;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
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
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameObject enemyParent = other.gameObject.transform.parent.gameObject;
            enemyParent.GetComponent<enemy>().Resume();
            speed = -1;
        }
    }

    public void DeathTimer(int speed)
    {
        deathTime += speed * Time.deltaTime;
    }
}
