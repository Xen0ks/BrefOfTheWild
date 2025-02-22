using UnityEngine;

public class Door : MonoBehaviour
{
    public void Open()
    {
        GetComponent<Animator>().SetTrigger("Open");
        Destroy(gameObject, 1f);
    }
}
