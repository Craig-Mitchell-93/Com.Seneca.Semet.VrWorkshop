using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kvmController : MonoBehaviour
{
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;

    private void Start()
    {
        //on start up makesure all lights are off
        //check for interaction from player
        //if kvm is pressed, increase current display
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null)
        {
            Debug.Log("no collisions");
            return;
        }


    }


}
