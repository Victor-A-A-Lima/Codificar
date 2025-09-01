using UnityEngine;
using UnityEngine.SceneManagement;

public class ExecutarBotao : MonoBehaviour
{
    public void IrPara(string Title)
    {
        SceneManager.LoadScene(Title);
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
