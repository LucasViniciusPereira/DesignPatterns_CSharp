# LV.DesignPatterns_CSharp

Este é um projeto básico que contem vários padrões de projetos que visa exemplificar e mostrar a aplicabilidade dos padrões em seu uso em soluções do dia a dia.

Criado por mim, Lucas Vinicius, segue abaixa a explicação dos padrões existentes no projeto.:

## 1 - Criação

Factory Method:
	Tem como objetivo criar uma instância de um objeto.
	Exemplo: Criar a instância de uma montadora, FIAT, FORD, Volkswagen
	através de um enum

Abstract Factory:
	Tem como objetivo criar familia de objetos.
	Exemplo: Criar uma familia carror de uma montadora, FIAT, FORD, Volkswagen
	através de um tipo.

Builder:
	Tem como objetivo criar objetos complexos definindo ordem de criação dos objetos.
	Exemplo: Criar um objeto carro, e o builder irá criar o motor, chassis e os pneus.
	
Prototype:
	Tem como objetivo criar objeto apartir de si mesmo, ele vai realizar uma cópia de si mesmo e 
	retornar para o novo objeto.
	Exemplo: Criar um objeto Pai ou Filho e criar um objeto a sua semelhança.
	
Singleton:
	Garantir que uma classe tenha somente uma instância e fornece um ponto global de acesso para a mesma.
	Exemplo: Criar instância para acesso ao Banco de Dados.

## 2 - Estrutural

Adapter:
	Tem como objetivo comunicação entre interfaces incompativeis, permitindo que interfaces incompatíveis trabalhem em conjunto
	o que, de outra forma, seria impossível.
	Exemplo: Temo uma API(Terceiros), e vamos criar um adapter para realizar essa comunicação entre elas.
	
Bridge:
	Tem como objetivo separar a implementação da abstração, de modo que as duas possam variar independentemente.
	Exemplo: Cartao de credito e a forma de pagamento, vamos escolher a forma de pagamento e escolher o cartao.
	
Composite:
	Tem como objetivo  criar uma classe base que contém toda a interface necessária para todos os elementos e criar 
	um elemento especial que agrega outros elementos.
	Exemplo: Criar um Formulario e seus objetos, todos os objetos são tratados da mesma forma.
	
Decorator:
	Tem como objetivo de agregar dinamicamente responsabilidades adicionais a objetos.
	Exemplo: Utilizando Repositorios, foi decorado o repositorio e adicionado o commitADO.

Facade:
	Tem como objetivo interface unificada para um conjunto de interfaces em um subsistema, para ser mais fácil de user usada.
	Exemplo: Inicializar os serviços de um telefone, apenas com o metodo de inicialização.
	
Proxy:
	Tem como objetivo agregar funcionalidades ao objeto ou marcador da localização de outro objeto para controlar o acesso a esse objeto.
	Exemplo: Adicionar uma validação antes de executar o acesso ao banco de dados.
	
## 3 - Comportamentais

Strategy:
	Tem como objetivo definir uma estratégia para executar determinada ação, Strategy permite que o algoritmo varie independentemente 
	dos clientes que o utilizam.
	Exemplo: Calcular a faixa salarial do funcionario, baixa, media ou alta;

Iterator:
	Tem como objetivo fornecer um meio de acessar, sequencialmente, os elementos de um objeto agregado sem expor sua 
	representação subjacente.
	Exemplo: Listando uma objeto de equipe sem saber sua implementação.
	
TemplateMethod:
	Tem como objetivo representar as variações nos comportamentos da estrutura de classe.
	Exemplo: Corrigir provas, de matematica e de portugues, o ator é o mesmo o comportamento é diferente em cada classe.
	
Observer:
	Tem como objetivo definir uma dependência um para muitos entre objetos, de maneira que quando um objeto muda de estado todos os seus 
	dependentes são notificados e atualizados automaticamente.
	Exemplo: Simular uma roleta de onibus, quando o cartao passa na maquina ele notifica a roleta e libera ela.

Mediator:
	Tem como objetivo definir um objeto que encapsula a forma como um conjunto de objetos interage.
	Exemplo: Mediador entre dois objetos que irão se comnunicar.
	
Commnad: 
	Tem como objetivo encapsular a chamadar de comandos e enfileirar chamadas e pondendo ser desfeitas.
	Exemplo: Validação entre cliente e server.
	
Memento:
	Tem como objetivo sem violar o encapsulamento, capturar e externalizar um estado interno de um objeto, de maneira 
	que o objeto possa ser restaurado para esse estado mais tarde.
	Exemplo: Criar uma ide para armazer o ultimo texto digitado e assim poder recupera a ultima informação digitada.
	
Chain Of Responsibility:
	Tem como objetivo evitar o acoplamento do remetente de uma solicitação ao seu receptor, 
	ao dar a mais de um objeto a oportunidade de tratar a solicitação. Encadear os objetos receptores, 
	passando a solicitação ao longo da cadeia até que um objeto a trate.
	Exemplo: Validação de formulário (Cliente, Servidor e Banco de dados)

State:
	Tem como objetivo definir um estado para um determinado objeto com intuito de representar o seu estado atual.
	Exemplo: Representar o estado de duas pessoas. (Correndo, Parada ou Atirando).

