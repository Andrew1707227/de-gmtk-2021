using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialShow : MonoBehaviour
{

    public static bool shown = false;

    public GameObject tutorial;
    public float waitTime = 5;

    private void Awake()
    {
        if (!shown)
        {
            tutorial.SetActive(true);

            StartCoroutine(wait());
        }

    }

    private void Update()
    {
        if (Input.anyKey)
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
