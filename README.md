# Bootcamp LocalizaLabs

## APP 

Sistema de controle de titulos de filmes e séries. Permite Criar novos registros de filmes e séries, Listar ID e Titulo, Vizualizar mais detalhes, Editar e Deletar.

## Ambiente

``.NET 5.0 SDK``

## Rodando em Sua Máquina

1 - Clone o Repositório em sua máquina utilizando o seguinte comando no prompt.

`` $ git clone https://github.com/flavioepimentel/Bootcamp_LocalizaLabs ``

2 - Certifique-se de que seu ambiente foi devidamente configurado e execute o seguinte comando.

`` $ dotnet run -p DIO.Obras ``

## Navegando Entre as Opções

  Após o start da aplicação o resultado esperado é a exibição do menu abaixo. A base de dados da aplicação iniciada não esta conectada a um serviço de banco de dados e será iniciada vazia, então para selecionar a opção 1, 3 e 5 sem receber uma mensagem de erro é necessário inserir um novo dado no sistema.

```
Stream DIO
===================
1 - Listar titulos
2 - Inserir novos titulos
3 - Atualizar titulo
4 - Excluir titulo
5 - Visualizar titulos disponíveis
X - Sair
```

### Criando novo dado

  Selecionando a opção `2` no menu acima será printado:
  
  ```
  
  Inserir novo titulo
1-Acao
2-Aventura
3-Romance
4-Comedia
5-Terror
6-Fantasia
7-Policial
8-Faroeste
9-Scify
10-Espionagem
12-Musical
13-Infantil
14-Guerra
Digite o gênero entre as opções acima:


```
  Para esse teste foi escolhido um filme de espionagem, "Sem Remorso". Então o formulário foi preenchido da seguinte forma:
  
``` 
Digite o gênero entre as opções acima: 10
Digite o Título da Obra: Sem Remorso
1-Serie
2-Filme
3-Show
4-Documentario
Digite a categoria da Obra: 2
Digite o Ano de Início da Obra: 2021
Digite os nomes do elenco: Jack Kesy, Jacob Scipio, Brett Gelman, Cam Gigandet, Jamie Bell, Jodie Turner-Smith, Luke Mitchell, Michael B. Jordan, Todd Lasance
Digite a Descrição da Obra: Sem Remorso (também conhecido como Tom Clancy's Without Remorse) é um filme americano de ação lançado em 2021, baseado na série publicada por Tom Clancy em 1993, um spin-off da série de filmes do Jack Ryan. É dirigido por Stefano Sollima e escrito por Taylor Sheridan e Will Staples

```

### Listando e vizualizando todos os registros
  
  
  Selecionando a opção `1` os registros serão exibidos um a um com o seu ID.


```
# ID 0: - Sem Remorço

[Enter] Retorna ao menu
```

  Selecionando a opção `5` vamos informar o ID `0` e resultado esperado será:
  
```
Informe o ID do Titulo: 0

Genero: Espionagem
Titulo: Sem Remorso
Ano: 2021
Categoria: Serie
Elenco: Jack Kesy, Jacob Scipio, Brett Gelman, Cam Gigandet, Jamie Bell, Jodie Turner-Smith, Luke Mitchell, Michael B. Jordan, Todd Lasance
Descricao: Sem Remorso (também conhecido como Tom Clancy's Without Remorse) é um filme americano de ação lançado em 2021, baseado na série publicada por Tom Clancy em 1993, um spin-off da série de filmes do Jack Ryan. É dirigido por Stefano Sollima e escrito por Taylor Sheridan e Will Staples       


Pressione qualquer tecla e retorne ao menu
```

### Estrutura de dados

| Variavel | Formato | Metodo |
|----------|---------|--------|
| Id | int | get |
| Genero | enum | get, set |
| Titulo | string | get, set |
| Descricao | string | get, set |
| Ano | string | get, set |
| Excluido | bool | get, set |
| Categoria | enum | get, set |
| Elenco | string | get, set |

