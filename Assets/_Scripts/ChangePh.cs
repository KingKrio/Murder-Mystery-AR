using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangePh : MonoBehaviour
{
    private int phLvl;
    public TextMeshPro phLabel;
    public GameObject clue;
    public HoldButton blueHold, redHold;


    // Start is called before the first frame update
    void Start()
    {
        phLvl = 0;
        phLabel = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        if (phLvl == 11 && !blueHold.IsPressed && !redHold.IsPressed)
        {
            clue.SetActive(true);
            phLabel.gameObject.SetActive(false);
        }
        else
        {
            if (blueHold.IsPressed)
            {
                ChangePhLevel(false);
            }
            else if (redHold.IsPressed)
            {
                ChangePhLevel(true);
            }
        }
    }

    private void ChangePhLevel(bool incPh)
    {
        if (incPh && phLvl < 14)
        {
            phLvl++;
        }
        else if (!incPh && phLvl > 0)
        {
            phLvl--;
        }
        phLabel.text = "(pH needed is 11)\npH Value: " + phLvl;
    }
}
