using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bokoblin : MonoBehaviour
{
    public Transform player;
    bool playing;

    public float timeDelta;

    Vector3 velocity = Vector3.zero;


    private void Update()
    {
        if(Vector3.Distance(transform.position, player.position) < 50 && Vector3.Distance(transform.position, player.position) > 4)
        {
            transform.position = Vector3.SmoothDamp(transform.position, player.position,ref velocity,  timeDelta);
            transform.LookAt(player.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().Play();
    }
}
