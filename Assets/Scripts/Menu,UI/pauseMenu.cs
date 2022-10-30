using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public GameObject pauseUI;

    public GameObject quitUI;

    public GameObject reStartUI;


    public GameObject SoundOnUI;

    public GameObject SoundOffUI;

    AudioSource audioSource;
    
    public bool isplay;
    public bool pauseOpen;

    gameDad gamedad;

    public AudioClip sisMusic;
    public AudioClip sisMusic2;


    // Start is called before the first frame update
    void Start()
    {
        pauseUI.SetActive(true);

        quitUI.SetActive(false);

        reStartUI.SetActive(false);


        SoundOffUI.SetActive(false);
        SoundOnUI.SetActive(false);

        audioSource = GetComponent<AudioSource>();
        GetComponent<AudioSource>().Play();

        isplay = true;

        pauseOpen = false;

        gamedad = GameObject.Find("gameDad").GetComponent<gameDad>();

    }

    // Update is called once per frame
    void Update()
    {
      

        if (isplay == true)
        {
            audioSource = GetComponent<AudioSource>();
            GetComponent<AudioSource>().Pause();
        }

        

        if(pauseOpen == true)
        {
            pauseUI.SetActive(false);

            quitUI.SetActive(true);

            reStartUI.SetActive(true);
        }

        else if(pauseOpen == false)
        {
            pauseUI.SetActive(true);

            quitUI.SetActive(false);

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

        if(gamedad.sister == true)
        {
            audioSource.clip = sisMusic;
            GetComponent<AudioSource>().Play();
        }


        if(gamedad.sister == false)
        {
            audioSource.clip = sisMusic2;
            GetComponent<AudioSource>().Play();
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
        SceneManager.LoadScene(0);
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
