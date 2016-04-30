using UnityEngine;
using System.Collections;

public class OnCockpitCollision : MonoBehaviour
{
    public GameObject exp; 

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("am i here?");
        if (other.gameObject.CompareTag("Asteroid"))
        {
            Destroy(other.gameObject);
            Instantiate(exp, other.gameObject.transform.position, other.gameObject.transform.rotation);
        }

    }
}
