using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Achievements : MonoBehaviour
{
    private int diamondValue;
    private int coinValue;
    public Button[] buttons;
    public Image[] locks;

    private void Start()
    {
        PlayerPrefs.GetInt("Coin100", 0);
        PlayerPrefs.GetInt("Diammond2a", 0);
        PlayerPrefs.GetInt("Diammond3a", 0);
        PlayerPrefs.GetInt("Diammond5a", 0);
        PlayerPrefs.GetInt("Diammond7", 0);
        PlayerPrefs.GetInt("Diammond10", 0);
        PlayerPrefs.GetInt("Coin300", 0);
        PlayerPrefs.GetInt("Diammond2b", 0);
        PlayerPrefs.GetInt("Diammond3b", 0);
        PlayerPrefs.GetInt("Diammond5b", 0);
        PlayerPrefs.GetInt("Diammond1a", 0);
        PlayerPrefs.GetInt("Diammond3c", 0);
        PlayerPrefs.GetInt("Diammond5c", 0);
        PlayerPrefs.GetInt("Diammond1b", 0);
        PlayerPrefs.GetInt("Diammond3d", 0);
        PlayerPrefs.GetInt("Diammond5d", 0);

        //kazanýnca buton büyüyüp küçülsün:
        if (PlayerPrefs.GetFloat("high") >= 5 && PlayerPrefs.GetInt("Coin100") == 0)
        {

            buttons[0].animator.SetBool("Highlighted", true);
        }

        if (PlayerPrefs.GetFloat("high") >= 10 && PlayerPrefs.GetInt("Diammond2a") == 0)
        {
            buttons[1].animator.SetBool("Highlighted", true);
        }


        if (PlayerPrefs.GetFloat("high") >= 25 && PlayerPrefs.GetInt("Diammond3a") == 0)
        {
            buttons[2].animator.SetBool("Highlighted", true);
        }

        if (PlayerPrefs.GetFloat("high") >= 40 && PlayerPrefs.GetInt("Diammond5a") == 0)
        {
            buttons[3].animator.SetBool("Highlighted", true);
        }

        if (PlayerPrefs.GetInt("levelsUnlocked") - 1 >= 3 && PlayerPrefs.GetInt("Diammond7") == 0)
        {
            buttons[4].animator.SetBool("Highlighted", true);
        }

        if (PlayerPrefs.GetInt("levelsUnlocked") - 1 >= 5 && PlayerPrefs.GetInt("Diammond10") == 0)
        {
            buttons[5].animator.SetBool("Highlighted", true);
        }

        if (PlayerPrefs.GetInt("levelsUnlocked") - 1 >= 10 && PlayerPrefs.GetInt("Coin300") == 0)
        {
            buttons[6].animator.SetBool("Highlighted", true);
        }

        if (PlayerPrefs.GetInt("levelsUnlocked") - 1 >= 20 && PlayerPrefs.GetInt("Diammond2b") == 0)
        {
            buttons[7].animator.SetBool("Highlighted", true);
        }

        if (PlayerPrefs.GetInt("levelsUnlocked") - 1 >= 30 && PlayerPrefs.GetInt("Diammond3b") == 0)
        {
            buttons[8].animator.SetBool("Highlighted", true);
        }

        if (PlayerPrefs.GetInt("levelsUnlocked") - 1 >= 40 && PlayerPrefs.GetInt("Diammond5b") == 0)
        {
            buttons[9].animator.SetBool("Highlighted", true);
        }
    }


    void Update()
    {

        if (PlayerPrefs.GetFloat("high") >= 5 && PlayerPrefs.GetInt("Coin100") == 0)
        {
            buttons[0].interactable = true;
        }
        else
        {
            buttons[0].gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Coin100") != 0)
        {
            locks[0].enabled = false;
        }

        if (PlayerPrefs.GetFloat("high") >= 10 && PlayerPrefs.GetInt("Diammond2a") == 0)
        {
            buttons[1].interactable = true;
        }
        else
        {
            buttons[1].gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Diammond2a") != 0)
        {
            locks[1].enabled = false;
        }

        if (PlayerPrefs.GetFloat("high") >= 25 && PlayerPrefs.GetInt("Diammond3a") == 0)
        {
            buttons[2].interactable = true;
        }
        else
        {
            buttons[2].gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Diammond3a") != 0)
        {
            locks[2].enabled = false;
        }
        if (PlayerPrefs.GetFloat("high") >= 40 && PlayerPrefs.GetInt("Diammond5a") == 0)
        {
            buttons[3].interactable = true;
        }
        else
        {
            buttons[3].gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Diammond5a") != 0)
        {
            locks[3].enabled = false;
        }
        if (PlayerPrefs.GetInt("levelsUnlocked") - 1 >= 3 && PlayerPrefs.GetInt("Diammond7") == 0)
        {
            buttons[4].interactable = true;
        }
        else
        {
            buttons[4].gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Diammond7") != 0)
        {
            locks[4].enabled = false;
        }
        if (PlayerPrefs.GetInt("levelsUnlocked") - 1 >= 5 && PlayerPrefs.GetInt("Diammond10") == 0)
        {
            buttons[5].interactable = true;
        }
        else
        {
            buttons[5].gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Diammond10") != 0)
        {
            locks[5].enabled = false;
        }
        if (PlayerPrefs.GetInt("levelsUnlocked") - 1 >= 10 && PlayerPrefs.GetInt("Coin300") == 0)
        {
            buttons[6].interactable = true;
        }
        else
        {
            buttons[6].gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Coin300") != 0)
        {
            locks[6].enabled = false;
        }
        if (PlayerPrefs.GetInt("levelsUnlocked") - 1 >= 20 && PlayerPrefs.GetInt("Diammond2b") == 0)
        {
            buttons[7].interactable = true;
        }
        else
        {
            buttons[7].gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Diammond2b") != 0)
        {
            locks[7].enabled = false;
        }
        if (PlayerPrefs.GetInt("levelsUnlocked") - 1 >= 30 && PlayerPrefs.GetInt("Diammond3b") == 0)
        {
            buttons[8].interactable = true;
        }
        else
        {
            buttons[8].gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Diammond3b") != 0)
        {
            locks[8].enabled = false;
        }
        if (PlayerPrefs.GetInt("levelsUnlocked") - 1 >= 40 && PlayerPrefs.GetInt("Diammond5b") == 0)
        {
            buttons[9].interactable = true;
        }
        else
        {
            buttons[9].gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Diammond5b") != 0)
        {
            locks[9].enabled = false;
        }
    }

    public void Diamond1a()
    {
        diamondValue = PlayerPrefs.GetInt("Diamond");
        diamondValue += 1;
        PlayerPrefs.SetInt("Diamond", diamondValue);
        PlayerPrefs.SetInt("Diammond1a", 1);
        PlayerPrefs.Save();
        AudioManager.Instance.PlaySFX("Click");
    }
    public void Diamond1b()
    {
        diamondValue = PlayerPrefs.GetInt("Diamond");
        diamondValue += 1;
        PlayerPrefs.SetInt("Diamond", diamondValue);
        PlayerPrefs.SetInt("Diammond1b", 1);
        PlayerPrefs.Save();
        AudioManager.Instance.PlaySFX("Click");
    }
    public void Diamond2a()
    {
        coinValue = PlayerPrefs.GetInt("TotalCoins");
        coinValue += 250;
        PlayerPrefs.SetInt("TotalCoins", coinValue);
        PlayerPrefs.SetInt("Diammond2a", 1);
        PlayerPrefs.Save();
        AudioManager.Instance.PlaySFX("Click");
    }
    public void Diamond2b()
    {
        diamondValue = PlayerPrefs.GetInt("Diamond");
        diamondValue += 2;
        PlayerPrefs.SetInt("Diamond", diamondValue);
        PlayerPrefs.SetInt("Diammond2b", 1);
        PlayerPrefs.Save();
        AudioManager.Instance.PlaySFX("Click");
    }
    public void Diamond3a()
    {
        diamondValue = PlayerPrefs.GetInt("Diamond");
        diamondValue += 3;
        PlayerPrefs.SetInt("Diamond", diamondValue);
        PlayerPrefs.SetInt("Diammond3a", 1);
        PlayerPrefs.Save();
        AudioManager.Instance.PlaySFX("Click");
    }
    public void Diamond3b()
    {
        diamondValue = PlayerPrefs.GetInt("Diamond");
        diamondValue += 3;
        PlayerPrefs.SetInt("Diamond", diamondValue);
        PlayerPrefs.SetInt("Diammond3b", 1);
        PlayerPrefs.Save();
        AudioManager.Instance.PlaySFX("Click");
    }
    public void Diamond3c()
    {
        diamondValue = PlayerPrefs.GetInt("Diamond");
        diamondValue += 3;
        PlayerPrefs.SetInt("Diamond", diamondValue);
        PlayerPrefs.SetInt("Diammond3c", 1);
        PlayerPrefs.Save();
        AudioManager.Instance.PlaySFX("Click");
    }
    public void Diamond3d()
    {
        diamondValue = PlayerPrefs.GetInt("Diamond");
        diamondValue += 3;
        PlayerPrefs.SetInt("Diamond", diamondValue);
        PlayerPrefs.SetInt("Diammond3d", 1);
        PlayerPrefs.Save();
        AudioManager.Instance.PlaySFX("Click");
    }
    public void Diamond5a()
    {
        diamondValue = PlayerPrefs.GetInt("Diamond");
        diamondValue += 5;
        PlayerPrefs.SetInt("Diamond", diamondValue);
        PlayerPrefs.SetInt("Diammond5a", 1);
        PlayerPrefs.Save();
        AudioManager.Instance.PlaySFX("Click");
    }
    public void Diamond5b()
    {
        diamondValue = PlayerPrefs.GetInt("Diamond");
        diamondValue += 5;
        PlayerPrefs.SetInt("Diamond", diamondValue);
        PlayerPrefs.SetInt("Diammond5b", 1);
        PlayerPrefs.Save();
        AudioManager.Instance.PlaySFX("Click");
    }
    public void Diamond5c()
    {
        diamondValue = PlayerPrefs.GetInt("Diamond");
        diamondValue += 5;
        PlayerPrefs.SetInt("Diamond", diamondValue);
        PlayerPrefs.SetInt("Diammond5c", 1);
        PlayerPrefs.Save();
        AudioManager.Instance.PlaySFX("Click");
    }
    public void Diamond5d()
    {
        diamondValue = PlayerPrefs.GetInt("Diamond");
        diamondValue += 5;
        PlayerPrefs.SetInt("Diamond", diamondValue);
        PlayerPrefs.SetInt("Diammond5d", 1);
        PlayerPrefs.Save();
        AudioManager.Instance.PlaySFX("Click");
    }
    public void Diamond7()
    {
        coinValue = PlayerPrefs.GetInt("TotalCoins");
        coinValue += 150;
        PlayerPrefs.SetInt("TotalCoins", coinValue);
        PlayerPrefs.SetInt("Diammond7", 1);
        PlayerPrefs.Save();
        AudioManager.Instance.PlaySFX("Click");
    }
    public void Diamond10()
    {
        coinValue = PlayerPrefs.GetInt("TotalCoins");
        coinValue += 200;
        PlayerPrefs.SetInt("TotalCoins", coinValue);
        PlayerPrefs.SetInt("Diammond10", 1);
        PlayerPrefs.Save();
        AudioManager.Instance.PlaySFX("Click");
    }
    public void Coin100()
    {
        coinValue = PlayerPrefs.GetInt("TotalCoins");
        coinValue += 150;
        PlayerPrefs.SetInt("TotalCoins", coinValue);
        PlayerPrefs.SetInt("Coin100", 1);
        PlayerPrefs.Save();
        AudioManager.Instance.PlaySFX("Click");
    }
    public void Coin300()
    {
        coinValue = PlayerPrefs.GetInt("TotalCoins");
        coinValue += 300;
        PlayerPrefs.SetInt("TotalCoins", coinValue);
        PlayerPrefs.SetInt("Coin300", 1);
        PlayerPrefs.Save();
        AudioManager.Instance.PlaySFX("Click");
    }


}
