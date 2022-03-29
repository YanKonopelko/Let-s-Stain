using UnityEngine;

public class CrossSpawnerActivator : MonoBehaviour
{ 
    void Start()
    {
        transform.GetChild(Random.Range(0, transform.childCount-1)).GetComponent<CrossSpawner>()._enabled = true;
    }

}
