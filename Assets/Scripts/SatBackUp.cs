using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatBackUp : MonoBehaviour
{
    public GameObject Light;
    public void Alligned()
    {
        Light.SetActive(true);
        Debug.Log("Satelite Interaction Finished");
    }
}
