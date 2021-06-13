using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class MagnetPull : MonoBehaviour
{
    [HideInInspector]
    public static bool pullingN = false; //Holds if pulling north
    [HideInInspector]
    public static bool pullingS = false; //Holds if pulling south

    public Sprite redBGround;
    public Sprite blueBGround;
    public Sprite purpleBGround;

    public AudioSource Asource;

    public Color blueColor;
    public Color redColor;
    public Volume volume;

    private bool debounce;

    // Start is called before the first frame update
    void Start()
    {
        //Resets staic varibles
        pullingN = false;
        pullingS = false;
    }

    // Update is called once per frame
    void Update()
    {
        //checks for Nough or South pull keys
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.Mouse0))
        {
            //Toggle pulls
            Score.currSprite = redBGround;
            if (!(Asource.volume == 1)) {
                Asource.pitch = .9f;
                Asource.time = 0;
                Asource.volume = 1;
            }
            if (!debounce) {
                debounce = true;
                StartCoroutine(MagnetPostProcessing(redColor));
            }
            pullingN = true;
            pullingS = false;
        }
        else if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse1))
        {
            //Toggle pulls
            Score.currSprite = blueBGround;
            if (!(Asource.volume == 1)) {
                Asource.pitch = 1f;
                Asource.time = 0;
                Asource.volume = 1;
            }
            if (!debounce) {
                debounce = true;
                StartCoroutine(MagnetPostProcessing(blueColor));
            }
            pullingN = false;
            pullingS = true;
        }
        else //Resets if off
        {
            Score.currSprite = purpleBGround;
            Asource.volume = 0;
            StartCoroutine(MagnetPostProcessing(new Color(1, 0, 1), false));
            pullingN = false;
            pullingS = false;
        }             
    }

    public IEnumerator MagnetPostProcessing(Color color, bool on = true) {
        if (volume.profile.TryGet(out Vignette vignette)) {
            if (!on) {
                vignette.active = false;
                debounce = false;
            } else {
                vignette.intensity.SetValue(new NoInterpFloatParameter(0, true));
                vignette.active = true;
                vignette.color.SetValue(new ColorParameter(color, true));
                for (float i = 0; i <= .71f; i += 5 / 60f) {
                    vignette.intensity.SetValue(new NoInterpFloatParameter(i, true));
                    yield return new WaitForFixedUpdate();
                }
                vignette.intensity.SetValue(new NoInterpFloatParameter(.71f, true));
            }
        }
        yield return null;
    }
}
