/*using UnityEngine;
using System.Collections;

public class PathTrigger : MonoBehaviour
{
    //Create a public GameObject called "StraightPath" - this will be set in the editor
    public GameObject straightPath;

    //When another GameObject collides with the Trigger
    void OnTriggerEnter(Collider other)
    {
        //If the Tag of the colliding object is "Player"...
        if (other.tag == "Player")
        {
            //Create another straight path in front of the current one
            Instantiate(straightPath, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
<<<<<<< HEAD
}
*/
=======
}
>>>>>>> origin/master
