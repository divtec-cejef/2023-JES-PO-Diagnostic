using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Nettoyage : MonoBehaviour
{
    private static int _accompli;
    private SpriteRenderer _spriteRenderer;
    private Material _spriteMaterial;
    private Color _targetColor;
    private Color _originalColor;
    private GameObject _textPoussieresActive;
    public static GameObject LeSavaisTu;
    public static GameObject handTutorial;
    public static GameObject Game;
    private const int PoussieresRestantes = 5;

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
    }

    private void OnMouseExit()
    {
        _targetColor.a -= 0.5f;
        _originalColor = _targetColor;


        if (_spriteMaterial.color.a < 0.6f)
        {
            Destroy(_spriteRenderer.gameObject);
            _accompli += 1;

            if (_accompli == 5)
            {
                _accompli = 0;
                Button.exitPressés = 0;
                SceneManager.LoadScene("8-Tobias-fin");
            }
        }

        _spriteMaterial.color = _originalColor;
        if (handTutorial.activeSelf == false) return;
        handTutorial.SetActive(false);
    }
}