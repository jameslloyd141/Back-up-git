using UnityEngine;
using System.Collections;

public class RandomSpawner : MonoBehaviour {

    public GameObject platform;

    //public float xMin, xMax;
    public float yDistance;
    public float xDistance;

    void Start()
    {
        Invoke ("platformSpawn", 0);
    }

    void platformSpawn()
    {
        //float x = Random.Range(xMin, xMax);
        float x = xDistance;
        float y = yDistance;

        Vector3 pos = new Vector3(transform.position.x, transform.position.y, 0);

        Instantiate(platform, pos, transform.rotation);
    }
}
