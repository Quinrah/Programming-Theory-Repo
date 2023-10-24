using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene(1);
    }
    public void ExitGame(){
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
    public void Lambo(){
        SceneManager.LoadScene(2);
    }
    public void Camaro(){
        SceneManager.LoadScene(3);
    }
    public void MainMenu(){
        SceneManager.LoadScene(0);
    }
  
}
