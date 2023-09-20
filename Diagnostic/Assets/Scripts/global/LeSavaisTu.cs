using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeSavaisTu : MonoBehaviour
{
    
    public GameObject bulle;
    
    void Start()
    {
        var helloWorld = bulle.GetComponent<TextMeshProUGUI>();
        switch (Button.TypeOfError)
        {
            case 1:
                helloWorld.text = "Le savais tu ? \n\n" + "Le processeur est le cerveau de l'ordinateur. C'est lui qui fait tous les calculs nécéssaire au bon fonctionnement du PC. Ces calculs fonctionnent en binaires, avec des 1 et des 0.";
                break;
            case 2:
                helloWorld.text = "Le savais tu ? \n\n" + "La carte graphique est le composant qui gère l'affichage de l'ordinateur. Elle fonctionne comme un second processeur pour afficher des images.";
                break;
            case 3:
                helloWorld.text = "Le savais tu ? \n\n" + "La mémoire vive (ou ram) est une unité de stockage temporaire qui stocke des données pour les utiliser plus rapidement. Les données stockées sont effacées quand le PC s'éteint.";
                break;
            case 4:
                helloWorld.text = "Le savais tu ? \n\n" + "L'alimentation est un élément essentiel qui permet de fournir de l'électricité à tous les composants de l'ordinateur. Elle est reliée à la carte mère et à tous les autres composants.";
                break;
        }
    }
}