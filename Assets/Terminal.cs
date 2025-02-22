using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Terminal : MonoBehaviour
{
    public Transform player;

    public bool first;

    public GameObject tablette;

    public float triggerDistance;

    public UnityEvent triggerEvent;


    private void Start()
    {
        if (first)
        {
            tablette.SetActive(true);

        }
        else
        {
            tablette.SetActive(false);

        }
    }

    void Update()
    {
        if(Vector3.Distance(transform.position, player.position) <= triggerDistance && Input.GetKeyDown(KeyCode.E))
        {
            triggerEvent.Invoke();
            StartCoroutine(tabletteAnim());
        }
    }

    IEnumerator tabletteAnim()
    {
        if (first)
        {
            tablette.SetActive(false);
            yield return null;
        }
        tablette.SetActive(true);
        yield return new WaitForSeconds(1f);
        tablette.SetActive(false);

    }
}
