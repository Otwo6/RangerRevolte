using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject settingsMenu;
    [SerializeField] private GameObject introMenu;
    [SerializeField] private AudioSource musicAudio;
    [SerializeField] private Image alter;
    [SerializeField] private Image logo;

    bool inCine = false;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(inCine)
            {
                OpenGame();
            }
        }
    }

    public void NewGame()
    {
        //SceneManager.LoadScene("SampleScene");
        musicAudio.DOFade(0.15f, 0.75f);
        alter.DOFade(0f, 0.75f);
        logo.DOFade(0f, 0.75f);
        mainMenu.SetActive(false);
        introMenu.SetActive(true);
        inCine = true;
    }

    public void OpenGame()
    {
        musicAudio.DOFade(0f, 0.15f);
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenSettings()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void CloseSettings()
    {
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }
}
