using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Image image;
    public static Sprite currSprite;

    public static int numScore;
    private Text scoreText;

    void Start() {
        scoreText = GetComponent<Text>();
        currSprite = image.sprite;
    }

    void Update() {
        image.sprite = currSprite;
        scoreText.text = "Score: " + numScore + "pts";
    }

}
