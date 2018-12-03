using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int scoreValue = 1;
    Text scoreText;

    private void Start()
    {
        scoreText = GetComponent<Text>();
    }

    void Update () {
        scoreText.text = "Sacrifices: " + scoreValue;
	}
}
