using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class updateScore : MonoBehaviour
{
    public TextMeshProUGUI ScoreUI;
    public TextMeshProUGUI crystalUI;
    public static int score;
    public static int crystalCollected;

    void Awake()
    {
        score = 0;
        crystalCollected = 0;
        Update();
    }

    void Update()
    {
        ScoreUI.GetComponent<TextMeshProUGUI>().text = "Score : " + score;
        crystalUI.GetComponent<TextMeshProUGUI>().text = crystalCollected + " / 26";
        
        if(crystalCollected == 26)
        {
            SceneManager.LoadScene("FinishGarden");
        }
    }
}
