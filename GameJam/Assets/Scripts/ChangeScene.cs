


using System.Collections;


using System.Collections.Generic;


using UnityEngine;


using TMPro;


using UnityEngine.SceneManagement;





public class ChangeScene : MonoBehaviour


{


    public void LoadNewScene(string 1)


    {


        SceneManager.LoadScene(1);


    }


    public void Exit()


    {


        Application.Quit();


    }


    private void Start()


    {


        Cursor.lockState = CursorLockMode.None;


    }





}