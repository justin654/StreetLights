using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampManager : MonoBehaviour
{
    [SerializeField] public string typeName = "Lamp";
    private GameObject[] gameObjects;
    public LightControl lightControl;
    private int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameObjects = GameObject.FindGameObjectsWithTag(typeName);
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
        }

        currentIndex++;
    }
}