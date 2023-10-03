using UnityEngine;
using UnityEngine.SceneManagement;

public class Nettoyage : MonoBehaviour
{
    private static int _accompli;
    private SpriteRenderer _spriteRenderer;
    private Material _spriteMaterial;
    private Color _targetColor;
    private Color _originalColor;
    public static GameObject HandTutorial;
    private const int NbreAEffacé = 5;

    /**
     * Initialise les variables
     */
    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        // Récupère le matériau utilisé par le SpriteRenderer
        _spriteMaterial = _spriteRenderer.material;

        // Stocke la couleur d'origine du matériau
        _originalColor = _spriteMaterial.color;

        // Initialise la couleur cible à la couleur d'origine
        _targetColor = _originalColor;
    }

    /**
     * Lors du passage du doigt on efface augmente la transparance et fini par effacer le GameObject
     */
    private void OnMouseExit()
    {
        _targetColor.a -= 0.5f;
        _originalColor = _targetColor;

        // Si la transparence est assez basse, on détruit le GameObject
        if (_spriteMaterial.color.a < 0.6f)
        {
            Destroy(_spriteRenderer.gameObject);
            _accompli += 1;
            
            // Si le nombre de poussière effacé est égal NbreAEffacé, on lance la scène de fin
            if (_accompli == NbreAEffacé)
            {
                _accompli = 0;
                
                CheckPC.CheckCPU = true;
                
                SceneManager.LoadScene("8-Tobias-fin");
            }
        }
        
        _spriteMaterial.color = _originalColor;
        if (HandTutorial.activeSelf == false) return;
        HandTutorial.SetActive(false);
    }
}