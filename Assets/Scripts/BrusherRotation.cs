using UnityEngine;
using UnityEngine.SceneManagement;

public class BrusherRotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 175;
    public Transform _rotationObject ;
    public bool isSwitched = true;
    private GameObject _camera;
    private void Start()
    {
        _rotationObject = transform.GetChild(4).transform;
        _camera = Camera.main.gameObject;
        _camera.GetComponent<CameraController>().player = _rotationObject;
    }

    public void ChangeDirection()
    {
        isSwitched = !isSwitched;
        _rotationObject = transform.GetChild(isSwitched == true ? 1 : 0 + 3);
        _camera.GetComponent<CameraController>().player = _rotationObject;
        if (!transform.GetComponent<FloorCheker>().Check())
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void Update()
    {
        transform.RotateAround(_rotationObject.position, Vector3.up, _rotationSpeed * Time.deltaTime);
    }
}
