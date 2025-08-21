using UnityEngine;

public class DestruicomoTempo : MonoBehaviour
{
    public float tempodeVida;

    void Start()
    {
        Destroy(this.gameObject, tempodeVida);
    }
}