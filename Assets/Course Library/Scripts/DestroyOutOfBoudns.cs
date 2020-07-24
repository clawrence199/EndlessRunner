using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoudns : MonoBehaviour
{
    private float topBound = 50.0f;
    private float lowerBound = -20.0f;

    // Update is called once per frame
    void Update()
    {
        //Destroy objects when they go off screen 
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
