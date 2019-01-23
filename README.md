# Programmers_Teste
Avaliação API

Fazer os seguintes procedimentos para teste da aplicação :

1. Instalar o SDGB Ms SQL Server Express 2012.
2. Rodar os scripts que se encontram na pasta \Scripts_Database na seguinte ordem:
a - Create_Database_SQL_Server_Express_2012.sql
b - Create_Tabela.sql
c - Popular_Tabela.sql

3 - Abrir o arquivo Web.Config e localizar a chave <connectionString> e mudar o parametro connectionString para sua string de conexao local.

4 - Para testar os casos:

4.1 - Caso de Peça tipo Tragéda , fornecer a seguint url do recurso : /api/v1/Price/CalculateTicketTotal (verbo POST)
Obs: no corpo da requisição

{
    "idEvent":"1",
    "audience": "55",
    "value": "0",
    "nameCustomer":"Cliente"
}

4.1 - Caso de Peça tipo Comédia , fornecer a seguint url do recurso : /api/v1/Price/CalculateTicketTotal (verbo POST)
Obs: no corpo da requisição

{
    "idEvent":"2",
    "audience": "35",
    "value": "0",
    "nameCustomer":"Cliente"
}




  
  
  
  
  
  
  


