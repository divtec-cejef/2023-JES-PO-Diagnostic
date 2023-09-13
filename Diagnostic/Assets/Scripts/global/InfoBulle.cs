using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class InfoBulle : MonoBehaviour
{
    public GameObject exPrésentation;
    public GameObject exPrésentation2;
    public GameObject exCPU;
    public GameObject exGPU;
    public GameObject exRam;
    public GameObject exAlim;
    
    private string _originalText;
    public List<GameObject> textes;
    static int _nbrTextes;
    private int _indexTextes;
    private Text _uiText;
    public float delay = 0.05f;
    private Animator _animator;
    private static readonly int Active = Animator.StringToHash("Active");
    private static readonly int UnActive = Animator.StringToHash("UnActive");

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("---InfoBulle---");

        _animator = GameObject.Find("Tobi_top").GetComponent<Animator>();
        
        exPrésentation.SetActive(false);
        
        switch (Button.TypeOfError)
        {
            case 1:
                exCPU.SetActive(true);
                break;
            case 2:
                exGPU.SetActive(true);
                break;
            case 3:
                exRam.SetActive(true);
                break;
            case 4:
                exAlim.SetActive(true);
                break;
            default:
                exPrésentation.SetActive(true);
                break;
        }
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
            Debug.Log("TextSuivant");
            exPrésentation.SetActive(false);
            exPrésentation2.SetActive(true);
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
        switch (Button.TypeOfError)
        {
            case 1:
                Button.SceneID = 5;
                break;
            case 2:
                Button.SceneID = 6;
                break;
            case 3:
                Button.SceneID = 7;
                break;
            case 4:
                Button.SceneID = 4;
                break;
            default:
                Button.SceneID = 2;
                break;
        }
        SceneManager.LoadScene(Button.SceneID);
    }
}