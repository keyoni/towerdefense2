using System;
using UnityEngine;

namespace Tower_Defense.Scripts
{
    public class MainTower : MonoBehaviour
    {

        public static event Action TowerDestroyed;
        private float _towerHp = 100;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnTriggerEnter(Collider other)
        {
            GameObject currentEnemy = other.gameObject;
            _towerHp -= currentEnemy.GetComponent<Enemy>().health;
            print("Tower Hit! - current hp" + _towerHp);
            Destroy(currentEnemy);
            if (_towerHp <= 0)
            {
                TowerDestroyed?.Invoke();
            }
        }
    }
}
