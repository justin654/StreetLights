using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    [SerializeField] private bool initalLightSetting = false;
    // Start is called before the first frame update
    void Start()
    {
        SetLight(initalLightSetting);
    }

    public void SetLight(bool lightvalue)
    {
        this.GetComponent<Light>().enabled = initalLightSetting;
    }

}
