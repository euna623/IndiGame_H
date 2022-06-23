using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreViewer : MonoBehaviour
{
    [SerializeField] PlayerController PlayerController;
    TextMeshProUGUI textScore;

    private void Awake()
    {
        textScore = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        textScore.text = "Score " + PlayerController.Score;
    }
}
