using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField]private int secondsToWait = 3;
    [SerializeField]private int nextScene = 1;
    
    void Start()
    {
        StartCoroutine(WaitAndContinue());
    }

    IEnumerator WaitAndContinue(){
        yield return new WaitForSeconds(secondsToWait);
        SceneManager.LoadScene(nextScene);
    }
}
