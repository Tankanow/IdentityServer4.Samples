FROM microsoft/dotnet:1.0.0-preview2-sdk

WORKDIR /app

ADD project.json project.json

RUN dotnet restore

ADD . .

EXPOSE 1773

CMD dotnet run
