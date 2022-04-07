# Configuração de portas
  - Properties > LaunchSetting > applicationUrl
# Endpoints de teste
  - [POST] : https://localhost:7198/trade
  - [GET] : https://localhost:7198/trade?startDate=2022-04-01&endDate=2022-04-02
  - [GET] : https://localhost:7198/trade/{tradeId}
  - [PUT] : https://localhost:7198/trade/{tradeId}
  - [DELETE] : https://localhost:7198/trade/{tradeId}

# Sobre Injeção de dependências
  - Estamos criando a injeção de dependencias por construtor onde o mesmo
    é identificado atraves de escopos. A Identificação de injeção ocorre
    por meios de contratos e referencia de contrato(Quem implementa o contrato).
    Para cada construtor na classe de servico, ou construtores assinados com classe
    sempre devem ser especificado no escopo para que o framework consiga encontrar 
    todas as referencias necessarias. O Framework só associa a injeção se todos os pontos
    for mapeado corretamente.
# Comandos de execução
  - dotnet watch run
  - donet run
  - dotnet web
  - donet console
   


  
  
