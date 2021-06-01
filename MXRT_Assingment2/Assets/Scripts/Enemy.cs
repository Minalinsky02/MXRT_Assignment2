using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Enemy : MonoBehaviour
{
    public GameObject enemyUI;
    public GameObject enemyUICorrect;
    public GameObject enemyUIWrong;
    public GameObject enemy;
    [SerializeField]
    public float timeCount = 0f;
    public static bool enemyUIPop = false;
    public static bool enemyUICorrectPop = false;
    public static bool enemyUIWrongPop = false;

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


        transform.LookAt(Camera.main.transform);

        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {           
            enemyUI.SetActive(true);           
            enemyUIPop = true;
            Debug.Log("Question Popped up");
        }
    }

    public void enemyPopUpCorrect()
    {        
        enemyUICorrect.SetActive(true); enemyUICorrectPop = true;

        enemyUIWrong.SetActive(false); enemyUIWrongPop = false;

        enemyUI.SetActive(false); enemyUIPop = false;

        Scoring.scoreValue += 10;
    }

    
    public void enemyPopUpWrong()
    {
        //Instantiate(enemyUIWrong, enemy.transform.position, Quaternion.identity);
        enemyUIWrong.SetActive(true);       
        enemyUIWrongPop = true;
    }



}
