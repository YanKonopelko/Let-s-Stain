using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class BrusherPowerUp : MonoBehaviour
{
    public int _pickedCrosses = 0;
    [SerializeField] private Image[] _crosses;
    public int _upVersion = 0;
    private float _buffDuration = 4.5f;
    public void PickUp()
    {
        var newColor = new Color(255f / 255f, 255f / 255f, 255f / 255f);
        _crosses[_pickedCrosses].color = newColor;
        _pickedCrosses += 1;
        if(_pickedCrosses == 3)
        {
            if (GetComponent<BrusherRotation>().isSwitched)
            {
                GetComponent<Animation>().Play("BrusherUp 1");
                _upVersion = 1;
            }
            else
            {
                GetComponent<Animation>().Play("BrusherUp");
            }
            Destroy(_crosses[0]);
            Destroy(_crosses[1]);
            Destroy(_crosses[2]);
            StartCoroutine("BrusherDown");
        }
    }
    IEnumerator BrusherDown()
    {
        yield return new WaitForSeconds(_buffDuration);
        if (_upVersion == 1 && GetComponent<BrusherRotation>().isSwitched == true) 
            GetComponent<Animation>().Play("BrusherDown 1");
        if (_upVersion == 1 && GetComponent<BrusherRotation>().isSwitched == false)
            GetComponent<Animation>().Play("BrusherDown 2");

        if (_upVersion == 0 && GetComponent<BrusherRotation>().isSwitched == true)
            GetComponent<Animation>().Play("BrusherDown 3");
        if (_upVersion == 0 && GetComponent<BrusherRotation>().isSwitched == false)
            GetComponent<Animation>().Play("BrusherDown");
    }
    public void TurnOnCrosses()
    {
        _crosses[0].gameObject.SetActive(true);
        _crosses[1].gameObject.SetActive(true);
        _crosses[2].gameObject.SetActive(true);
    }
}
