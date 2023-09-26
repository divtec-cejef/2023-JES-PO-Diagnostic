using TMPro;
using UnityEngine;

public class LeSavaisTu : MonoBehaviour
{
    
    public GameObject bulle;

    private void Start()
    {
        var helloWorld = bulle.GetComponent<TextMeshProUGUI>();
        helloWorld.text = Button.TypeOfError switch
        {
            "CPU" => "Le savais tu ? \n\n" +
                 "<b>Le processeur</b> est <b>le cerveau</b> de l'ordinateur. C'est lui qui fait tous <b>les calculs</b> nécéssaire au bon fonctionnement du PC. Ces calculs fonctionnent en <b>binaire</b>, avec <b>des 1 et des 0</b>.",
            "GPU" => "Le savais tu ? \n\n" +
                 "<b>La carte graphique</b> est le composant qui gère <b>l'affichage</b> de l'ordinateur. Elle fonctionne comme <b>un second processeur</b> pour afficher des images.",
            "RAM" => "Le savais tu ? \n\n" +
                 "<b>La mémoire vive</b> (ou ram) est <b>une unité de stockage temporaire</b> qui stocke des données pour les utiliser <b>plus rapidement</b>. Les données stockées sont <b>effacées</b> quand le PC s'éteint.",
            "ALIM" => "Le savais tu ? \n\n" +
                 "<b>L'alimentation</b> est un élément essentiel qui permet de fournir de <b>l'électricité</b> à tous les composants de l'ordinateur. Elle est reliée à <b>la carte mère</b> et à tous les autres composants.",
            _ => helloWorld.text
        };
    }
}