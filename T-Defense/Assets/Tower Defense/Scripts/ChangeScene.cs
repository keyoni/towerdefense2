using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tower_Defense.Scripts
{
    public class ChangeScene : MonoBehaviour
    {
    
        public String gameScene;

        //public String gameOverScene;

        public GameObject startGameBtn;
        // Start is called before the first frame update
        void Start()
        {
            GameManager.GameOverAction += DisplayRestartButton;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    
        public void OpenMainGame()
        {
            SceneManager.LoadScene(gameScene, LoadSceneMode.Single);
        }

        public void RestartGame()
        {
            startGameBtn.SetActive(false);
            OpenMainGame();
        }

        public void DisplayRestartButton()
        {
            startGameBtn.SetActive(true);
        }
    }
}
