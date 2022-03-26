using UnityEngine;

public class FloorCheker : MonoBehaviour
{

    public bool Check()
    {
        RaycastHit hit;
        var child = transform.GetChild(transform.GetComponent<BrusherRotation>().isSwitched == true ? 1 : 0 + 3);
        Vector3 down = child.TransformDirection(Vector3.down);
        if (Physics.Raycast(child.position, down, out hit, 2f))
            return true;
        else
            return false;
    }

    
}
