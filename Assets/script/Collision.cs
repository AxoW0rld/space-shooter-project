using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public int scoreDestruction = 10;
    public int playerLifeLost = 1;
    public GameObject bonus;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag ("Player");
    }

    void OnCollisionEnter2D(Collision2D other) {
        
        Debug.Log ("Ennemi entre en collision avec " +  other.gameObject.name);

        if (other.gameObject.tag == "Missile") {
            Debug.Log("****************** Ennemi entre en collision un missile");

            player.GetComponent<Infosplayer>().addScore(scoreDestruction);
            int indice = Random.Range(0, 5);
            if(indice == 0)
            {
                GameObject bonusGO = Instantiate(bonus, transform.position, transform.rotation) as GameObject;
            }

            Destroy (this.gameObject);//on detruit l'ennemi
            Destroy(other.gameObject);//on detruit le missile

      
        }
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("****************** Ennemi entre en collision le player");

            player.GetComponent<Infosplayer>().updateLife(-1 *playerLifeLost);
        }
    }
}
