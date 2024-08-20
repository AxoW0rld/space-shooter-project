using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public float speed = 5f;
    public float maxPosX;
    public float minPosX;
    public float maxPosY;
    public float minPosY;
    Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetAxis("Horizontal")

           myTransform.Translate(new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"), 0)*Time.deltaTime*speed);
           myTransform.position = new Vector3(Mathf.Clamp (myTransform.position.x,minPosX,maxPosX), Mathf.Clamp(myTransform.position.y, minPosY, maxPosY), myTransform.position.z);
    }
}
