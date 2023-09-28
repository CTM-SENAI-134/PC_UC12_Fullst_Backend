# Pc-Back



1-certificar que você tem instalado

 1-1 Dotnet -  É importante instalar o Dotnet se você quiser usar programas ou aplicativos que foram criados com essa tecnologia. O Dotnet é como um conjunto de ferramentas que esses programas precisam para funcionar corretamente. Para conseguir isso, você pode ir até o seguinte link  (https://dotnet.microsoft.com/en-us/download)
 

 ![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/22c2b331-d464-4a6e-ab60-b9d3dc02e0f5)

 Opção recomendada devido ter um longo suporte da microsoft
 
 1-2 -  Vscode,É essencial instalar o Visual Studio Code (VSCode), caso ainda não o tenha no seu computador, para criar e editar código de maneira eficaz. O VSCode é uma poderosa ferramenta para desenvolvedores e oferece recursos essenciais. Você pode fazer o download e instalar o VSCode a partir deste link:  (https://code.visualstudio.com/)
 
 ![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/5a3e469d-9732-425c-97c2-d1fef448469c)
 
 Acesse o link https://code.visualstudio.com/.
Selecione a opção correspondente ao seu sistema operacional (por exemplo, Windows, macOS ou Linux) e clique para iniciar o download.
Após o download, siga as instruções de instalação para concluir o processo.
 
 1-3 - Extensões, segue imagem abaixo quais são as extensões que é necesario fazer a instalação 
 
   ![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/2faa4a85-2e08-44c2-b09a-24900084bb04)
   


2- Você precisa criar um console de cadastro de pessoas juridicas para registrar informações sobre uma empresa por exemplo.



![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/d2d86310-0ad6-4398-bbd5-f4fb96f33efd)

2-1 - O comando "dotnet new console" cria um novo projeto de console em C# com as configurações básicas. É usado para iniciar um programa simples que funciona no prompt de comando

![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/0e18c004-f566-45c8-b56f-c753180d812a)


3-A estrutura de pasta das classes geralmente segue uma organização hierárquica, onde as pastas representam os namespaces e os arquivos nas pastas contêm as classes. Isso ajuda a organizar o código de maneira mais eficiente e a manter um projeto limpo e compreensível 

  3-1 - Vamos criar a pasta de classes
  
   ![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/774e53a7-2dbe-4639-9b45-f5a0964fdca9)
    

  3-2 - Uma classe é um modelo ou um plano para criar objetos em programação orientada a objetos (POO). Ela define as propriedades (atributos) e comportamentos (métodos) que os objetos criados a partir dela terão. As classes são fundamentais para estruturar e organizar o código, permitindo a reutilização e a criação de objetos que compartilham características comuns.
  

![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/f83224f4-87c6-4197-aa25-02bedca8b7e0)


  4- Um atributo em programação é uma variável ou campo que faz parte de uma classe ou objeto e armazena informações específicas sobre esse objeto. Os atributos representam as características ou propriedades dos objetos e podem ser usados para armazenar dados relacionados a eles. Por exemplo, em uma classe "Carro", os atributos podem incluir informações como cor, modelo, ano de fabricação, etc. Esses atributos ajudam a descrever o estado de um objeto e são acessados e manipulados por métodos da classe.


  4-1 Criar o atributo da classe pessoa
  
  ![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/de3950c9-bee5-4baa-a1d7-2d5a73638e6f)

4-2 - Criar o atributo da classePessoaJurudica

![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/f6574110-efd7-4f89-ad24-48058c837510)


5 - Um método em programação é um conjunto de instruções que realiza uma tarefa específica. Ele está dentro de uma classe e pode receber dados, processá-los e, opcionalmente, retornar um resultado. Os métodos são usados para organizar o código e reutilizar a lógica em diferentes partes do programa.

![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/a63850b5-7156-47cb-a88a-994d95d3b8fe)

6 - criar metodo para ler arquivo txt

![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/531653b5-25ae-47f2-9753-93c2122526bd)

7 - Criar program
No contexto do .NET, o arquivo "Program.cs" é um arquivo de código-fonte C# que geralmente serve como ponto de entrada para um aplicativo ou projeto. Ele contém o método "Main", que é o ponto de partida da execução do programa. O código dentro do "Program.cs" pode chamar outras classes e métodos para iniciar a lógica do aplicativo e é onde muitas vezes você configura o ambiente inicial e interações do usuário, dependendo do tipo de aplicativo que está sendo desenvolvido. É uma parte fundamental de muitos projetos .

 7-1 opção de saida

No contexto do .NET, a opção de saída se refere ao local onde os arquivos de compilação gerados são armazenados após a compilação de um projeto. É onde os executáveis ou bibliotecas resultantes são colocados para que você possa executar ou usar o software que desenvolveu. Dependendo do tipo de projeto, a opção de saída pode ser uma pasta específica no sistema de arquivos onde os arquivos compilados são colocados para acesso posterior. Isso é configurado nas propriedades do projeto ou no arquivo de configuração do projeto.

 ![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/fb076903-8925-4651-80a1-c995fbd96ae1)

 7-2 criar menu

No contexto do .NET, a criação de um menu é fundamental para oferecer uma interface de usuário eficiente e organizada em aplicativos desktop, como aqueles desenvolvidos com Windows Forms ou WPF, ou em aplicativos web usando ASP.NET. Ele ajuda os usuários a navegar e acessar diferentes partes do aplicativo de forma intuitiva, garantindo uma experiência mais amigável e produtiva. Além disso, a criação de menus segue padrões de design e acessibilidade, tornando a aplicação mais consistente e fácil de usar. Portanto, no desenvolvimento .NET, a implementação adequada de menus é uma prática comum e útil.

![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/10b1ec34-3015-44c8-bce4-e996b345562b)

![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/aae50ca4-408c-4c31-9964-7e59f50410c6)


 
7-3 - Switch Case

O switch case é uma estrutura de controle de fluxo em programação que permite tomar decisões com base no valor de uma expressão. Funciona comparando o valor da expressão com várias opções (casos) e, quando encontra uma correspondência, executa um bloco de código associado a esse caso específico.
![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/f99664fa-0122-4e0a-9eb0-a1d5ac6f78e2)

7-4 criar o case 1

![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/285da9ab-d76c-44fe-bc95-e3aaf2e22c24)



![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/43b1fffa-996d-40f1-81a9-1ccb4ccec0ce)


![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/54cadc03-7a30-4399-9629-eb6efdd60130)


8- Criar o case 2

![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/812820a6-4186-4640-832d-b27b2d48a69c)

8-1 

![image](https://github.com/CTM-SENAI-134/ME_UC12_Fullst_Backend/assets/144062335/2aa93a02-73f8-4a6d-b868-d0de3fa069f7)

