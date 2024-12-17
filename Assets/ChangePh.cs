using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangePh : MonoBehaviour
{
    private int phLvl;
    public TextMeshPro phLabel;

    // Start is called before the first frame update
    void Start()
    {
        phLvl = 3;
        phLabel = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        if (phLvl == 11)
        {

        }
    }

    public void ChangePhLevel(bool incPh)
    {
        if (incPh && phLvl < 14)
        {
            phLvl++;
            phLabel.text = "ph level: " + phLvl;
        }
        else if (!incPh && phLvl > 0)
        {
            phLvl--;
            phLabel.text = "ph level: " + phLvl;
        }
    }
}
