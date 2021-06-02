using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


public class Spawner : MonoBehaviour
{
    public ARPlaneManager m_ARPlanemanager;
    public ARRaycastManager m_ARRaycastManager;

    //I declare this variable such that the object would be instantiated 
    public GameObject m_spawnableObjectPrefab;

    //these 2 int values are declared in relation to the enemy spawning in the game scene and how many can spawn which would be used and referenced in the method later
    private int enemySpawn = 0;
    private int enemySpawnLimit = 2;

    //Pose m_placementPose;

    GameObject m_spawnedObject = null;

    // Start is called before the first frame update
    void Start()
    {
        m_spawnedObject = null;
        m_ARPlanemanager.planesChanged += M_ARPlanemanager_planesChanged;
    }

    private void M_ARPlanemanager_planesChanged(ARPlanesChangedEventArgs obj) // this method would call for an automatic spawning of the designated game object prefab
    {
        foreach (var plane in obj.added) // whenever there is a plane detected in the game view it would try and instantiate a game object 
        {
            if (enemySpawn != enemySpawnLimit) // if the enemySpawn does not equal to enemySpawnLimit , the game object would instantiate at the plane center as many times until the limit is reached
            {
                Instantiate(m_spawnableObjectPrefab, plane.center, Quaternion.identity);               
                enemySpawn++; //with every game object that spawns, the enemySpawn int would increase until it equals to teh enemySpawnLimit int and the game object prefab would stop
            }                       
        }
    }



    // Update is called once per frame
    //I'm going to keep this method of code as I want to configure or experiment with this code and ar input in the future after this assignment has been submitted
    void Update()
    {
        //if (Input.touchCount == 0)
        //    return;

        //var touchPt = Input.GetTouch(0).position;

        //List<ARRaycastHit> hits = new List<ARRaycastHit>();
        //m_ARRaycastManager.Raycast(touchPt, hits);
        //if (hits.Count == 0)
        //    return;

        //m_placementPose = hits[0].pose;
        //if (Input.GetTouch(0).phase == TouchPhase.Began)
        //{
        //    Spawn(m_placementPose.position);
        //}
        //else if (Input.GetTouch(0).phase == TouchPhase.Moved && m_spawnedObject != null)
        //{
        //    // move the object.
        //    m_spawnedObject.transform.position = m_placementPose.position;
        //}
        //if (Input.GetTouch(0).phase == TouchPhase.Ended)
        //{
        //    m_spawnedObject = null;
        //}

    }
    //void Spawn(Vector3 position)
    //{
    //    m_spawnedObject = Instantiate(m_spawnableObjectPrefab,
    //        position,
    //        Quaternion.identity);
    //}

}
