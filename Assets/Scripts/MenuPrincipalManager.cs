using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private string Level_2s;
    [SerializeField] private string Level_3;

    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;
    [SerializeField] private GameObject painelSelecao;
    [SerializeField] private GameObject TelaHistoria;

    public void Fase1() 
    {
        SceneManager.LoadScene("Fase1");
    }

    public void AbrirOpcoes() 
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }
    public void FecharOpcoes() 
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

    public void SairJogo() 
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }

    public void AbrirSelecao() 
    {
        painelMenuInicial.SetActive(false);
        painelSelecao.SetActive(true);
    }
    public void Fase2() 
    {
        SceneManager.LoadScene("Fase2");
    }    
    public void Fase3() 
    {
        SceneManager.LoadScene("Fase3");
    }
    public void FecharSelecao() 
    {
        painelSelecao.SetActive(false);
        painelMenuInicial.SetActive(true);
    }
    public void AbrirHistoria() {
        TelaHistoria.SetActive(true);
    }
    public void FecharHistoria() {
        TelaHistoria.SetActive(false);
    }
}
