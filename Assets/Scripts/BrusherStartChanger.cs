using UnityEngine;
public class BrusherStartChanger : MonoBehaviour
{
    private float distance = 10;

    public void GetDown()
    {
        transform.GetComponent<Animation>().Play("StartBrusherAnim");
        transform.GetChild(0).GetComponent<SphereCollider>().center -= new Vector3(0, distance, 0);
        transform.GetChild(1).GetComponent<SphereCollider>().center -= new Vector3(0, distance, 0);
        transform.GetChild(6).GetComponent<BoxCollider>().center -= new Vector3(0, distance, 0);
    }
}
