using System.Collections.Generic;
using UnityEngine;

public class DetectionErreurs : MonoBehaviour
{
    private GameObject _popUpFelicitation;
    private GameObject _composant;
    private List<GameObject> _listComposant;
    private bool _passage = true;
    private string _objet;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Loupe") || !_passage) return;
        _passage = false;
        FinNiveau.Accompli++;

        Debug.Log("Erreur trouvées : " + FinNiveau.Accompli);
        Debug.Log("Composant : " + name);
        Debug.Log("Fin du niveau");
    }
}