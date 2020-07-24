using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject start;
    public GameObject paintShop;
    public GameObject controls;
        
    // Start screen
    void Start()
    {
        Time.timeScale = 0f;
        start.SetActive(true);
        paintShop.SetActive(false);
    }

    public void StartButton()
    {
        start.SetActive(false);
        paintShop.SetActive(false);
        controls.SetActive(false);
        Time.timeScale = 1f;
    }

    public void paintShopButton()
    {
        start.SetActive(false);
        paintShop.SetActive(true);
        controls.SetActive(false);
    }

    public void ControlsButton()
    {
        start.SetActive(false);
        paintShop.SetActive(false);
        controls.SetActive(true);
    }

    public void BackButton()
    {
        start.SetActive(true);
        paintShop.SetActive(false);
        controls.SetActive(false);
    }

    public void PlayAgain()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
