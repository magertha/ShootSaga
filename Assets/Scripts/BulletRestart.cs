using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletRestart : MonoBehaviour
{
    public int index;
    LevelCleared levelCleared;
    
    public string levelName;
    public GameObject bal; //your other object 
    //public GameObject came;
    //public string ballcont; // your second script name 
    //public string right;
    //public string countrr;
    GameOverScreen gameOverScreen;

    void Start(){
        gameOverScreen=GameObject.FindGameObjectWithTag("GameOverScreen").GetComponent<GameOverScreen>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameOverScreen.Setup();

            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Counter>().enabled = false;

        }
    }
}
