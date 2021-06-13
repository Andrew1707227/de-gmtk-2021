using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Image image;
    public static Sprite currSprite;

    public static int numScore;
    public static bool isUpdating;
    private Text scoreText;

    void Start() {
        isUpdating = true;
        scoreText = GetComponent<Text>();
        numScore = 0;
        currSprite = image.sprite;
    }

    void Update() {
        if (isUpdating) {
            image.sprite = currSprite;
            scoreText.text = "Score: " + numScore + "pts";
        }
    }

}
