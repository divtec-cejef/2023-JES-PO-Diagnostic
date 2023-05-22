using UnityEngine;

public class CpuMiniGame : MonoBehaviour
{
    public GameObject objectPrefab; // Le prefab du GameObject à instancier
    public const int NumberOfObjects = 10; // Le nombre d'objets à faire apparaître
    public GameObject spawnAreaCenter; // Le centre de la zone de spawn
    public Vector3 spawnAreaSize; // La taille de la zone de spawn
    public GameObject aActiver;
    public GameObject aDesactiver;

    private void LauchDust()
    {
        // Boucle pour instancier les objets
        for (int i = 0; i < NumberOfObjects; i++)
        {
            // Calculez une position aléatoire dans la zone de spawn
            var position = spawnAreaCenter.transform.position;
            var localScale = spawnAreaCenter.transform.localScale;
            Vector3 randomPosition = new Vector3(
                Random.Range(position.x - spawnAreaSize.x / 2, localScale.x + spawnAreaSize.x / 2),
                Random.Range(position.y - spawnAreaSize.y / 2, localScale.y + spawnAreaSize.y / 2),
                Random.Range(position.z - spawnAreaSize.z / 2, localScale.z + spawnAreaSize.z / 2)
            );

            // Instanciez le GameObject à la position aléatoire avec une rotation par défaut
            Instantiate(objectPrefab, randomPosition, Quaternion.identity);
        }
    }
    
    public void OnClick()
    {
        aActiver.SetActive(true);
        aDesactiver.SetActive(false);
        LauchDust();
    }
}