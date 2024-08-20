using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMove : MonoBehaviour
{
    public float speed = 5f;
    public float lifeTime;
    Transform myTransform;

    private GameController gameScript;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
        speed = Random.Range(speed - 1f, speed + 1);
        Destroy(gameObject, lifeTime);
        gameScript = GameObject.Find("GameHolder").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameScript.isInGame)
        {
           //if(Input.GetAxis("Horizontal")
            myTransform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }
}
