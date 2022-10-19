using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    public float movementspeed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(horizontalInput * movementspeed * Time.deltaTime , 0 , verticalInput * movementspeed * Time.deltaTime);
        
    }
}
