using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{
	public GameObject enemy;
	public GameObject spawnPoint;

	public int xPos;
	public int yPos;

	public int enemyCount = 3;

	
   
   void Update() 
   {

      GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
      enemyCount  = enemies.Length;

      if(enemies.Length <= 3) {

         xPos = Random.Range(1,50);
         yPos = Random.Range(1, 10);

         Instantiate(enemy, new Vector3(spawnPoint.transform.position.x + xPos, 43, spawnPoint.transform.position.z + yPos), Quaternion.identity);
      }
 

   }


    
}