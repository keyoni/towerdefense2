using UnityEngine;

namespace Tower_Defense.Scripts
{
    public class SoundManager : MonoBehaviour
    {
        private AudioSource _audioSource;

        public AudioClip enemyDied;
        public AudioClip towerDied;
        
        // Start is called before the first frame update
        void Start()
        {
            _audioSource = GetComponent<AudioSource>();
            Enemy.OnEnemyDied += EnemyDiedSound;
            
            
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        void EnemyDiedSound(Enemy enemy)
        {
           
            _audioSource.PlayOneShot(enemyDied);
             print("AudioPlayed");
        }

        void TowerDiedSound()
        {
            
            _audioSource.PlayOneShot(towerDied);
            print("AudioPlayed");
        }
        
        
    }
}
