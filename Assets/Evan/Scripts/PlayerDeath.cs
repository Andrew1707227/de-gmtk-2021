using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PlayerDeath : MonoBehaviour
{
    private bool debounce;
    public Image HScoreImage;
    public GameObject playAgain;
    public GameObject quit;
    public Text HScoreText;
    public static int highScore;
    public Volume volume;

    public AudioClip pitDeath;
    public AudioClip enemyDeath;

    Animator a;
    MagnetPull mp;
    PlayerMove pm;
    AudioSource aSource;

    private void Start()
    {
        a = gameObject.GetComponent<Animator>();
        mp = gameObject.GetComponent<MagnetPull>();
        pm = gameObject.GetComponent<PlayerMove>();
        aSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
        Collider2D[] collisions = Physics2D.OverlapCircleAll(transform.position, .5f);

        for (int i = 0; i < collisions.Length; i++)
        {
            if (collisions[i].gameObject != gameObject &&
                (collisions[i].transform.tag == "Death" || collisions[i].transform.tag == "Enemy") &&
                !debounce)
            {
                debounce = true;
                StartCoroutine(Death());

                pm.enabled = false;
                mp.enabled = false;

                if (collisions[i].transform.tag == "Death")
                {
                    a.SetTrigger("PitDead");
                    aSource.pitch = 1;
                    aSource.clip = pitDeath;
                    aSource.Play();

                }
                else
                {
                    a.SetTrigger("EnemyDead");
                    aSource.pitch = 1;
                    aSource.clip = enemyDeath;
                    aSource.Play();
                }
            }
        }
    }

    public IEnumerator Death() {
        GameObject.Find("PullLoopSFX").GetComponent<AudioSource>().loop = false;
        
        if (volume.profile.TryGet(out DepthOfField dof)) {
            dof.active = true;
        }
        float t = 10;
        Score.isUpdating = false;
        Time.timeScale = .5f;
        HScoreImage.gameObject.SetActive(true);
        HScoreImage.enabled = true;
        HScoreText.gameObject.SetActive(true);
        Color temp = HScoreImage.color;
        while (t >= 0) {
            HScoreImage.color = new Color(temp.r, temp.g, temp.b, .8f - (t / 10));
            t -= Time.deltaTime * 10;
            HScoreImage.rectTransform.anchoredPosition = new Vector2(0, 9 * t * Mathf.Sin(t) - 10);
            yield return null;
        }
        HScoreImage.color = temp;
        if (Score.numScore > highScore) {
            highScore = Score.numScore;
        }
        HScoreText.text = highScore + "pts";
        playAgain.SetActive(true);
        quit.SetActive(true);
        yield return null;
        UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(playAgain);
    }

    public void PlayAgain() {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
