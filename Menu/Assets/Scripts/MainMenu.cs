using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Variável pública que referencia o GameObject do menu de pausa.
    public GameObject pauseMenu;
    // Variável privada que controla se o menu de pausa está ativo ou não.
    private bool activeMenu;
    // Método chamado uma vez por frame, usado para verificar entradas do usuário.
    private void Update()
    {
        // Verifica se a tecla "Escape" foi pressionada.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Inverte o estado do menu (ativa ou desativa).
            activeMenu = !activeMenu;
            // Ativa ou desativa o GameObject do menu de pausa com base no estado de activeMenu.
            pauseMenu.SetActive(activeMenu);
        }
        
    }

    // Método público chamado para iniciar o jogo.
    public void StartGame()
    {
        // Carrega a cena com índice 1 (geralmente a primeira cena do jogo).
        SceneManager.LoadScene(1);
        // Exibe uma mensagem no console para indicar que o botão foi pressionado.
        Debug.Log("Botão ativado");
    }

    // Método público para fechar um menu de opções.
    public void ExitOptionMenu(GameObject go)
    {
        // Desativa o GameObject passado como parâmetro, ocultando o menu de opções.
        go.SetActive(false);
    }


    // Método público para abrir um menu de opções.
    public void ActiveOptionMenu(GameObject go)
    {
        // Ativa o GameObject passado como parâmetro, exibindo o menu de opções.
        go.SetActive(true);
    }

    


}
