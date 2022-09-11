using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManagerInstance;

    
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
        DontDestroyOnLoad(this);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
