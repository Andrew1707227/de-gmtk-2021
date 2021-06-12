using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fader : MonoBehaviour
{

    public bool fadeIn = false;
    public Transform fT;
    public Image fI;
    

    private void Awake()
    {
        if (fadeIn)
        {
            fT.SetAsLastSibling();
            fI.color = new Color(fI.color.r, fI.color.g, fI.color.b, 1);
        }
        else
        {
            fT.SetAsFirstSibling();
            fI.color = new Color(fI.color.r, fI.color.g, fI.color.b, 0);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (fadeIn)
        {
            StartCoroutine(fadein());
        }
    }

    public IEnumerator fadeOut()
    {
        fT.SetAsLastSibling();
        for (float i = 0; i < 1; i += 0.025f)
        {

            fI.color = new Color(fI.color.r, fI.color.g, fI.color.b, i); 

            yield return new WaitForFixedUpdate();
        }

        fI.color = new Color(fI.color.r, fI.color.g, fI.color.b, 1); ;
        SceneManager.LoadScene(1);
    }

    private IEnumerator fadein()
    {
        for (float i = 1; i > 0; i -= 0.025f)
        {

            fI.color = new Color(fI.color.r, fI.color.g, fI.color.b, i);

            yield return new WaitForFixedUpdate();
        }

        fI.color = new Color(fI.color.r, fI.color.g, fI.color.b, 0);
        fT.SetAsFirstSibling();
    }
}
