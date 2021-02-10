using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PointTerbaru: MonoBehaviour
{
    public Text ScoreUI;
    public TextMeshProUGUI crystalUI;
    public static int score;
    public static int crystalCollected;
//    public AudioBehaviour

    void Awake()
    {
        score = 0;
        crystalCollected = 0;
        Update();
    }

    void Update()
    {
        ScoreUI.GetComponent<Text>().text = "Score : " + score;
        crystalUI.GetComponent<TextMeshProUGUI>().text = crystalCollected + " / 26";
        
        if(crystalCollected == 26)
        {
            SceneManager.LoadScene("FinishOldCastle");
        }
    }
}
