using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkyChange : MonoBehaviour
{

    public Material[] sky; 

    int randomInt;

    public Image blackfade;

    void Start()
    {
        blackfade.canvasRenderer.SetAlpha(0.0f);
    }


    public void Changesky()
    {
        fadein();
        randomInt = Random.Range(0, 3);
        RenderSettings.skybox = sky[randomInt];
        //fadeout();
    }

    void fadein()
    {
        blackfade.CrossFadeAlpha(1, 2, false);
    }

   // void fadeout()
    //{
    //    blackfade.CrossFadeAlpha(0, 2, false);
   // }

}
