using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //The gameplay scene would load into the area
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    //the game/application would stop functioning and the application would close
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting Game");
            
    }
}
