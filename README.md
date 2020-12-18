# AppGetJsonDemo
Uma simples maneira de pegar JSON, utilizando Xamarin. 


<h4 align="center"> 
  <a href="#sobre-o-projeto">Sobre o projeto</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#Tecnologias-e-ferramentas">Tecnologias e ferramentas</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#Demonstração">Demonstração</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  </br>
  <a href="#Como-usar">Como usar</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#Licença">Licença</a>
</h4>

<p align="center">
  <a href="https://opensource.org/licenses/MIT">
    <img src="https://img.shields.io/badge/License-MIT-blue.svg" alt="License MIT">
  </a>
</p>

# Sobre o projeto

Esta solução contém uma simples maneira de consumir um JSON, utilizando o Xamarin. Para isso, foi contruído, previamente, um JSON para que fosse consumido como teste.
Foi escolhido um serviço gratuito de hospedagem JSON, chamado [JSONBin](https://jsonbin.io/), pela sua praticidade e por ser uma simulação de pequena escala.

# Tecnologias e ferramentas

O projeto foi desenvolvido com as seguintes tecnologias:

- [Visual Studio 2019](https://dotnet.microsoft.com/download/dotnet-core/3.1)
- [Xamarin](https://dotnet.microsoft.com/apps/xamarin)

# Demonstração

![JSON](https://github.com/renanegobbi/AppGetJsonDemo/blob/main/Github/JSONBin.png)

![GetJsonXamarin](https://github.com/renanegobbi/AppGetJsonDemo/blob/main/Github/XamGetJson.png)

![Example](https://github.com/renanegobbi/AppGetJsonDemo/blob/main/Github/Example.gif)

# Como usar

Instalar a API chamada NewtonSoft, para trabalhar com JSON. A instalação da API pode ser via Nuget ou usando o comando via console:                 
*`Install-Package Newtonsoft.Json`*

Caso consuma outro JSON, alterar as propriedades na classe Data e substituir a constante URL_GET_DATA na classe ListagemViewModel:                       
*`const string URL_GET_DATA = "aqui_está_a_url_que_conterá_o_JSON"`*

# Licença
Este projeto está sob a licença do MIT. Consulte a [LICENÇA](https://github.com/TesteReteste/lim/blob/master/LICENSE) para obter mais informações.
