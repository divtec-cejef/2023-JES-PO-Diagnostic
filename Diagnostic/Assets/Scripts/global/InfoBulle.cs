using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class InfoBulle : MonoBehaviour
{
    string _originalText;
    public List<GameObject> textes;
    static int _nbrTextes;
    private int _indexTextes = 0;
    Text _uiText;
    public float delay = 0.25f;
    public GameObject explication;
    public GameObject selectionPC;
    public GameObject tobito;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("---InfoBulle---");

        anim = tobito.GetComponent<Animator>();

        _uiText = GetComponent<Text>();
        _originalText = _uiText.text;
        _uiText.text = null;
        _nbrTextes = textes.Count;
        
        StartCoroutine(ShowLetterByLetter());
    }

    /**
     * affiche le texte lettre par lettre
     */
    IEnumerator ShowLetterByLetter()
    {
        anim.SetTrigger("Active");
        for (int i = 0; i <= _originalText.Length; i++)
        {
            _uiText.text = _originalText.Substring(0, i);
            yield return new WaitForSeconds(delay);
        }
        anim.SetTrigger("UnActive");
    }

    /**
     * Lors du clic sur le bouton suivant, on désactive le texte actuel et on active le suivant
     */
    public void TextSuivant()
    {
        Debug.Log("TextSuivant");
        Debug.Log("indexTextes = " + _indexTextes);
        Debug.Log("nbrTextes = " + _nbrTextes);
        if (_indexTextes < _nbrTextes - 1)
        {
            // désactive le texte actuel et active le suivant
            textes[_indexTextes].SetActive(false);
            _indexTextes++;
            textes[_indexTextes].SetActive(true);

            // Capture le texte puis l'affiche lettre par lettre grace à la coroutine 
            _uiText = GetComponent<Text>();
            _originalText = _uiText.text;
            _uiText.text = null;

            StartCoroutine(ShowLetterByLetter());
        }
        else // Si plus de texte on appelle la fonction FinExplication
        {
            Debug.Log("Fin des textes");
            FinExplication();
            return;
        }
    }

    /**
     * Désactive l'objet Explication
     */
    public void FinExplication()
    {
        Debug.Log("FinExplication");
        explication.SetActive(false);
        selectionPC.SetActive(true);
    }
}