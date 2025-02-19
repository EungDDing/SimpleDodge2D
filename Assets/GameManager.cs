using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private MoveUFO move;
    private SpawnMeteoroid spawn;

    private void Awake()
    {
        InitManager();
        Meteoroid.GameOver += GameStop;
    }
    private void InitManager()
    {
        move = FindAnyObjectByType<MoveUFO>();
        spawn = FindAnyObjectByType<SpawnMeteoroid>();
    }
    private void GameStop()
    {
        move.StopMove();
        spawn.StopSpawn();
    }
}
