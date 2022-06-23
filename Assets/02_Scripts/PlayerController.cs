using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] string nextSceneName;
    [SerializeField] StageData stageData;
    private Weapon weapon;
    [SerializeField] GameObject attackPrefab;

    int score;
    public int Score
    {
        set => score = Mathf.Max(0, value);
        get => score;
    }

    private void Awake()
    {
        weapon = GetComponent<Weapon>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(attackPrefab, transform.position, Quaternion.identity);
        }
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, stageData.LimitMin.x, stageData.LimitMax.x),
                                         Mathf.Clamp(transform.position.y, stageData.LimitMin.y, stageData.LimitMax.y));
    }

    public void OnDie()
    {
        PlayerPrefs.SetInt("Score", score);
        SceneManager.LoadScene(nextSceneName);
    }
}
