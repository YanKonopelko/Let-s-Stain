using UnityEngine;

public class CapsuleEnabler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Capsule"))
        {
            other.GetComponent<CapsuleClass>().enabled = true;
            other.GetComponent<Animation>().enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Capsule"))
        {
            other.GetComponent<CapsuleClass>().enabled = false;
            other.GetComponent<Animation>().enabled = false;
        }
    }
}
