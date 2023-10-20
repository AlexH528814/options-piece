using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject BigAstPrefab;
    [SerializeField] private GameObject MidAstPrefab;
    [SerializeField] private GameObject SmolAstPrefab;

    [SerializeField] private float BigAsteroidsInterval = 3;
    [SerializeField] private float MidAsteroidsInterval = 2;
    [SerializeField] private float SmolAsteroidsInterval = 1;
    int y;

    public Transform Enemies;
    void Start()
    {
        StartCoroutine(spawnBigAsts(BigAsteroidsInterval, BigAstPrefab));
        StartCoroutine(spawnMidAsts(MidAsteroidsInterval, MidAstPrefab));
        StartCoroutine(spawnSmolAsts(SmolAsteroidsInterval, SmolAstPrefab));
    }

    private void FixedUpdate()
    {
        BigAsteroidsInterval = BigAsteroidsInterval - 0.00001f;
        MidAsteroidsInterval = MidAsteroidsInterval - 0.00001f;
        SmolAsteroidsInterval = SmolAsteroidsInterval - 0.00001f;
    }

    private IEnumerator spawnBigAsts(float interval, GameObject enemy)
    {
        int rand = Random.Range(1, 3);
        if (rand == 1) { y = -25; }
        else if (rand == 2) { y = 25; }
        yield return new WaitForSeconds(interval);
        Instantiate(enemy, new Vector3(Random.Range(-45f, 45), y, 0), Quaternion.identity, Enemies);
        StartCoroutine(spawnBigAsts(interval, enemy));
    }
    private IEnumerator spawnMidAsts(float interval, GameObject enemy)
    {
        int rand = Random.Range(1, 3);
        if (rand == 1) { y = -25; }
        else if (rand == 2) { y = 25; }
        yield return new WaitForSeconds(interval);
        Instantiate(enemy, new Vector3(Random.Range(-45f, 45), y, 0), Quaternion.identity, Enemies);
        StartCoroutine(spawnMidAsts(interval, enemy));
    }
    private IEnumerator spawnSmolAsts(float interval, GameObject enemy)
    {
        int rand = Random.Range(1, 3);
        if (rand == 1) { y = -25; }
        else if (rand == 2) { y = 25; }
        yield return new WaitForSeconds(interval);
        Instantiate(enemy, new Vector3(Random.Range(-45f, 45), y, 0), Quaternion.identity, Enemies);
        StartCoroutine(spawnSmolAsts(interval, enemy));
    }
}