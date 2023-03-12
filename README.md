# CEP Minimal API
Este repositório contém uma aplicação Minimal API que consome a API do Via CEP para retornar informações de endereço a partir de um CEP.

## Como usar
1. Clone o repositório em seu ambiente local:
```bash
git clone https://github.com/LucasFernandes0101/cep-minimal-api.git
```
Instale as dependências do projeto:
```bash
npm install
```
Execute a aplicação:
```bash
npm start
```
Faça uma requisição GET para a URL `https://localhost:7047/GetCep/{cep}`, substituindo {cep} pelo CEP desejado.

Exemplo:
```bash
curl https://localhost:7047/GetCep/01001000
```
A resposta será um objeto JSON contendo as informações de endereço correspondentes ao CEP informado.

## Funcionamento
A API utiliza a classe HttpClient para realizar uma requisição HTTP para a API do Via CEP com o CEP fornecido pelo usuário. Em seguida, as informações de endereço retornadas pela API são desserializadas para o objeto Address e retornadas como uma resposta HTTP na forma de um objeto JSON.

## Motivação
Este projeto foi criado para fins de estudo e prática de desenvolvimento de Minimal Api's .NET Core e consumo de API externas. Sinta-se à vontade para utilizá-lo como referência ou como base para seus próprios projetos. Se você encontrar algum problema ou tiver alguma sugestão de melhoria, sinta-se à vontade para abrir uma issue ou um pull request.
