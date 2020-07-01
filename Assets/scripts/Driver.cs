using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    const float MoveUnitsPerSecond = 5;
    
    // Update is called once per frame
    void Update()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if (horizontalInput != 0) 
        {
            Vector3 position = transform.position;
            position.x += horizontalInput * MoveUnitsPerSecond * Time.deltaTime;
            transform.position = position;
        }
        if (verticalInput != 0)
        {
            Vector3 position = transform.position;
            position.y += verticalInput * MoveUnitsPerSecond * Time.deltaTime;
            transform.position = position;
        }
    }
}
