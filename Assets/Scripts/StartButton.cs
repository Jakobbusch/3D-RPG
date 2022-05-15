using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{

    public Button m_YourFirstButton;
    void Update()
    {
      
            
        
    }

    private void Start()
    {
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
    }

    IEnumerator LoadYourAsyncScene()
    {
       

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Experiment");

       
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    
    void TaskOnClick()
    {
        StartCoroutine(LoadYourAsyncScene());
    }
}
