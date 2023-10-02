using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    [SerializeField] private bool initalLightSetting = false;
    public Light lampLight;
    // Start is called before the first frame update
    void Start()
    {
        lampLight = GetComponentInChildren<Light>();
        SetLight(initalLightSetting);
    }

    public void SetLight(bool lightvalue)
    {
        lampLight.enabled = lightvalue;
    }

    public void ToggleLight()
    {
        lampLight.enabled = !lampLight.enabled;
    }
}
