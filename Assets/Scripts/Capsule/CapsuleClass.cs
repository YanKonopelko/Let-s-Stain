using UnityEngine;

public class CapsuleClass : MonoBehaviour
{
    private bool isColored = false;
    private Animation anim;
    [SerializeField] private ParticleSystem _particle;
    private GameObject SceneManager;

    private void Start()
    {
       anim = transform.GetComponent<Animation>();
        SceneManager = Camera.main.gameObject;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Brusher"))
        {
            if (!isColored)
            {
                isColored = true;
                transform.GetComponent<MeshRenderer>().materials[0].color = Color.red;
                _particle.Play();
                SceneManager.GetComponent<ScenesManager>().Refresh();
            }
            anim.Play("CapsuleAnim");
        }
    }
}
