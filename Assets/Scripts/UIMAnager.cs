using UnityEngine;
using UnityEngine.UI;
public class UIMAnager : MonoBehaviour
{
    private float fill = 0;
    private float _amountOfCapsules;
    [SerializeField] private Image ProgressBar;
    private void Start()
    {
        _amountOfCapsules = GetComponent<ScenesManager>()._capsulesAmount;
    }

    private void Update()
    {
        if (GetComponent<ScenesManager>()._capsulesCounter>0)
        {
            fill = GetComponent<ScenesManager>()._capsulesCounter / _amountOfCapsules;
        }
        ProgressBar.fillAmount = fill;
    }
}
