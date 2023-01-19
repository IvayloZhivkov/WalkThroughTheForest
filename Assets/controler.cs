using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controler : MonoBehaviour
{
    

    public float speedh=2.0f;
    public float speedv = 2.0f;
    public KeyCode lookKey;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

   
    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey(lookKey))
        {
            yaw += speedh * Input.GetAxis("Mouse X");
            pitch -= speedv * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
         
    }
}
