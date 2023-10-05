using UnityEngine;

public class LightControl : MonoBehaviour
{
    [SerializeField] private bool initalLightSetting = false;

    private Light[] allLights;  // Array to store all lights
    private Renderer lampRenderer;  // Reference to the Renderer component

    void Start()
    {
        allLights = GetComponentsInChildren<Light>();  // Fetch all lights on this GameObject and its children
        lampRenderer = GetComponent<Renderer>();

        SetLight(initalLightSetting);
    }

    public bool AreAnyLightsOn()
    {
        foreach (Light light in allLights)
        {
            if (light.enabled) return true; // Return true if any light is on
        }
        return false; // Return false if none are on
    }

    public void SetLight(bool lightvalue)
    {
        // Toggle all lights in the array
        foreach (Light light in allLights)
        {
            light.enabled = lightvalue;
        }

        // Toggle emission based on the light value
        if (lampRenderer && lampRenderer.material.HasProperty("_EmissionColor"))
        {
            Color emissionColor = lightvalue ? Color.white : Color.black;
            lampRenderer.material.SetColor("_EmissionColor", emissionColor);
        }
    }

    public void ToggleLight()
    {
        // Instead of checking just one light, we'll check if any of the lights are on as it kept grabbing only 1 light
        bool anyLightsOn = AreAnyLightsOn();

        SetLight(!anyLightsOn);
    }
}
