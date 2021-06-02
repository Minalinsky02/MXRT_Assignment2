using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;


public class PauseManager : MonoBehaviour
{
    //these are declared to set the pause menu UI and set it to false so it doesn't appear in the game screen by default
    public GameObject pauseMenuUI;
    public static bool gameIsPaused = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {    
       
    }
    
    //Upon call of this method, the game world time would be unfrozen and the pause menu UI would be false not appear in the screen
    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        Debug.Log("Game will resume");
    }

    //When this method is called upon the player tapping on the home icon, the pause menu screen ui would show up as it has been set true and all the other things in the game screen would be frozen
    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        Debug.Log("Game is Paused");
    }
}
