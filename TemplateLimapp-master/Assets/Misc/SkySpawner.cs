using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkySpawner : MonoBehaviour
{

    public float currentExposure;

    public Material skybox;

    public float rotateSpeed;

   
    void Update()
    {
        skybox.SetFloat("_Exposure", currentExposure);

        skybox.SetFloat("_Rotation", Time.time*rotateSpeed);
      
    }
}
