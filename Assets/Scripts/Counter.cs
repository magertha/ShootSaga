using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    public TMP_Text counterText;
    public int count;

    public void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (count > 0)
            {
                count = count - 1;
                counterText.text = "x" + count.ToString();
            }
        }

    }
}
