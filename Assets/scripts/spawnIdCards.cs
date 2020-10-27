using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnIdCards : MonoBehaviour
{
    bool isGoblinAlive;
    public GameObject idCard;
    private float xpos;
    private float zpos;
    private int idCardCount = 0;
    bool createdIdCards = false;
    // Update is called once per frame

    void Update()
    {
        isGoblinAlive = GameObject.Find("Goblin").GetComponent<goblinHealth>().isAlive;
        if (isGoblinAlive == false && createdIdCards == false) 
        {
            Debug.Log("coroutine called");
            StartCoroutine(spawn());
            createdIdCards = true;
        }
    }

    IEnumerator spawn()
    {
        while (idCardCount < 2)
        {

            xpos = Random.Range(transform.position.x, transform.position.x+10);
            zpos = Random.Range(transform.position.z, transform.position.z + 10);
            Instantiate(idCard, new Vector3(xpos, 4f, zpos),idCard.transform.rotation);
            yield return new WaitForSeconds(0.1f);
            idCardCount += 1;
        }
        createdIdCards = true;
    }

}
