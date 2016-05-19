using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PathControl : MonoBehaviour
{
    public static PathControl control;

    public Transform firstPath; 
    public GameObject straightPath;
    public List<Transform> pathTransforms;

    public int pathCount = 0;

    void Awake()
    {
        control = this;
    }

    void Start()
    {
        pathTransforms.Insert(pathCount, firstPath);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Instantiate(straightPath, new Vector3(0,0,40), Quaternion.identity);
        }
    }
}
