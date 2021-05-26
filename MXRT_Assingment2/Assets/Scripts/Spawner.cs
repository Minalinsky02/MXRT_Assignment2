using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


public class Spawner : MonoBehaviour
{
    public ARPlaneManager m_ARPlanemanager;
    public ARRaycastManager m_ARRaycastManager;

    public GameObject m_spawnableObjectPrefab;
    private int enemySpawn = 0;
    private int enemySpawnLimit = 2;

    Pose m_placementPose;

    GameObject m_spawnedObject = null;

    // Start is called before the first frame update
    void Start()
    {
        m_spawnedObject = null;
        m_ARPlanemanager.planesChanged += M_ARPlanemanager_planesChanged;
    }

    private void M_ARPlanemanager_planesChanged(ARPlanesChangedEventArgs obj)
    {
        foreach (var plane in obj.added)
        {
            if (enemySpawn != enemySpawnLimit)
            {
                Instantiate(m_spawnableObjectPrefab, plane.center, Quaternion.identity);
                enemySpawn++;
            }                       
        }
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 0)
            return;

        var touchPt = Input.GetTouch(0).position;

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        m_ARRaycastManager.Raycast(touchPt, hits);
        if (hits.Count == 0)
            return;

        m_placementPose = hits[0].pose;
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Spawn(m_placementPose.position);
        }
        else if (Input.GetTouch(0).phase == TouchPhase.Moved && m_spawnedObject != null)
        {
            // move the object.
            m_spawnedObject.transform.position = m_placementPose.position;
        }
        if (Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            m_spawnedObject = null;
        }

    }
    void Spawn(Vector3 position)
    {
        m_spawnedObject = Instantiate(m_spawnableObjectPrefab,
            position,
            Quaternion.identity);
    }

}
