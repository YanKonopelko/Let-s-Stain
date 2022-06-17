using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleParticle : MonoBehaviour
{
    [SerializeField] Color color;
    void Start()
    {
        GetComponent<ParticleSystem>().startColor = color;
    }
}
