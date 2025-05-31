# GeradorPoemaWin

**GeradorPoemaWin** é um aplicativo Windows Forms em C# (.NET Framework 4.7.2) que permite ao usuário criar poemas personalizados a partir de palavras e sentimentos escolhidos. O usuário informa nome, lugar, sentimento, qualidade e escolhe um dos estilos de poema disponíveis. O aplicativo então gera automaticamente um poema com base nas escolhas.

## Funcionalidades

- Interface gráfica simples e intuitiva.
- Geração automática de poemas personalizados.
- Quatro estilos de poema:
  1. Poema clássico fofinho
  2. Poema moderno
  3. Poema rimado
  4. Poema versão "Cria"
- Validação dos campos obrigatórios.
- Limpeza automática dos campos após a geração do poema.

## Captura de Tela

![WhatsApp Image 2025-05-31 at 13 48 39](https://github.com/user-attachments/assets/e7e85f4f-5d2c-4b91-987f-c39f165ea000)
reenshot.png)

## Como Usar

1. **Abra o aplicativo.**
2. **Preencha os campos:**
   - Nome
   - Lugar especial
   - Sentimento (ex: amor, saudade)
   - Qualidade (ex: doce, forte, gentil)
3. **Escolha o tipo de poema** na lista suspensa.
4. **Clique em "Gerar Poema".**
5. O poema será exibido na caixa de resultado.
6. Os campos serão limpos automaticamente para uma nova criação.

## Instalação e Execução

### Pré-requisitos

- Windows 7 ou superior
- [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472)
- Visual Studio 2017 ou superior (para compilar)

### Passos

1. Clone este repositório:
2. Abra a solução `GeradorPoemaWin.sln` no Visual Studio.
3. Compile o projeto (`F6` ou `Build > Build Solution`).
4. Execute (`F5` ou `Debug > Start Debugging`).

## Estrutura do Projeto

## Código Principal

A lógica de geração do poema está no método `button1_Click` do `Form1.cs`. O método lê os valores dos campos, valida as entradas, gera o poema conforme a escolha e exibe o resultado.


## Personalização

Você pode editar os textos dos poemas no método `GerarPoema` em `Form1.cs` para criar novos estilos ou adaptar para outras ocasiões.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou pull requests.

## Licença

Este projeto está licenciado sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## Autor

- Desenvolvido por [Seu Nome ou Usuário do GitHub]

## Tempo de produção

Aproximadamente **2 horas**.

---

# GeradorPoemaWin

<div align="center">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#"/>
  <img src="https://img.shields.io/badge/.NET_Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET Framework"/>
  <img src="https://img.shields.io/badge/Windows_Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white" alt="Windows Forms"/>
  <img src="https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white" alt="Visual Studio"/>
</div>

<br />

**GeradorPoemaWin** é um aplicativo Windows Forms em C# (.NET Framework 4.7.2) que permite ao usuário criar poemas personalizados a partir de palavras e sentimentos escolhidos.

---

## ✨ Funcionalidades

- Interface gráfica simples e intuitiva.
- Geração automática de poemas personalizados.
- Quatro estilos de poema:
  1. Poema clássico fofinho
  2. Poema moderno
  3. Poema rimado
  4. Poema versão "Cria"
- Validação dos campos obrigatórios.
- Limpeza automática dos campos após a geração do poema.

---

## 🖼️ Captura de Tela

![Screenshot](https://github.com/user-attachments/assets/e7e85f4f-5d2c-4b91-987f-c39f165ea000)

---

## 🚀 Como Usar

1. **Abra o aplicativo.**
2. **Preencha os campos:**
   - Nome
   - Lugar especial
   - Sentimento (ex: amor, saudade)
   - Qualidade (ex: doce, forte, gentil)
3. **Escolha o tipo de poema** na lista suspensa.
4. **Clique em "Gerar Poema".**
5. O poema será exibido na caixa de resultado.
6. Os campos serão limpos automaticamente para uma nova criação.

---

## 🛠️ Instalação e Execução

### Pré-requisitos

- Windows 7 ou superior
- [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472)
- Visual Studio 2017 ou superior (para compilar)

### Passos

```bash
git clone https://github.com/MvcVictor/GerarPoemaCRUD.git
