using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this would make the gameobject the script is attached to to look at the player regardless of position
        transform.LookAt(Camera.main.transform.position);
    }
}
