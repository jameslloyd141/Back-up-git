using UnityEngine;
using System.Collections;

public class BarrierAnnouncment : MonoBehaviour
{
    void Awake()
    {
        BarrierSpawn.control.barrierCount++;
        BarrierSpawn.control.barrierList.Add(gameObject);
    }
}
