using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeSavaisTu : MonoBehaviour
{
    
    public GameObject bulle;
    
    void Start()
    {
        var helloWorld = bulle.GetComponent<Text>();
        switch (Button.TypeOfError)
        {
            case 1:
                helloWorld.text = "Le savais tu ? /n/n" + "Le processeur est l'élément le plus important de ton ordinateur, il est le cerveau de ton ordinateur. Il est composé de plusieurs coeurs qui permettent de faire plusieurs tâches en même temps. Plus il y a de coeurs, plus il y a de tâches qui peuvent être effectuées en même temps.";
                break;
            case 2:
                helloWorld.text = "Le savais tu ? /n/n" + "La carte graphique est l'élément qui permet d'afficher les images sur ton écran. Elle est composée de plusieurs coeurs qui permettent de faire plusieurs tâches en même temps. Plus il y a de coeurs, plus il y a de tâches qui peuvent être effectuées en même temps.";
                break;
            case 3:
                helloWorld.text = "Le savais tu ? /n/n" + "La mémoire vive est l'élément qui permet de stocker les données en cours d'utilisation. Plus il y a de mémoire vive, plus il y a de données qui peuvent être stockées en même temps.";
                break;
            case 4:
                helloWorld.text = "Le savais tu ? /n/n" + "L'alimentation est l'élément qui permet de fournir de l'électricité à ton ordinateur. Plus il y a de watts, plus il y a d'électricité qui peut être fournie en même temps.";
                break;
        }
    }
}