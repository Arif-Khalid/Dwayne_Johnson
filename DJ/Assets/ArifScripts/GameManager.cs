using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManagerInstance;

    [SerializeField] Canvas mainMenu;
    [SerializeField] Canvas optionsMenu;
    private void Start()
    {
        if (gameManagerInstance)
        {
            Destroy(this.gameObject);
        }
        else
        {
            gameManagerInstance = this;
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(0);
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

    public void QuitGame()
    {
        Application.Quit();
    }
}
