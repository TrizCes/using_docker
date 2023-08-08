#BASE DA IMAGEM
FROM mcr.microsoft.com/dotnet/sdk:7.0.304 AS build

#CONFIGURAR O DIRETÓRIO DE TRABALHO DO CONTAINER.
WORKDIR /app

#MIGRAÇÃO DOS ARQUIVOS DA APP PARA A IMAGEM
COPY helloDev.csproj .
RUN dotnet restore

#BUILD
COPY . /app
RUN dotnet publish -c Release -o out

#CAMADA DE RUNTIME
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime

#CONFIGURAR O DIRETÓRIO DE TRABALHO DO CONTAINER.
WORKDIR /app

#TRANSFERÊNCIA DA BUILD PARA O AMBIENTE DE RUNTIME
COPY --from=build /app/out .

#Definindo valor da variavel de ambiente 
ENV AMBIENTE_ESTUDOS Dev
#ENTRYPOINT DO NOSSO APP
ENTRYPOINT ["dotnet", "helloDev.dll"]