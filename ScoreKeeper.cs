using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    public static int score;

    private Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }
	public void Score (int points)
    {
        score += points;
        text.text = "Score: " + score.ToString();
    }

    public static void Reset()
    {
        score = 0;
    }
}
