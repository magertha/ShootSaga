using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelControl : MonoBehaviour
{
    LevelCleared levelCleared;

    GameObject bal; //your other object 
    public GameObject came;
    //public GameObject bullet;
    //public GameObject lava;
    //public GameObject lava2;
    public GameObject Ball1, Ball2, Ball3, Ball4, Ball5, Default;
    public float x, y, z;
    Adds adds;
    //public string ballcont; // your second script name 
    //public string right;
    //public string countrr;
    //public string bulletres;

    public void Start()
    {
        Time.timeScale=1;

        adds = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Adds>();

        if (PlayerPrefs.GetInt("equipBall1") == 1)
        {
            Instantiate(Ball1, new Vector3(x, y, z), Quaternion.identity);
            bal =Ball1;
        }
        else if (PlayerPrefs.GetInt("equipBall3") == 1)
        {
            Instantiate(Ball3, new Vector3(x, y, z), Quaternion.identity);
            bal =Ball3;
        }
        else if (PlayerPrefs.GetInt("equipBall2") == 1)
        {
            Instantiate(Ball2, new Vector3(x, y, z), Quaternion.identity);
            bal =Ball2;
        }
        else if (PlayerPrefs.GetInt("equipBall4") == 1)
        {
            Instantiate(Ball4, new Vector3(x, y, z), Quaternion.identity);
            bal =Ball4;
        }
        else if (PlayerPrefs.GetInt("equipBall5") == 1)
        {
            Instantiate(Ball5, new Vector3(x, y, z), Quaternion.identity);
            bal =Ball5;
        }
        else
        {
            Instantiate(Default, new Vector3(x, y, z), Quaternion.identity);
            bal = Default;
        }
        levelCleared=GameObject.FindGameObjectWithTag("LevelCleared").GetComponent<LevelCleared>();

        adds.LoadFullSize();
    }

    IEnumerator EXAFT()
    {
        yield return new WaitForSeconds(0.4f);

        levelCleared.Next();
        Time.timeScale = 0;
    }

    public void Pass()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if(currentLevel >= PlayerPrefs.GetInt("levelsUnlocked"))
        {
            PlayerPrefs.SetInt("levelsUnlocked",currentLevel + 1);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            Rigidbody2D ballRigidbody = bal.GetComponent<Rigidbody2D>();
            AudioManager.Instance.PlaySFX("Net");
            // Check if the ball is moving from up to down
            if (ballRigidbody.velocity.y < 0.1f)
            {
                levelCleared.LC = true;

                Debug.Log("nextlevel");

                StartCoroutine(EXAFT());

                // (bal.GetComponent(ballcont) as MonoBehaviour).enabled = false;
                // (bal.GetComponent(right) as MonoBehaviour).enabled = false;
                // (came.GetComponent(countrr) as MonoBehaviour).enabled = false;
                //(bullet.GetComponent(bulletres) as MonoBehaviour).enabled = false;            
                //(lava.GetComponent(bulletres) as MonoBehaviour).enabled = false;
                //(lava2.GetComponent(bulletres) as MonoBehaviour).enabled = false;

                Pass();
            }
        }
    }
}

