using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string mainMenu, level1;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ResetScene()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }   
    public void Level1()
    {
        SceneManager.LoadScene(level1);
    }
    public void Quit()
    {
        Application.Quit();
    }

}
