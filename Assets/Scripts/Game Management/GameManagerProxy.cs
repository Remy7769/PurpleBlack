using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerProxy : MonoBehaviour
{
    //Load Scene
    public void NextScene(string scene)
    {
        GameManager.instance.LoadScene(scene);
        Debug.Log("Loading" + scene);

    }

    //Quit
    public void Quit()
    {
        GameManager.instance.Quit();
        Debug.Log("Quit!");
    }
}
