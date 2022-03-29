using UnityEngine;
using UnityEngine.UI;
public class UIMAnager : MonoBehaviour
{
    private float fill = 0;
    private float _amountOfCapsules;
    [SerializeField] private Image _progressBar;
    [SerializeField] private GameObject _startPanel;
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
        _progressBar.fillAmount = fill;
    }

    public void StartGame()
    {
        GameObject.Find("Brusher").GetComponent<BrusherStartChanger>().GetDown();
        Destroy(_startPanel);
    }
}
