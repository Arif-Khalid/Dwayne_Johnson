using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Canvas mainMenu;
    [SerializeField] Canvas optionsMenu;
    [SerializeField] Slider soundSlider;

    public void PlayGame()
    {
        GameManager.gameManagerInstance.PlayGame();
    }

    public void QuitGame()
    {
        GameManager.gameManagerInstance.QuitGame();
    }

    public void EnableOptionsMenu()
    {
        mainMenu.enabled = false;
        optionsMenu.enabled = true;
    }

    public void DisableOptionsMenu()
    {
        optionsMenu.enabled = false;
        mainMenu.enabled = true;
    }

    public void ChangeVolume()
    {
        AudioListener.volume = soundSlider.value;
    }

}
