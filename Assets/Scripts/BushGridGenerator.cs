using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushGridGenerator : MonoBehaviour
{
    public GameObject bushPrefab; // Prefab del arbusto
    public int rows = 5;
    public int cols = 5;
    public Vector3 startPosition = Vector3.zero;
    public float spacing = 2f; // Separación entre arbustos
    [Range(0f, 1f)]
    public float combatStartChance = 0.3f; // Probabilidad de añadir el componente de combate

    private void Start()
    {
        GenerateBushGrid();
    }

    void GenerateBushGrid()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Vector3 position = startPosition + new Vector3(col * spacing, 0, row * spacing);
                GameObject bush = Instantiate(bushPrefab, position, Quaternion.identity, transform);

                if (Random.value < combatStartChance)
                {
                    if (!bush.TryGetComponent<CombatStarter>(out _))
                    {
                        bush.AddComponent<CombatStarter>();
                    }
                }
            }
        }
    }
}
