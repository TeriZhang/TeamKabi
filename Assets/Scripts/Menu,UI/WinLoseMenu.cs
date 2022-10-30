using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reStart()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void Retry1()
    {
        SceneManager.LoadScene(1);
    }

    public void Retry2()
    {
        SceneManager.LoadScene(2);
    }

    public void Retry3()
    {
        SceneManager.LoadScene(3);
    }
}
