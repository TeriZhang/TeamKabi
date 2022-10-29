using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public GameObject pauseUI;

    public GameObject quitUI;

    public GameObject reStartUI;

    public GameObject SoundUI;

    public GameObject SoundOnUI;

    public GameObject SoundOffUI;

    AudioSource audioSource;
    
    public bool isplay;
    public bool pauseOpen;
    
    
    // Start is called before the first frame update
    void Start()
    {
        pauseUI.SetActive(true);

        quitUI.SetActive(false);

        SoundUI.SetActive(false);

        reStartUI.SetActive(false);


        SoundOffUI.SetActive(false);
        SoundOnUI.SetActive(false);

        audioSource = GetComponent<AudioSource>();
        GetComponent<AudioSource>().Play();

        isplay = true;

        pauseOpen = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isplay == false)
        {
            audioSource = GetComponent<AudioSource>();
            GetComponent<AudioSource>().Pause();
        }

        

        if(pauseOpen == true)
        {
            pauseUI.SetActive(false);

            quitUI.SetActive(true);

            SoundUI.SetActive(true);

            reStartUI.SetActive(true);
        }

        else if(pauseOpen == false)
        {
            pauseUI.SetActive(true);

            quitUI.SetActive(false);

            SoundUI.SetActive(false);

            reStartUI.SetActive(false);

            SoundOnUI.SetActive(false);
            SoundOffUI.SetActive(false);
        }

        if (pauseOpen == true && isplay == true)
        {
            SoundOnUI.SetActive(true);
            SoundOffUI.SetActive(false);
        }

        else if (pauseOpen == true && isplay == false)
        {
            SoundOnUI.SetActive(false);
            SoundOffUI.SetActive(true);
        }

     
    }

    public void PauseMenuOn()
    {

        Debug.Log(111);
        pauseOpen = true;
        Invoke("PauseBack", 5f);

    }

    public void PauseBack()
    {
        pauseOpen = false;
    }

    public void Quitthegame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MuteSound()
    {
        isplay = false;
         
    }

    public void CountinueSound()
    {
        isplay = true;
        audioSource = GetComponent<AudioSource>();
        GetComponent<AudioSource>().Play();

    }
}
