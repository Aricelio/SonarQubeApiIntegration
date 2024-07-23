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
