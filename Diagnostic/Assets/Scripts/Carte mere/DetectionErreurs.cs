using UnityEngine;

public class DetectionErreurs : MonoBehaviour
{
    public GameObject alim;
    public GameObject cpu;
    public GameObject gpu;
    public GameObject ram;
    private bool _erreurTrouve;

    /**
     * Detecte si le joueur a trouvé l'erreur et affiche les composants
     */
    private void Update()
    {
        if (Input.GetMouseButtonUp(0) && _erreurTrouve || Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended && _erreurTrouve)
        {
            ErreurTrouve();
        }
    }
    
    // ReSharper disable Unity.PerformanceAnalysis
    /**
     * Affiche les boutons de choix de l'erreur
     */
    private void ErreurTrouve()
    {
        cpu.SetActive(true);
        ram.SetActive(true);
        gpu.SetActive(true);
        alim.SetActive(true);
    }

    /**
     * Lors de la collision de l'erreur avec la loupe, l'erreur est trouvée et la variable est mise à true
     */
    private void OnTriggerEnter2D(Collider2D other)
    {
        _erreurTrouve = true;
    }
}