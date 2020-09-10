using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSelfDestroy : MonoBehaviour
{

    public float TimeToLive;

    public GameObject effect;
   
    

    void Start()
    {
        Destroy(gameObject, TimeToLive);
        
    }



    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Vector3 pos = (contact.point);
        Quaternion rot = Quaternion.Euler(90, 0, 0);
        Instantiate(effect, pos,rot);
    }

}
