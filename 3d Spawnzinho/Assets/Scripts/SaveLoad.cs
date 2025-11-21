using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public Transform objetoParaSalvar;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)) // Salvar
            SalvarPosicao();

        if (Input.GetKeyDown(KeyCode.L)) // Carregar
            CarregarPosicao();
    }

    void SalvarPosicao()
    {
        PlayerPrefs.SetFloat("X", objetoParaSalvar.position.x);
        PlayerPrefs.SetFloat("Y", objetoParaSalvar.position.y);
        PlayerPrefs.SetFloat("Z", objetoParaSalvar.position.z);
        PlayerPrefs.Save();

        Debug.Log("Posição salva!");
    }

    void CarregarPosicao()
    {
        if (!PlayerPrefs.HasKey("X")) return;

        float x = PlayerPrefs.GetFloat("X");
        float y = PlayerPrefs.GetFloat("Y");
        float z = PlayerPrefs.GetFloat("Z");

        objetoParaSalvar.position = new Vector3(x, y, z);
        Debug.Log("Posição carregada!");
    }
}