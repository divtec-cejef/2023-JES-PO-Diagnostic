using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InfoBulle : MonoBehaviour
{
    private string _originalText;
    public List<GameObject> textes;
    static int _nbrTextes;
    private int _indexTextes = 0;
    private Text _uiText;
    public float delay = 0.25f;
    private Animator _animator;
    private static readonly int Active = Animator.StringToHash("Active");
    private static readonly int UnActive = Animator.StringToHash("UnActive");

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("---InfoBulle---");

        _animator = GameObject.Find("Tobi_top").GetComponent<Animator>();

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
        _animator.SetTrigger(Active);
        for (int i = 0; i <= _originalText.Length; i++)
        {
            _uiText.text = _originalText.Substring(0, i);
            yield return new WaitForSeconds(delay);
        }
        _animator.SetTrigger(UnActive);
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
        }
    }

    /**
     * Désactive l'objet Explication
     */
    private void FinExplication()
    {
        Debug.Log("FinExplication");
        SceneManager.LoadScene("2-Choix-niveau");
    }
}