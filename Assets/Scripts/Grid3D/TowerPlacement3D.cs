using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TowerPlacement3D : MonoBehaviour
{
    [SerializeField] private Grid3DManager gridManager;
    [SerializeField] private Camera mainCam;
    [SerializeField] private GameObject towerPrefab;
    [SerializeField] private LayerMask groundLayer;

    private void Awake()
    {
        if(mainCam == null)
        {
            mainCam = Camera.main;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            TryPlaceTower();
        }
    }

    private void TryPlaceTower()
    {
        if(mainCam == null || gridManager == null|| towerPrefab == null)
        {
            return;
        }

        Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);

        if(!Physics.Raycast(ray, out RaycastHit hit, 1000f, groundLayer))
        {
            Debug.Log("Did not hit");
            return;
        }
        else
        {
            Debug.Log("Hit");
        }

        Vector3Int cell = gridManager.WorldToCell(hit.point);

        if (gridManager.IsOccupied(cell) || gridManager.IsBlocked(cell))
            return;

        if(gridManager.TryOccupyCell(cell))
        {
            Vector3 position = gridManager.GetCellCenter(cell);
            Instantiate(towerPrefab, position, Quaternion.identity);
        }    
    }
}
