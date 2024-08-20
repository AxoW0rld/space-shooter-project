using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    Infosplayer infos;
    // Start is called before the first frame update
    void Start()
    {
        infos = GetComponent<Infosplayer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        Debug.Log("player entre en collision avec " + other.gameObject.name);

        if (other.gameObject.tag == "EnnemyMissile")
        {
            Debug.Log("****************** player entre en collision un missile");

            other.gameObject.SetActive(false);
            infos.updateLife(-1);
        }
    }
        
        void OnTriggerEnter2D (Collider2D other) {

            Debug.Log("player entre en collision avec " + other.gameObject.name);

            if (other.gameObject.tag == "HeartBonus")
            {
                Debug.Log("****************** player entre en collision un heart");

                Destroy(other.gameObject);
                infos.updateLife(1);
            }
        }
}
