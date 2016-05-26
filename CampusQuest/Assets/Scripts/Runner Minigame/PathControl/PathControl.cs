using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PathControl : MonoBehaviour
{
    //Create a public static PathControl called "control"
    public static PathControl control;

    //Create a List of Transforms called "pathTransforms"
    public List<Transform> pathTransforms;

    //Create three public ints called "pathCount", "pathLimit", and "pathSpeed"
    public int pathCount;
    public int pathLimit;
    public int pathSpeed;

    public GameObject initialPath;

    void Awake()
    {
        //control equals this script - Allows other scripts to access variables in this script
        control = this;
    }

    void Start()
    {
        pathSpeed = 10;
        Instantiate(initialPath, new Vector3(0, 0, -10), Quaternion.identity);
    }

    void Update()
    {
        //If pathCount is greater than pathLimit...
        if (pathCount > pathLimit)
        {
            //Destroy the GameObject in the first element of the List
            Destroy(pathTransforms[0].gameObject);
            //Remove the first element of the list - Prevents any empty elements being left over
            pathTransforms.RemoveAt(0);
            //The value of pathCount decrements by one
            pathCount--;
        }
    }
}