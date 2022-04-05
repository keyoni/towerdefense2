using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinTracker : MonoBehaviour
{
    private TextMeshProUGUI _coinText;

    public int currentCoin = 0;
    // Start is called before the first frame update
    void Start()
    {
        Enemy.OnEnemyDied += EnemyDrops;
        PlaceTower9001.OnTowerPlaced += TowerPlaced;
        _coinText = GetComponent<TextMeshProUGUI>();
        _coinText.text = currentCoin.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EnemyDrops(Enemy enemy)
    {
        currentCoin += enemy.coinWorth;
        _coinText.text = currentCoin.ToString();
    }

    public int GetCurrentTotal()
    {
        return currentCoin;
    }

    void TowerPlaced()
    {
        currentCoin -= 6;
        _coinText.text = currentCoin.ToString();
        
    }
    
}
