using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CpuMiniGame : MonoBehaviour
{
    private const int NumberOfObjects = 5; // Le nombre d'objets à instancier

    private Vector3 _spawnAreaSize; // La taille de la zone de spawn

    public GameObject objectPrefab; // Le prefab du GameObject à instancier
    public GameObject spawnAreaCenter; // Le centre de la zone de spawn
    public GameObject cpu; // Le GameObject à activer
    public GameObject listePoussieres;
    public GameObject handTutorial;
    
    private readonly List<GameObject> _activateList = new List<GameObject>();


    private void Start()
    {
        _spawnAreaSize = new Vector3(3f, 3f);
        _activateList.Add(cpu);
        _activateList.Add(handTutorial);
        
        Nettoyage.handTutorial = handTutorial;
        
        foreach (var a in _activateList)
        {
            a.SetActive(true);
        }

        listePoussieres.SetActive(true);
        InstantiateDust();
    }

    /**
     * Instancie un nombre d'objets dans la zone de spawn
     */
    private void InstantiateDust()
    {
        // Boucle pour instancier les objets
        for (var i = 0; i < NumberOfObjects; i++)
        {
            // Calculez une position aléatoire dans la zone de spawn
            var position = spawnAreaCenter.transform.position;
            var randomPosition = new Vector3(
                Random.Range(position.x - _spawnAreaSize.x / 2, position.x + _spawnAreaSize.x / 2),
                Random.Range(position.y - _spawnAreaSize.y / 2, position.y + _spawnAreaSize.y / 2),
                Random.Range(0, 0)
            );
            Debug.Log("CpuMiniGame.InstantiateDust() randomPosition " + randomPosition);
            // Instanciez le GameObject à la position aléatoire avec une rotation par défaut
            Instantiate(objectPrefab, randomPosition, Quaternion.identity);
        }
    }
}