using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;


public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public static bool gameIsPaused = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //if (Input.touchCount > 0) 
        //{
        //    Touch touch = Input.GetTouch(0);
        //    if (touch.phase == TouchPhase.Began)
        //    {
        //        PauseGame();
        //    }
        //    //else
        //    //{
        //    //    ResumeGame();
        //    //}
       

        //}
       
    }
    
    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        Debug.Log("Game will resume");
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        Debug.Log("Game is Paused");
    }
}
