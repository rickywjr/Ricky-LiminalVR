using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCollect : MonoBehaviour
{

    public int starscore;

    public int scoreToSpawnWater;

    public int scoreToSpawnSky;

    public int scoreToSpawnCloud;

    public Material skybox;

    //public bool black;

    public bool clear;

    public GameObject cloud;

    float exposure = 0;

    public float lerpSpeed;

    public float targetExposure;

    public GameObject waterBlocker;

    public GameObject textBox;

    bool waterOff=true;
    // Start is called before the first frame update
    void Start()
    {
        starscore = 0;
        skybox.SetFloat("_Exposure", exposure);
        //black = true;
        clear = true;
    }

    void Update()
    {
       
        if(starscore == scoreToSpawnWater && waterOff)
        {
            iTween.FadeTo(waterBlocker, 0, 2);
            Destroy(waterBlocker, 2);
            waterOff = false;
            Destroy(textBox);

        }



        if (starscore>=scoreToSpawnSky && exposure<targetExposure-0.01f )
        {
            skybox.SetFloat("_Exposure", exposure);
            exposure = Mathf.Lerp(exposure, targetExposure,lerpSpeed*Time.deltaTime);
          

            Debug.Log(exposure);
        } 

        if (starscore==scoreToSpawnCloud && clear)
        {
            Instantiate(cloud);
            clear = false;
        }


    }

   public void OnCollisionEnter(Collision collision)
    {
            starscore += 1;
            Destroy(collision.gameObject);
            Debug.Log(starscore);
    }

   
}
