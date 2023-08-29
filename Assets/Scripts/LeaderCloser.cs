using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderCloser : MonoBehaviour
{
    public GameObject leaderboard;

    public void Closer()
    {
        AudioManager.Instance.PlaySFX("Click");
        leaderboard.SetActive(false);
    }
}
