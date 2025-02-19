using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOver;
    [SerializeField] private TextMeshProUGUI timerText;
    private float time;

    private void Awake()
    {
        time = 0;
        gameOver.SetActive(false);
        Meteoroid.GameOver += OpenGameOver;
    }
    private void Update()
    {
        time += Time.deltaTime;
        timerText.text = string.Format("{0}", (int)time);
    }

    public void OpenGameOver()
    {
        gameOver.SetActive(true);
    }
}
