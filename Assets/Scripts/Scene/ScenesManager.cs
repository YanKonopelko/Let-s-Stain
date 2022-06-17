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
            GameObject.Find("EndAnimationStarter").GetComponent<EndAnimationStarter>().Folow(GameObject.Find("Brusher").transform.GetChild(0).position);
            GameObject.Find("EndAnimationStarter").GetComponent<Animation>().Play("EndAnimation");
            GameObject.Find("Brusher").GetComponent<BrusherEndAnim>().EndAnim();  
            StartCoroutine("FinishScene");
        }
    }

    IEnumerator FinishScene()
    {
        yield return new WaitForSeconds(2);
        if(SceneManager.GetActiveScene().buildIndex < SceneManager.sceneCount-1)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
