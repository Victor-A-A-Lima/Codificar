using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class PlayerLaser : MonoBehaviour
{
    public float velocidadeDolaser;

    public int DanoParaDar;

    void Update()
    {
        MovimentarOlaser();
    }
    private void MovimentarOlaser()
    {
        transform.Translate(Vector3.up * velocidadeDolaser * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.CompareTag("Inimigo"))
        {
            colisao.gameObject.GetComponent<Inimigos>().MachucarInimigo(DanoParaDar);
            Destroy(this.gameObject);
        }
    }

}

