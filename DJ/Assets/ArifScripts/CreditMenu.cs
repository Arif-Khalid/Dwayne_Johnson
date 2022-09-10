using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditMenu : MonoBehaviour
{
    public void PlayAgain()
    {
        GameManager.gameManagerInstance.PlayGame();
    }

    public void Quit()
    {
        GameManager.gameManagerInstance.QuitGame();
    }
}
