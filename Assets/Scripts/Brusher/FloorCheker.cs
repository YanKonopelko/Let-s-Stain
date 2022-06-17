using UnityEngine;

public class FloorCheker : MonoBehaviour
{

    public bool Check(Transform point)
    {
        RaycastHit hit;
        Vector3 down = point.TransformDirection(Vector3.down);
        Debug.DrawRay(point.position, down,new Color(1,1,1));
        if (Physics.Raycast(point.position, down, out hit, 5f))
            return true;
        else
            return false;
    }

    
}
