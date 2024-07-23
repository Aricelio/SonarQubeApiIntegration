### **English**
This project is a example of a .NET API that integrates with a local SonarQube service.

Steps to configurate:
  - Installation of SonarQube: 
    - From Docker Image:  
      - Script: ```$ docker run -d --name sonarqube -e SONAR_ES_BOOTSTRAP_CHECKS_DISABLE=true -p 9000:9000 sonarqube:latest```
      - Reference: https://docs.sonarsource.com/sonarqube/latest/try-out-sonarqube/

  - Using SonarQube on .NET:
    - Using .NET Global tool:
      - Script: ```dotnet tool install --global dotnet-sonarscanner --version x.x.x```
      - Reference: https://docs.sonarsource.com/sonarqube/latest/analyzing-source-code/scanners/sonarscanner-for-dotnet/

  - Creating a GitHub App: https://docs.sonarsource.com/sonarqube/9.8/devops-platform-integration/github-integration/
  - Installing a GitHub App: https://docs.github.com/en/apps/using-github-apps/installing-your-own-github-app
  - With the Sonar Container running
    - Import the project from the GitHub
    - Create a new token following the path: Your account -> Security -> Generate tokens
      - Reference: https://docs.sonarsource.com/sonarqube/latest/user-guide/user-account/generating-and-using-tokens/
    - Do the code pull into SonarQube:
      - ```dotnet sonarscanner begin /k:"<YOUR_PROJECT_KEY>" /d:sonar.host.url="<SONAR_HTTP_URL>"  /d:sonar.token="<YOUR_TOKEN>"```
      - ```dotnet build```
      - ```dotnet sonarscanner end /d:sonar.token="<YOUR_TOKEN>"```

### **Portuguese**
Esse projeto é um exemplo de uma API .NET que integra com um serviço local do SonarQube.

Passos para configuraçao:
  - Instalar o SonarQube:
    - A partir de uma imagem Docker:
      - Script: ```$ docker run -d --name sonarqube -e SONAR_ES_BOOTSTRAP_CHECKS_DISABLE=true -p 9000:9000 sonarqube:latest```
      - Referência: https://docs.sonarsource.com/sonarqube/latest/try-out-sonarqube/
  - Usando o SonarQube no .NET:
      - Usando a ferramenta .NET Global:
      - Script: ```dotnet tool install --global dotnet-sonarscanner --version x.x.x```
      - Referência: https://docs.sonarsource.com/sonarqube/latest/analyzing-source-code/scanners/sonarscanner-for-dotnet/
  - Criando um App GitHub:
    - Referência: https://docs.sonarsource.com/sonarqube/9.8/devops-platform-integration/github-integration/
  - Instalando um App GitHub:
    - Referência: https://docs.github.com/en/apps/using-github-apps/installing-your-own-github-app
  - Com o container do Sonar rodando, siga os passos abaixo:
    - Importe o projeto do GitHub para o Sonar
    - Crie um novo token seguindo o caminho: Sua Conta -> Segurança -> Gerar tokens
      - Referência: https://docs.sonarsource.com/sonarqube/latest/user-guide/user-account/generating-and-using-tokens/
    - Suba o código do projeto para o Sonar executando os comandos abaixo:
      - ```dotnet sonarscanner begin /k:"<YOUR_PROJECT_KEY>" /d:sonar.host.url="<SONAR_HTTP_URL>"  /d:sonar.token="<YOUR_TOKEN>"```
      - ```dotnet build```
      - ```dotnet sonarscanner end /d:sonar.token="<YOUR_TOKEN>"```
