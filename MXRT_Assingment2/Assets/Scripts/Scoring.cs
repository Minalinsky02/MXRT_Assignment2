using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scoring : MonoBehaviour
{
    //we declare the int value of the score that would be called and used in the game screen for the score
    public static int scoreValue = 0;

    //This would declare the component that would use and display the score
    Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    //this would update the score text in the canvas with the name and the new int value that gets updated from the enemyPopUpCorrect() method
    void Update()
    {
        scoreText.text = "Score: " + scoreValue;
    }
}
