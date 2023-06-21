using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    
    public Player movement;
    void OnCollisionEnter (Collision collisionInfo){
        if(collisionInfo.collider.tag == "Coin"){
            
            Debug.Log("Coin collected! Coin Count: ");
            Destroy(collisionInfo.gameObject);
        } 
        else if(collisionInfo.collider.tag == "Block"){
            Debug.Log("We hit a Block");
            movement.enabled = false;
            GameManager.Instance.EndGame();
        }

    }
}
