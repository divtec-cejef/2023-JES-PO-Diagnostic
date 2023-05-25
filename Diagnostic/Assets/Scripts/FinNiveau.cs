using UnityEngine;
using UnityEngine.SceneManagement;

public class FinNiveau : MonoBehaviour
{
    public static int Accompli = 0;

    private void Update()
    {
        if (Accompli != CpuMiniGame.NumberOfObjects) return;
        Debug.Log("Niveau terminé");
        SceneManager.LoadScene(2);
    }
}