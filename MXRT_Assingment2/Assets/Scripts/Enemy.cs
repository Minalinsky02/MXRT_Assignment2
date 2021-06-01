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
        //if (answer == correct)
        //{
        //    Invoke("enemyPopUpCorrect", 3f);
        //}
        

    }

    public void enemyPopUp()
    {

        if (Input.touchCount == 0)
            return;


        transform.LookAt(Camera.main.transform);

        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            //var ray = arCamera.ScreenPointToRay(Input.touches[0].position);
            //RaycastHit hit;

            //if (Physics.Raycast(ray, out hit) && hit.transform.name == "Enemy")
            //{
            //    if (hit.collider != null)
            //    {
            
            //    }
            //}
            //Instantiate(enemyUI, enemy.transform.position, Quaternion.identity);
            enemyUI.SetActive(true);
            Time.timeScale = 0f;
            enemyUIPop = true;
        }
    }

    public void enemyPopUpCorrect()
    {
        //Instantiate(enemyUICorrect, enemy.transform.position, Quaternion.identity);
        enemyUICorrect.SetActive(true);        
        enemyUICorrectPop = true;
        timeCount  = timeCount * Time.deltaTime;

        if (timeCount >= 3f)
        {
            enemyUICorrect.SetActive(false);          
            enemyUICorrectPop = false;
            Destroy(gameObject);
        }
    }

    public void enemyPopUpWrong()
    {
        Instantiate(enemyUIWrong, enemy.transform.position, Quaternion.identity);
        enemyUIWrong.SetActive(true);
        Time.timeScale = 0f;
        enemyUIWrongPop = true;
    }



}
