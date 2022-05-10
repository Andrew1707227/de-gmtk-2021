using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialShow : MonoBehaviour
{

    public static bool shown;

    public GameObject tutorial;
    public float waitTime = 5;

    private void Awake()
    {
        shown = bool.Parse(PlayerPrefs.GetString("Tutorial", "false"));
        if (!shown)
        {
            tutorial.SetActive(true);
            PlayerPrefs.SetString("Tutorial", "true");
            StartCoroutine(wait());
        }

    }

    private void Update()
    {
        if (InputV2.anyKey)
        {
            shown = true;
            tutorial.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }

    private IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);
        Time.timeScale = 0.0f;
    }
}
