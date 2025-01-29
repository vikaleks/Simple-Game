using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class player : MonoBehaviour
{   
    public Transform playerBody;
    public float speed = 20f;
    public CharacterController contr;
  
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        contr.Move(playerBody.forward * vertical * speed * Time.deltaTime);
        contr.Move(playerBody.right * speed * horizontal * Time.deltaTime);   

    }
}
