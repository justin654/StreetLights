using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampManager : MonoBehaviour
{
    [SerializeField] string typeName = "Lamp";
    private GameObject[] gameObjects;
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
}