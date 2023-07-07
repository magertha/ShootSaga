using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Strter : MonoBehaviour
{
    float count = 3;
    public TMP_Text strtr;
    public GameObject strtngPanel;

    IEnumerator EX3()
    {
        yield return new WaitForSeconds(2.4f);

        strtngPanel.SetActive(false);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count -= Time.deltaTime;
        double b = System.Math.Round(count, 0);
        strtr.text = b.ToString();
        StartCoroutine(EX3());
    }
}
