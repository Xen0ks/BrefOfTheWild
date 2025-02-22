using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrine : MonoBehaviour
{
    public Transform player;
    public Transform target;

    public void tp()
    {
        player.position = target.position;
    }
}
