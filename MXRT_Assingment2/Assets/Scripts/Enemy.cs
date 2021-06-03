using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Enemy : MonoBehaviour
{

    //I declared these valuables for gameobjects to set in the inspector for the UI to spawn in and the enemy gameobject
    public GameObject enemyUI;
    public GameObject enemyUICorrect;
    public GameObject enemyUIWrong;
    public GameObject enemy;

    //these are all static conditions set to false such that they don't appear in the game canvas menu unless the method is called and they are set true
    public static bool enemyUIPop = false;
    public static bool enemyUICorrectPop = false;
    public static bool enemyUIWrongPop = false;
    public static bool pausedGame = true;
    //this was made to see the arCamera in action in the inspector while testing the game out
    [SerializeField]
    private Camera arCamera;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.name = "Enemy";        
    }

    // Update is called once per frame
    void Update()
    {        
        enemyPopUp();        
    }

    public void enemyPopUp()
    {

        if (Input.touchCount == 0)
            return;

        //this would show the UI screen to pop up at where the ar camera is pointing towards
        transform.LookAt(Camera.main.transform);

        //For every input on the screen onto the enemy, the enemyUI question screen would pop up for the player to interact with
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && PauseManager.gameIsPaused == false)
        {           
            enemyUI.SetActive(true);           
            enemyUIPop = true;
            Debug.Log("Question Popped up");
        }
    }

    public void enemyPopUpCorrect()
    {        
        //Should the correct answer get selected , the  correct screen UI canvas would show up on the app screen 
        enemyUICorrect.SetActive(true); enemyUICorrectPop = true;

        //This is in an event where the correct answer is selected after the wrong answer is selected first, it would set the wrong screen ui to false
        enemyUIWrong.SetActive(false); enemyUIWrongPop = false;

        //The enemy question UI pop up screen would be set false and not appear in the game menu screen
        enemyUI.SetActive(false); enemyUIPop = false;

        //In conjunction with the Scoring script, should this method be called up anytime, the score value float would increase by 10.
        Scoring.scoreValue += 10;
    }

    
    public void enemyPopUpWrong()
    {       
        //the ui screen canvas would be set true, so it would pop up in the game menu screen should the wrong answer be selected
        enemyUIWrong.SetActive(true);       
        enemyUIWrongPop = true;
    }



}
