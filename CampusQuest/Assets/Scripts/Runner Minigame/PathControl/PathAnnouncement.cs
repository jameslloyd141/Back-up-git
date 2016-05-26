using UnityEngine;
using System.Collections;

public class PathAnnouncement : MonoBehaviour
{
    void Awake()
    {
        //the Int pathCount increments by 1
        PathControl.control.pathCount += 1;
        //The current GameObject is added to the pathTransforms List
        PathControl.control.pathTransforms.Add(gameObject.transform);
    }
}