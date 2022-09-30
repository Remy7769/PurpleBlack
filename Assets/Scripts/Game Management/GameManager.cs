using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //General Data

    public static GameManager instance = null;

    //Player Data

    //Enemy Data

    //Game Data
    public bool isPaused;
    public bool LoadingNewScene;
    public string LastSceneName;


    private void Awake()
    {
        //Destroy the Clone
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
            return;
        }

        //Dont destroy on load
        DontDestroyOnLoad(this);
    }

    //Hp

    //Scene Management
    public void LoadScene(string scenename)
    {
        LastSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(scenename);
        LoadingNewScene = false;
    }

    //Quit info
    public void Quit()
    {
        Application.Quit();
    }
}
