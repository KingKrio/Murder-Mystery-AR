using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnterCode : MonoBehaviour
{
    //public TextMeshProUGUI code;
    public TextMeshPro code;
    public GameObject email;

    // Start is called before the first frame update
    void Start()
    {
        code = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        if (code.text.Length == 3)
        {
            if (code.text.Equals("476"))
            {
                email.SetActive(true);
            }
            else
            {
                code.text = "";
            }
        }
    }
    public void DigitOnShow(string text)
    {
        code.text = code.text + text;
    }
}
