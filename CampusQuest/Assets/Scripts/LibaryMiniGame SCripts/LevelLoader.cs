using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour {

    public string level;

    // Use this for initialization

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("wseadfsdfdsgffdshgdsfgsdf");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collision");
            Application.LoadLevel(level);
        }
    }
}
