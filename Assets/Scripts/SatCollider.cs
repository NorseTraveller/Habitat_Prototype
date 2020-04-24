using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatCollider : MonoBehaviour
{
    //assigns the light to be chosen in editor
    public Light lightToSwitch = null;

    //on trigger enter the light is swithed from disabled to enabled and vice versa
    public void OnTriggerEnter(Collider other)
    {
        lightToSwitch.enabled = true;
    }


    public void OnTriggerExit(Collider other)
    {
        lightToSwitch.enabled = false;
    }
}
