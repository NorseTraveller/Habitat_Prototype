using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O2TankBegin : MonoBehaviour
{
    public GameObject Manager;

    public void OnCollisionEnter(Collision collision)
    {
        Manager.GetComponent<Indicator>().Begin();
    }
}
