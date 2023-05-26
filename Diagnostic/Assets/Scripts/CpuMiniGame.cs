using UnityEngine;
using Random = UnityEngine.Random;

public class CpuMiniGame : MonoBehaviour
{
    private const int NumberOfObjects = 10; // Le nombre d'objets à instancier

    private Vector3 _spawnAreaSize; // La taille de la zone de spawn
    
    public GameObject objectPrefab; // Le prefab du GameObject à instancier
    private GameObject _spawnAreaCenter; // Le centre de la zone de spawn
    private GameObject _deactivate; // Le GameObject à désactiver

    private void Start()
    {
        _spawnAreaSize = new Vector3(1800f, 1800f, 0f);
        _spawnAreaCenter = GameObject.Find("CPU");
        _deactivate = GameObject.Find("Panel");

        
        Debug.Log("CpuMiniGame.Start() " + objectPrefab);
        Debug.Log("CpuMiniGame.Start() " + _spawnAreaCenter);
        Debug.Log("CpuMiniGame.Start() " + _deactivate);
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
            var position = _spawnAreaCenter.transform.position;
            var localScale = _spawnAreaCenter.transform.localScale;
            var randomPosition = new Vector3(
                Random.Range(position.x - _spawnAreaSize.x / 2, localScale.x + _spawnAreaSize.x / 2),
                Random.Range(position.y - _spawnAreaSize.y / 2, localScale.y + _spawnAreaSize.y / 2),
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
        _deactivate.SetActive(false);
        InstantiateDust();
    }
}