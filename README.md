🗑️ Trash Generator
O Trash Generator é uma aplicação Windows Forms desenvolvida em C# que permite gerar códigos aleatórios (trash code) e adicioná-los a arquivos de projeto para fins de ofuscação e proteção de código. Além disso, a aplicação utiliza o MaterialSkin.2 para uma interface moderna e agradável.



📌 Funcionalidades

🎲 Geração de Código Aleatório:



Gera strings aleatórias com base em letras, números e símbolos selecionados pelo usuário.

Permite definir o tamanho do código gerado.

🔒 Proteção de Arquivos:



Permite selecionar um arquivo .cs e adicionar "junk code" (código inútil) ao final do arquivo.

O junk code é composto por variáveis aleatórias que não interferem na funcionalidade do programa.



💻 Interface Moderna:



Utiliza o MaterialSkin.2 para uma interface com tema escuro e cores personalizáveis.

Botões, caixas de texto e checkboxes estilizados para uma experiência visual agradável.

📋 Copiar para Área de Transferência:



Permite copiar o código gerado para a área de transferência com um único clique.

🛠️ Pré-requisitos


Visual Studio (recomendado 2022 ou superior).

.NET Framework (versão 4.7.2 ou superior).

MaterialSkin.2 (instalado via NuGet).

🚀 Como Configurar


Clone o Repositório:

bash
Copy
git clone https://github.com/seu-usuario/TrashGenerator.git
Abra o Projeto no Visual Studio:

Abra o arquivo TrashGenerator.sln no Visual Studio.

Instale o MaterialSkin.2:

No Visual Studio, abra o NuGet Package Manager.

Procure por MaterialSkin.2 e instale o pacote.

Compile o Projeto:

Compile o projeto para garantir que tudo está funcionando corretamente.



🖥️ Como Usar


🎲 Geração de Código Aleatório


Selecione os tipos de caracteres (letras, números, símbolos).

Defina o tamanho do código no campo NumericUpDown.

Clique em Gerar para criar o código aleatório.

Use o botão Copiar para copiar o código gerado para a área de transferência.

🔒 Proteção de Arquivos


Clique em Selecionar Arquivo para escolher um arquivo .cs.

Clique em Protect para adicionar o junk code ao final do arquivo selecionado.

💻 Interface
A interface é intuitiva e segue o tema escuro com cores roxas.

Todos os controles são estilizados para uma experiência visual agradável.



🏗️ Estrutura do Projeto


Form1.cs: Contém a lógica principal da aplicação, incluindo a geração de código e a adição de junk code.

MaterialSkin: Biblioteca utilizada para estilizar a interface.

Arquivos de Recurso: Ícones e imagens (se houver).

📷 Captura de Tela

![image](https://github.com/user-attachments/assets/61252066-d86f-46cf-a8d7-f7559cd3600f)


🤝 Contribuição


Contribuições são bem-vindas! Siga os passos abaixo:

Faça um fork do projeto.

Crie uma branch para sua feature (git checkout -b feature/nova-feature).

Commit suas mudanças (git commit -m 'Adicionando nova feature').

Push para a branch (git push origin feature/nova-feature).

Abra um Pull Request.



📜 Licença

Este projeto é open source.
