using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DetectionErreurs : MonoBehaviour
{
    public GameObject _proco;
    public GameObject _gpu;
    public GameObject _ram;
    public GameObject _alim;
    private bool _erreurTrouve;
    private string _objet = "Tu as trouvé l'érreur, si tu as un doute tu peux toujours regarder une fois de plus." + 
                            " Sinon tu peux choisir l'erreur";

    private void Update()
    {
        if (Input.GetMouseButtonUp(0) && _erreurTrouve || Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended && _erreurTrouve)
        {
            ErreurTrouve();
        }
    }
    
    // ReSharper disable Unity.PerformanceAnalysis
    private void ErreurTrouve()
    {
        Debug.Log("changement de texte");
        GameObject.Find("Explication").GetComponent<TextMeshProUGUI>().text = _objet;
        
        _proco.SetActive(true);
        _ram.SetActive(true);
        _gpu.SetActive(true);
        _alim.SetActive(true);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        _erreurTrouve = true;

        switch (tag)
        {
            case "ALIM":
                Button.SceneID = 4;
                break;
            case "CPU":
                Button.SceneID = 5;
                break;
            case "GPU":
                Button.SceneID = 6;
                break;
            case "RAM":
                Button.SceneID = 7;
                break;
        }
    }
}