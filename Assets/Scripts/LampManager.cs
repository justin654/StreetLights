using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampManager : MonoBehaviour
{
    [SerializeField] string typeName = "Lamp";
    private GameObject[] gameObjects;
    private int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameObjects = GameObject.FindGameObjectsWithTag(typeName);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject go in gameObjects)
        {
            Debug.Log(gameObjects);
        }
    }

    public void ToggleClick()
    {
        Light lightComponent = gameObjects[currentIndex].GetComponentInChildren<Light>();
        if (lightComponent != null)
        {
            lightComponent.enabled = !lightComponent.enabled;

            if (currentIndex == gameObjects.Length - 1)
                currentIndex = 0;
            else
                currentIndex++;
        }
    }


}