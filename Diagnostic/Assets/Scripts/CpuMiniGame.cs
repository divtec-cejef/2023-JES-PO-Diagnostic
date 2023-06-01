using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class CpuMiniGame : MonoBehaviour
{
    public static int NumberOfObjects = 10; // Le nombre d'objets à instancier

    private Vector3 _spawnAreaSize; // La taille de la zone de spawn
    
    public GameObject objectPrefab; // Le prefab du GameObject à instancier
    public GameObject spawnAreaCenter; // Le centre de la zone de spawn
    private GameObject _deactivate; // Le GameObject à désactiver
    public GameObject activate; // Le GameObject à activer
    public GameObject listePoussieres;

    private void Start()
    {
        _spawnAreaSize = new Vector3(1600f, 1600f, 0f);
        
        _deactivate = GameObject.Find("Panel");
        
        Debug.Log("__________________________________");
        Debug.Log("__Début du jeu CPU__");
        Debug.Log("Zone de spawn " + spawnAreaCenter);
        Debug.Log("Desactive " + _deactivate);
        Debug.Log("Active " + activate);
        Debug.Log("Liste poussieres " + listePoussieres);
        Debug.Log("__________________________________");
    }
    
    /**
     * Instancie NumberOfObjects objets dans la zone de spawn
     */
    private void InstantiateDust()
    {
        // Boucle pour instancier les objets
        for (var i = 0; i < NumberOfObjects; i++)
        {
            // Calculez une position aléatoire dans la zone de spawn
            var position = spawnAreaCenter.transform.position;
            var localScale = spawnAreaCenter.transform.localScale;
            var randomPosition = new Vector3(
                Random.Range(position.x - _spawnAreaSize.x / 2, localScale.x + _spawnAreaSize.x / 2),
                Random.Range(position.y - _spawnAreaSize.y / 2, localScale.y + _spawnAreaSize.y / 2),
                Random.Range(0, 0)
            );

            // Instanciez le GameObject à la position aléatoire avec une rotation par défaut
            Instantiate(objectPrefab, randomPosition, Quaternion.identity);
            Debug.Log("CpuMiniGame.InstantiateDust() " + objectPrefab);
        }
    }
    
    /**
     * Active le GameObject aActiver et désactive le GameObject aDesactiver
     * Appelle LauchDust()
     */
    public void OnClick()
    {
        _deactivate.SetActive(false);
        activate.SetActive(true);
        listePoussieres.SetActive(true);
        InstantiateDust();
    }
}