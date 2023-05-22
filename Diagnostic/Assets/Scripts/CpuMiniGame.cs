using UnityEngine;
using Random = UnityEngine.Random;

public class CpuMiniGame : MonoBehaviour
{
    public const int NumberOfObjects = 10; // Le nombre d'objets à instancier

    public Vector3 spawnAreaSize; // La taille de la zone de spawn
    
    public GameObject objectPrefab; // Le prefab du GameObject à instancier
    public GameObject spawnAreaCenter; // Le centre de la zone de spawn
    public GameObject activate; // Le GameObject à activer
    public GameObject deactivate; // Le GameObject à désactiver

    /**
     * Instancie NumberOfObjects objets dans la zone de spawn
     */
    private void InstantiateDust()
    {
        // Boucle pour instancier les objets
        for (var i = 0; i < NumberOfObjects - 1; i++)
        {
            // Calculez une position aléatoire dans la zone de spawn
            var position = spawnAreaCenter.transform.position;
            var localScale = spawnAreaCenter.transform.localScale;
            var randomPosition = new Vector3(
                Random.Range(position.x - spawnAreaSize.x / 2, localScale.x + spawnAreaSize.x / 2),
                Random.Range(position.y - spawnAreaSize.y / 2, localScale.y + spawnAreaSize.y / 2),
                Random.Range(0, 0)
            );

            // Instanciez le GameObject à la position aléatoire avec une rotation par défaut
            Instantiate(objectPrefab, randomPosition, Quaternion.identity);
        }
    }
    
    /**
     * Active le GameObject aActiver et désactive le GameObject aDesactiver
     * Appelle LauchDust()
     */
    public void OnClick()
    {
        activate.SetActive(true);
        deactivate.SetActive(false);
        InstantiateDust();
    }
}