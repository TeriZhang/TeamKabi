using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startMenu : MonoBehaviour
{
    public List<GameObject> wall;
    public int current;

    // Start is called before the first frame update
    void Start()
    {
        current = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Begin()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void NextSlide()
    {
        current += 1;
        current = current % wall.Count;

        for (int i = 0; i < 6; i++)
        {
            wall[i].gameObject.SetActive(false);
            wall[current].gameObject.SetActive(true);
        }

    }


}
