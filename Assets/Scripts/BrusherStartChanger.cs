using UnityEngine;
using System.Collections;
public class BrusherStartChanger : MonoBehaviour
{
    private float distance = 10;
    void Start()
    {
        StartCoroutine("GetDown");
        transform.GetComponent<SphereCollider>().center -= new Vector3(0, distance, 0);
    }

    IEnumerator GetDown()
    {
        yield return new WaitForSeconds(0.5f);
        transform.GetChild(0).GetComponent<SphereCollider>().center -= new Vector3(0, distance, 0);
        transform.GetChild(1).GetComponent<SphereCollider>().center -= new Vector3(0, distance, 0);
        transform.GetChild(6).GetComponent<BoxCollider>().center -= new Vector3(0, distance, 0);
    }
}
