using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopButton : MonoBehaviour
{   
    public void Shop()
    {
        AudioManager.Instance.PlaySFX("Click");
        SceneManager.LoadScene(37);
    }
}