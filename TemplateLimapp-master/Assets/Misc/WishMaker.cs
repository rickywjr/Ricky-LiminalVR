using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WishMaker : MonoBehaviour
{


    public void ChangeSky(int val)
    {
        if (val == 0)
        {
            RenderSettings.skybox.SetColor("_Tint", Color.blue);
        }

        if (val == 1)
        {
            RenderSettings.skybox.SetColor("_Tint", Color.red);
        }

        if (val == 2)
        {
            RenderSettings.skybox.SetColor("_Tint", Color.green);
        }

        if (val == 3)
        {
            RenderSettings.skybox.SetColor("_Tint", Color.yellow);
        }

    }

    
}
