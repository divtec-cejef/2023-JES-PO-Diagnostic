using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectionFinNiveau : MonoBehaviour
{
    public static int ObjetsRetires = 0;

    /**
     * Si 5 objets sont retirés, on lance la coroutine qui va faire tourner le ventilateur
     */
    void Update()
    {
        if (ObjetsRetires == 5)
        {
            // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
            StartCoroutine(PauseCoroutine());
        }    
    }

    // ReSharper disable Unity.PerformanceAnalysis
    /**
     * Coroutine qui fait tourner le ventilateur
     */
    private IEnumerator PauseCoroutine()
    {
        ObjetsRetires = 0;
        
        Animator myAnim = GameObject.Find("Fan").GetComponent<Animator>();
        myAnim.Play("Fan_ok");
        
        yield return new WaitForSeconds(2);

        FinDEtape();
    }

    /**
     * On charge la scène de fin et le PC GPU est considéré fait
     */
    private static void FinDEtape()
    {
        CheckPC.CheckGPU = true;
        SceneManager.LoadScene("8-Tobias-fin");
    }
}
