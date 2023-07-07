using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int index;
    public string levelName;

    public void PassNext()
    {
        SceneManager.LoadScene(index);

        SceneManager.LoadScene(levelName);
    }
}
