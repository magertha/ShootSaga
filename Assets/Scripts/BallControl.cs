using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallControl : MonoBehaviour
{
    public float force = 10f;
    public GameObject ballPrediction;
    private Rigidbody2D rb;

    public static bool inputen = true;

    private Vector2 defaultBallPosition;
    private Vector2 startPoint;
    private Vector2 endPoint;

    private Scene sceneMain;

    private PhysicsScene2D sceneMainPhysics;

    private Scene scenePrediction;

    private PhysicsScene2D scenePredictionPhysics;

    //Camera cam;
    //Vector2 force;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        defaultBallPosition = transform.position;

        Physics2D.simulationMode = SimulationMode2D.Script;

        sceneMain = SceneManager.CreateScene("AnaScene");
        sceneMainPhysics = sceneMain.GetPhysicsScene2D();

        CreateSceneParameters sceneParameters = new CreateSceneParameters(LocalPhysicsMode.Physics2D);
        scenePrediction = SceneManager.CreateScene("TahminScene", sceneParameters);
        scenePredictionPhysics = scenePrediction.GetPhysicsScene2D();
    }

    private void Update()
    {
        if (inputen == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                startPoint = getMousePosition();
            }

            if (Input.GetMouseButton(0))
            {
                Vector2 dragPosition = getMousePosition();
                Vector2 power = startPoint - dragPosition;
                if(power.x >=1.5f)
                {
                    power.x = 1.5f;
                }
                if(power.y >=2.3f)
                {
                    power.y = 2.3f;
                }

                GameObject newBallPrediction = GameObject.Instantiate(ballPrediction);
                SceneManager.MoveGameObjectToScene(newBallPrediction, scenePrediction);
                newBallPrediction.transform.position = transform.position;

                newBallPrediction.GetComponent<Rigidbody2D>().AddForce(power * force, ForceMode2D.Impulse);

                LineRenderer ballLine = GetComponent<LineRenderer>();
                ballLine.positionCount = 50;

                for (int i = 0; i < 50; i++)
                {
                    scenePredictionPhysics.Simulate(Time.fixedDeltaTime);
                    ballLine.SetPosition(i, new Vector3(newBallPrediction.transform.position.x, newBallPrediction.transform.position.y, 15));
                }

                Destroy(newBallPrediction);
                //tl.RenderLine(startPoint, currentPoint*1.16f);
            }

            if (Input.GetMouseButtonUp(0))
            {
                GetComponent<LineRenderer>().positionCount = 0;
                endPoint = getMousePosition();

                Vector2 power = startPoint - endPoint;
                if (power.x >= 1.5f)
                {
                    power.x = 1.5f;
                }
                if (power.y >= 2.3f)
                {
                    power.y = 2.3f;
                }
                rb.AddForce(power * force, ForceMode2D.Impulse);
                //tl.EndLine();
            }
        }

    }

    void FixedUpdate()
    {
        if (!sceneMainPhysics.IsValid()) return;

        sceneMainPhysics.Simulate(Time.fixedDeltaTime);
    }

    private Vector2 getMousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioManager.Instance.PlaySFX("Bounce");

        if (collision.gameObject.CompareTag("Jump"))
        {
            AudioManager.Instance.PlaySFX("Boing");
        }
    }
    
    
}