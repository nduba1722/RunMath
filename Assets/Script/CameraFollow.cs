using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    public GameObject player;
    private float yMin , yMax ;
    private float xMin;
    public float xMax = 500;
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }

    
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
            float y = Mathf.Clamp(player.transform.position.y, yMin, yMax);
            gameObject.transform.position = new Vector3(x,y,gameObject.transform.position.z);
        }
    }
}
