using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouScoreViewer : MonoBehaviour
{
    Text textYouScore;

    private void Awake()
    {
        textYouScore = GetComponent<Text>();
        int score = PlayerPrefs.GetInt("Score");
        textYouScore.text = "You Score " + score;
    }
}
