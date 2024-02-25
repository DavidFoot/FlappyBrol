using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField]
    GameObject PipePrefab;
    [SerializeField]
    float delai = 1f;
    [SerializeField]
    float delaiMisiles = 2f;
    [SerializeField]
    float rangeMissiles = 3f;
    [SerializeField]
    GameObject MissilesPrefab;

    void Start()
    {
        InvokeRepeating("SpawnPipe", 0f, delai);
        InvokeRepeating("SpawnMissiles", 0f, delaiMisiles);
        

    }
    void SpawnMissiles()
    {
        var missilesInstances = Instantiate(MissilesPrefab);
        missilesInstances.GetComponent<Rigidbody2D>().velocity = Vector2.left * Random.Range(5.0f,55.0f);
        missilesInstances.transform.position = new Vector3(missilesInstances.transform.position.x, missilesInstances.transform.position.y, transform.position.y * rangeMissiles * Random.value);
    }
   void SpawnPipe()
    {
        Animator[] capsAnimator;
        var instance = Instantiate(PipePrefab);
        capsAnimator = instance.GetComponentsInChildren<Animator>();
        foreach (Animator animator in capsAnimator)
        {
            animator.speed = Random.Range(5f, 10f);
        }
    }
    void Update()
    {
    }
    public void StopSpawn()
    {
        CancelInvoke();
    }

    
}
