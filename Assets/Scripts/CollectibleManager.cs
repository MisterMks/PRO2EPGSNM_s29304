using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    public GameObject originalPrefab;
    public float fromX;
    public float toX;
    public float fromZ;
    public float toZ;

    public int collectiblesCount = 10;

    // Start is called before the first frame update
    public void Awake()
    {
        for (int i = 0; i < collectiblesCount; i++)
        {
            Instantiate(
                originalPrefab,
                new Vector3(Random.Range(fromX, toX), 0, Random.Range(fromZ, toZ)),
                Quaternion.identity,
                transform
                );
        }
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(
            new Vector3(fromX, 0,fromZ),
            new Vector3(fromX,0,toZ)
            );
        Gizmos.DrawLine(
            new Vector3(fromX, 0, fromZ),
            new Vector3(toX, 0, fromZ)
            );
    }

}
