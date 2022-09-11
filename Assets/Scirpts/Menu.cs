using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    

    public void PlayGame()
    {
        SceneManager.LoadScene("garage");
    }

    public void PickedCar()
    {
        SceneManager.LoadScene("game");
    }


    public void QuitGame ()
    {
        Application.Quit();
    }

    public void BackToMenu ()
    {
        SceneManager.LoadScene("menu");
    }
}
