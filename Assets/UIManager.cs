using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOver;

    private void Awake()
    {
        gameOver.SetActive(false);
        Meteoroid.GameOver += OpenGameOver;
    }

    public void OpenGameOver()
    {
        gameOver.SetActive(true);
    }
}
