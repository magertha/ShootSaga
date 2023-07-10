using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaderButton : MonoBehaviour
{
    public GameObject leaderboard;
    public void Leader()
    {
        leaderboard.SetActive(true);
    }
}

