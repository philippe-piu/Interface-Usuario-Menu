using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Vari�vel p�blica que referencia o GameObject do menu de pausa.
    public GameObject pauseMenu;
    // Vari�vel privada que controla se o menu de pausa est� ativo ou n�o.
    private bool activeMenu;
    // M�todo chamado uma vez por frame, usado para verificar entradas do usu�rio.
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

    // M�todo p�blico chamado para iniciar o jogo.
    public void StartGame()
    {
        // Carrega a cena com �ndice 1 (geralmente a primeira cena do jogo).
        SceneManager.LoadScene(1);
        // Exibe uma mensagem no console para indicar que o bot�o foi pressionado.
        Debug.Log("Bot�o ativado");
    }

    // M�todo p�blico para fechar um menu de op��es.
    public void ExitOptionMenu(GameObject go)
    {
        // Desativa o GameObject passado como par�metro, ocultando o menu de op��es.
        go.SetActive(false);
    }


    // M�todo p�blico para abrir um menu de op��es.
    public void ActiveOptionMenu(GameObject go)
    {
        // Ativa o GameObject passado como par�metro, exibindo o menu de op��es.
        go.SetActive(true);
    }

    


}
