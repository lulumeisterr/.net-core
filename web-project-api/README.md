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

    # Ciclos de vida
      - Scoped : Para cada requisição solicitada no injetor, o mesmo cria apenas uma unica instancia de objeto na memoria e reutiliza a mesma instancia até finalizar o ciclo da aplicação ou seja até o 200 OK ou erro no mesmo contexto. 

      - Transient : Para cada instancia solicitada a partir do injetor de dependencia, é gerada uma nova instancia de objeto na memoria, só é discartado quando a requisição é encerrada.

      - Singleton : A instancia só é criada somente se for chamar via injetor mas a finalização do ciclo dela só encerra se a aplicação for finalizada.

    # Multiplas classes para a mesma interface.
      - Por padrão o framework utilizada a ultima instancia configurada no container.
        -  Para fazer seleções de instancia de injecao de dependencia, deve-se passar no 
           construtor uma lista de Interfaces e a partir de uma solicitação buscar a instancia desejada.
# Comandos de execução
  - dotnet watch run
  - donet run
  - dotnet web
  - donet console
   


  
  
