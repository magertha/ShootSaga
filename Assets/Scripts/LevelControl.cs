using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelControl : MonoBehaviour
{
    LevelCleared levelCleared;

    GameObject bal; //your other object 
    public GameObject came;
    Animator animator;
    public bool basketer;
    public float basketerFloat;
    //public GameObject bullet;
    //public GameObject lava;
    //public GameObject lava2;
    public GameObject Ball1, Ball2, Ball3, Ball4, Ball5, Ball6, Ball7, Ball8, Ball9, Ball10, Ball11, Ball12, Ball13, Ball14, Ball15, Ball16, Ball17, Ball18, Ball19, Default;
    public float x, y, z;
    Adds adds;
    //public string ballcont; // your second script name 
    //public string right;
    //public string countrr;
    //public string bulletres;

    public void Start()
    {
        Time.timeScale=1;
        basketer = false;
        basketerFloat = 0;
        //Ball1 = GameObject.FindGameObjectWithTag("Ball1");
        //Ball2 = GameObject.FindGameObjectWithTag("Ball2");
        //Ball3 = GameObject.FindGameObjectWithTag("Ball3");
        //Ball4 = GameObject.FindGameObjectWithTag("Ball4");
        //Ball5 = GameObject.FindGameObjectWithTag("Ball5");
        //Ball6 = GameObject.FindGameObjectWithTag("Ball6");
        //Ball7 = GameObject.FindGameObjectWithTag("Ball7");
        //Ball8 = GameObject.FindGameObjectWithTag("Ball8");
        //Ball9 = GameObject.FindGameObjectWithTag("Ball9");
        //Ball10 = GameObject.FindGameObjectWithTag("Ball10");
        //Ball11 = GameObject.FindGameObjectWithTag("Ball11");
        //Ball12 = GameObject.FindGameObjectWithTag("Ball12");
        //Ball13 = GameObject.FindGameObjectWithTag("Ball13");
        //Ball14 = GameObject.FindGameObjectWithTag("Ball14");
        //Ball15 = GameObject.FindGameObjectWithTag("Ball15");
        //Ball16 = GameObject.FindGameObjectWithTag("Ball16");
        //Ball17 = GameObject.FindGameObjectWithTag("Ball17");
        //Ball18 = GameObject.FindGameObjectWithTag("Ball18");
        //Ball19 = GameObject.FindGameObjectWithTag("Ball19");
        //Default = GameObject.FindGameObjectWithTag("BallDefault");

        adds = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Adds>();
        animator = gameObject.GetComponent<Animator>();
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
        else if (PlayerPrefs.GetInt("equipBall6") == 1)
        {
            Instantiate(Ball6, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball6;
        }
        else if (PlayerPrefs.GetInt("equipBall7") == 1)
        {
            Instantiate(Ball7, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball7;
        }
        else if (PlayerPrefs.GetInt("equipBall8") == 1)
        {
            Instantiate(Ball8, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball8;
        }
        else if (PlayerPrefs.GetInt("equipBall9") == 1)
        {
            Instantiate(Ball9, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball9;
        }
        else if (PlayerPrefs.GetInt("equipBall10") == 1)
        {
            Instantiate(Ball10, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball10;
        }
        else if (PlayerPrefs.GetInt("equipBall11") == 1)
        {
            Instantiate(Ball11, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball11;
        }
        else if (PlayerPrefs.GetInt("equipBall12") == 1)
        {
            Instantiate(Ball12, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball12;
        }
        else if (PlayerPrefs.GetInt("equipBall13") == 1)
        {
            Instantiate(Ball13, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball13;
        }
        else if (PlayerPrefs.GetInt("equipBall14") == 1)
        {
            Instantiate(Ball14, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball14;
        }
        else if (PlayerPrefs.GetInt("equipBall15") == 1)
        {
            Instantiate(Ball15, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball15;
        }
        else if (PlayerPrefs.GetInt("equipBall16") == 1)
        {
            Instantiate(Ball16, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball16;
        }
        else if (PlayerPrefs.GetInt("equipBall17") == 1)
        {
            Instantiate(Ball17, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball17;
        }
        else if (PlayerPrefs.GetInt("equipBall18") == 1)
        {
            Instantiate(Ball18, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball18;
        }
        else if (PlayerPrefs.GetInt("equipBall19") == 1)
        {
            Instantiate(Ball19, new Vector3(x, y, z), Quaternion.identity);
            bal = Ball19;
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
            animator.SetBool("basket", true);
            basketer = true;
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
    private void Update()
    {
        if (basketer == true)
        {
            basketerFloat += Time.deltaTime;
        }
        if (basketerFloat >= 0.2f)
        {
            basketer = false;
            basketerFloat = 0;
            animator.SetBool("basket", false);
        }
    }
}

