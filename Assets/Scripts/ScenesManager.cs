using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenesManager : MonoBehaviour
{
    public int _capsulesAmount = 256;
    public int _capsulesCounter = 0;

     public void Refresh() {
        _capsulesCounter += 1;
        if(_capsulesCounter == _capsulesAmount)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
