using System.Net.Mime;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Nettoyage : MonoBehaviour
{
    private static int _accompli;
    private SpriteRenderer _spriteRenderer;
    private Material _spriteMaterial;
    private Color _targetColor;
    private Color _originalColor;
    private GameObject _textPoussieresActive;
    private const int PoussieresRestantes = 10;

    private void Start()
    {
        _textPoussieresActive = GameObject.Find("listePoussieres");
        
        // Assurez-vous d'avoir une référence au SpriteRenderer
        _spriteRenderer = GetComponent<SpriteRenderer>();

        // Récupérez le matériau utilisé par le SpriteRenderer
        _spriteMaterial = _spriteRenderer.material;

        // Stockez la couleur d'origine du matériau
        _originalColor = _spriteMaterial.color;

        // Initialisez la couleur cible à la couleur d'origine
        _targetColor = _originalColor;

        _textPoussieresActive.GetComponent<Text>().text = "Poussières restantes : " + CpuMiniGame.NumberOfObjects;
    }

    private void OnMouseExit()
    {
        Debug.Log("Effacer");
        
        _targetColor.a -= 0.5f;
        _originalColor  = _targetColor;
        

        if (_spriteMaterial.color.a < 0.6f)
        {
            Destroy(_spriteRenderer.gameObject);
            _accompli += 1;
            _textPoussieresActive.GetComponent<Text>().text = "Poussières restantes : " + (PoussieresRestantes - _accompli);
            Debug.Log("poussiere nettoyée " + _accompli);
            
            if (_accompli == 10)
            {
                SceneManager.LoadScene(4);
            }
            
        }
        _spriteMaterial.color = _originalColor;
    }
}