using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("LevelMenu");
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void HowToPlayLanjutan()
    {
        SceneManager.LoadScene("HowToPlayLanjutan");
    }
    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }
    public void Back()
    {
       SceneManager.LoadScene("Menu"); 
    }
    public void Quit()
    {
        Application.Quit();
    }
}
