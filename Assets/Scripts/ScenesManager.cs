using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class ScenesManager : MonoBehaviour
{
    public int _capsulesAmount = 256;
    public int _capsulesCounter = 0;

     public void Refresh() {
        _capsulesCounter += 1;
        if(_capsulesCounter == _capsulesAmount)
        {
            GameObject.Find("Brusher").GetComponent<Animation>().Play("EndBrusherAnim");
            StartCoroutine("FinishScene");
        }
    }

    IEnumerator FinishScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
