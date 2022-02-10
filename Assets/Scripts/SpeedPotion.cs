using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPotion : MonoBehaviour
{
    #region SpeedPotion_variables
    [SerializeField]
    [Tooltip("the amount the player speeds up")]
    private int speedAmount;
    [SerializeField]
    [Tooltip("the duration the effect is active for")]
    private int duration;
    #endregion

    #region Speed_functions
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.GetComponent<PlayerController>().Speed(speedAmount, duration);
            Destroy(this.gameObject);
        }
    }
    #endregion
}
