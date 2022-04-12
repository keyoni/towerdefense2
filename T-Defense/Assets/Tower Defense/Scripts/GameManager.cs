using System;
using System.Collections;
using System.Collections.Generic;
using Tower_Defense.Scripts;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static event Action GameOverAction;
    // Start is called before the first frame update
    void Start()
    {
        MainTower.TowerDestroyed += GameOver;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GameOver()
    {
        GameOverAction?.Invoke();
    }
}
