using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillTank : MonoBehaviour
{
    public GameObject Manager;

    public void OnCollisionEnter(Collision collision)
    {
        Manager.GetComponent<Indicator>().Finish();
    }
}
