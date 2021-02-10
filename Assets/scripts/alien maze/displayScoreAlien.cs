using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayScoreAlien : MonoBehaviour
{
    public Text ScoreUI1;
    public Text ScoreUI2;
    
    void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Update();
    }

    void Update()
    {
        ScoreUI1.GetComponent<Text>().text = Collect.score + " / 240";
        ScoreUI2.GetComponent<Text>().text = Collect.score + " / 240";
    }
}
