
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float turnSpeed = 90f;


    public void Update(){
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }
}
