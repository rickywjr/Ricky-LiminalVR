using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterWish : MonoBehaviour
{
    public void ChangeWater(int val)
    {
        if (val == 0)
        {
            gameObject.GetComponent<Renderer>().sharedMaterial.SetColor("_horizonColor", Color.blue);
        }

        if (val == 1)
        {
            gameObject.GetComponent<Renderer>().sharedMaterial.SetColor("_horizonColor", Color.red);
        }

        if (val == 2)
        {
            gameObject.GetComponent<Renderer>().sharedMaterial.SetColor("_horizonColor", Color.green);
        }

        if (val == 3)
        {
            gameObject.GetComponent<Renderer>().sharedMaterial.SetColor("_horizonColor", Color.yellow);
        }

    }
}
