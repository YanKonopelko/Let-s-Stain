using UnityEngine;
using UnityEngine.SceneManagement;


public class BrusherRotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 175;
    static public bool isSwitched = true;
    private GameObject _camera;
    static public float distance = 6.3f;
    public Transform[] _rotationObject;
    static public int poscounter = 0;
    [SerializeField]static public bool AnimationNow = false;
    private void Start()
    {
        AnimationNow = true;
        isSwitched = true;
        distance = 6.3f;
        _camera = Camera.main.gameObject;
        _camera.GetComponent<CameraController>().player = _rotationObject[0];

    }

    private void ChangeDirection()
    {
        isSwitched = !isSwitched;

        var pos = _rotationObject[0].localPosition;
        Vector3 newpos = new Vector3(0,0,0);
        newpos.x = (isSwitched ? -1 : 1) * distance + pos.x; 
        _rotationObject[0].localPosition = newpos;
        _rotationObject[1].localPosition = pos;
        
        if (!transform.GetComponent<FloorCheker>().Check(_rotationObject[0]))
        {
            BrusherRotation.AnimationNow = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void Update()
    {
        Vector3 down = _rotationObject[0].TransformDirection(Vector3.down);
        Debug.DrawRay(_rotationObject[0].position, down, new Color(1, 1, 1));
        if ((Input.GetKeyDown("k") || ( Input.touchCount!=0 && Input.GetTouch(0).phase == TouchPhase.Began)) && AnimationNow == false)
        {
            ChangeDirection();
        }
        transform.RotateAround(_rotationObject[0].position, Vector3.up * (isSwitched?1:-1), _rotationSpeed * Time.deltaTime);
    }
}
