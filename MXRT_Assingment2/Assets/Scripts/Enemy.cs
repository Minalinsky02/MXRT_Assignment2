using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public GameObject enemyUI;
    public GameObject enemyUICorrect;
    public GameObject enemyUIWrong;
    public static bool enemyUIPop = false;
    public static bool enemyUICorrectPop = false;
    public static bool enemyUIWrongPop = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.transform);
    }

    public void enemyPopUp()
    {
        enemyUI.SetActive(true);
        Time.timeScale = 0f;
        enemyUIPop = true;
        Debug.Log("You tapped on enemy");
    }

}
