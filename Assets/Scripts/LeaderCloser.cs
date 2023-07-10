using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderCloser : MonoBehaviour
{
    public GameObject leaderboard;

    public void Closer()
    {
        leaderboard.SetActive(false);
    }
}
