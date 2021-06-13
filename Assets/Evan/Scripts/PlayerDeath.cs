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
    public Text HScoreText;
    public static int highScore;
    public Volume volume;

    // Update is called once per frame
    void Update() {
        Collider2D[] collisions = Physics2D.OverlapCircleAll(transform.position, .5f);

        for (int i = 0; i < collisions.Length; i++)
        {
            if (collisions[i].gameObject != gameObject &&
                (collisions[i].transform.tag == "Death" || collisions[i].transform.tag == "Enemy") &&
                !debounce)
            {
                //Destroy itself
                debounce = true;
                StartCoroutine(Death());
            }
        }
    }

    public IEnumerator Death() {
        GetComponent<SpriteRenderer>().enabled = false;
        
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
        yield return null;
    }

    public void PlayAgain() {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
