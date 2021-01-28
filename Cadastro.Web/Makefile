#Project Variables

PROJECT_NAME ?= Cadastro
.PHONY: migrations db

migrations: 
	cd ./Cadastro.Data && dotnet ef --startup-project ../GoodBooks.Web/ migrations add $(mname) && cd ..

db: 
	cd ./Cadastro.Data && dotnet rf --startup-project ../Cadastro.Web/ database update && cd ..

hello:
	echo 'hello!'

