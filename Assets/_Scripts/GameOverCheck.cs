using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverCheck : MonoBehaviour
{
    public TextMeshPro gameOverTxt;
    // Start is called before the first frame update
    void Start()
    {
        gameOverTxt = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckForKiller(string suspect)
    {
        if (suspect.Equals("h"))
            gameOverTxt.text = "YOU WIN!";
        else
            gameOverTxt.text = "YOU LOSE!";
    }
}
