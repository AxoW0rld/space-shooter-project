using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyShot : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject missile;

    public float shotTime;
    private float startTime;
    private float elapsedTime;

    private GameController gameScript;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time - startTime; // on note le startTime
        Instantiate(missile, spawnPoint.transform.position, missile.transform.rotation);
        gameScript = GameObject.Find("GameHolder").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameScript.isInGame)
        {
            //le temps ecoule = temps actuel - strt time
            elapsedTime = Time.time - startTime;

            if (elapsedTime >= shotTime)
            {
                startTime = Time.time;
                Instantiate(missile, spawnPoint.transform.position, spawnPoint.transform.rotation);
            }
        }
    }
}
