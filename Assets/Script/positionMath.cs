using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionMath : MonoBehaviour
{
    Vector3 positM;
    [SerializeField] GameObject player;
    [SerializeField]Vector3 gg;
    void Start()
    {
        player = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }


    private void OnTriggerExit2D(Collider2D collision)
    {

        positM = transform.position;
        positM.x += 60f;
        transform.position = positM;
    }
}
