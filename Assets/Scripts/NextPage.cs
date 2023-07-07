using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextPage : MonoBehaviour
{
    public void GoNextPage()
    {
        SceneManager.LoadScene(22);
    }
}
