using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator : MonoBehaviour
{
    public GameObject Stage1;
    public GameObject GasLeak;
    public GameObject Stage2;
    public GameObject Refill;
    public GameObject Light;

    
    // Call this function to begin the O2Tank interaction
    public void Begin()
    {
        Light.SetActive(false);
        Stage1.SetActive(true);
        GasLeak.SetActive(true);
        Stage2.SetActive(false);
        Refill.SetActive(true);
        // Confirm stage 1 has begun
        Debug.Log("Begin");
    }
    
    public void EndEmpty()
    {
        // Remove empty tank linear drive to avoid collider conflicts
        Stage1.SetActive(false);
        GasLeak.SetActive(false);
        // Confirm the function was called and completed
        Debug.Log("Halfway");
    }
    public void Finish()
    {
        Stage1.SetActive(false);
        GasLeak.SetActive(false);
        Stage2.SetActive(true);
        Refill.SetActive(false);
        Light.SetActive(true);
        Debug.Log("Finished");
    }
}
