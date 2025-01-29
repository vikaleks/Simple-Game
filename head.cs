using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class head : MonoBehaviour
{
    public Transform playerBody;
    float xRotation = 0f;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * 2f;
        float mouseY = Input.GetAxis("Mouse Y");        
        
        xRotation = xRotation - mouseY;

        xRotation = Math.Clamp(xRotation, -90f,90f);
        transform.localRotation = Quaternion.Euler(xRotation,0,0);
        playerBody.Rotate(0, mouseX, 0);        
    }
}
