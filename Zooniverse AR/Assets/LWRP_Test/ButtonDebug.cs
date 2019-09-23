using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDebug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void PrintNow()
    {
        Debug.Log("test");
        Debug.LogWarning("testWarning");
        Debug.LogError("testError");
    }
}
