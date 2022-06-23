using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreViewer : MonoBehaviour
{
    [SerializeField] PlayerController PlayerController;
    Text textScore;

    private void Awake()
    {
        textScore = GetComponent<Text>();
    }

    private void Update()
    {
        textScore.text = "Score " + PlayerController.Score;
    }
}
