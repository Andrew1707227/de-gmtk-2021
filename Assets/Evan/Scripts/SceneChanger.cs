using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    Fader f;
    private void Start()
    {
        f = gameObject.GetComponent<Fader>();
    }

    //Quits game
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Would of quit if built");
    }

    //Loads menu
    public void loadMenu()
    {
        SceneManager.LoadScene(0);
    }

    //Loads level
    public void startGame()
    {
        if (!f.fadeIn)
        {
            StartCoroutine(f.fadeOut());
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }
}
