using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LampManager : MonoBehaviour
{
    [SerializeField] public string typeName = "Lamp";
    [SerializeField] private TextMeshProUGUI LightOnCount;

    private GameObject[] gameObjects;
    public LightControl lightControl;

    private int currentIndex = 0;

    void Start()
    {
        gameObjects = GameObject.FindGameObjectsWithTag(typeName);
        LightOnCount = GameObject.Find("LightOnCount").GetComponent<TextMeshProUGUI>();
        UpdateUICount();
        if (gameObjects.Length == 0)
        {
            Debug.LogWarning("Nothing found with Lamp tag");
        }
    }

    public void ToggleLamps()
    {
        if (gameObjects.Length == 0)
        {
            Debug.LogWarning("No lamps to toggle");
            return;
        }

        if (currentIndex >= gameObjects.Length)
        {
            currentIndex = 0;
        }

        GameObject obj = gameObjects[currentIndex];
        LightControl lightControl = obj.GetComponent<LightControl>();
        if (lightControl != null)
        {
            Debug.Log("Toggling light for: " + obj.name);
            lightControl.ToggleLight();
            UpdateUICount();
        }

        currentIndex++;
    }

    private void UpdateUICount()
    {
        int count = 0;
        foreach (var obj in gameObjects)
        {
            LightControl lightControl = obj.GetComponent<LightControl>();
            if (lightControl != null && lightControl.IsLightOn())
            {
                count++;
            }
        }
        LightOnCount.text = "Lights On: " + count;
    }

}