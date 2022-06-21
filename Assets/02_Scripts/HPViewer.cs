using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPViewer : MonoBehaviour
{
    [SerializeField] private PlayerHP playerHP;
    private Slider HP;

    private void Awake()
    {
        HP = GetComponent<Slider>();
    }

    private void Update()
    {
        HP.value = playerHP.CurHP / playerHP.MaxHP;
    }
}
