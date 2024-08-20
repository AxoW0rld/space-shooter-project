using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    public GameObject missile;
    public GameObject spawnPoint;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            //Debug.Log("on tire des missile");
            Instantiate(missile, spawnPoint.transform.position, Quaternion.identity);
        }  
    }
}
