using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditMenu : MonoBehaviour
{
    public void PlayAgain()
    {
        GameManager.gameManagerInstance.PlayGame();
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
}
