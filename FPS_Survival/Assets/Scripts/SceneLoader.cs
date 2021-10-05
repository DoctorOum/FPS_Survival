using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

        public void QuitGame()
     {
        Application.Quit();
        Debug.Log("Quit!");
     }

        public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
        public void CreditsMenu()
    {
        SceneManager.LoadScene("Credits Menu");
    }
        public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
        public void OptionsMenu()
    {
        SceneManager.LoadScene("Options Menu");
    }

}
