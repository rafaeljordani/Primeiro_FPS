using UnityEngine;

public class MainPoints : MonoBehaviour
{
    public int points = 0;

    public void AddPoints()
    {
       points += 10;
        Debug.Log("Points added. Current points: " + points);
    }

}
