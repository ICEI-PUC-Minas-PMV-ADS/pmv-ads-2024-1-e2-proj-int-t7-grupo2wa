# Plano de Testes de Software


 
| **Caso de Teste** 	| **CT-01 – Validar a inserção de dados para criação de uma conta** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-01 -  Permitir que o usuario se registre no site e efetue o login |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar-se na aplicação. |
| Passos 	| 01-Acessar a página de cadastro de usuário <br> 02-Inserir um nome no campo _Nome_. <br> 03-Inserir um endereço de e-mail no campo _e-mail_. <br> 04-Inserir caracteres da senha no campo _senha_.<br> 05-Clicar em _Cadastrar_. |
|Critério de Êxito | Mensagem "bem-vindo" na tela. |
|  	|  	|
| **Caso de Teste**	| **CT-02 – Efetuar login**	|
|	Requisito Associado 	| RF-01 - Acesso funcional aos Jogos |
| Objetivo do Teste 	| Verificar se o usuário consegue logar-se na aplicação. |
| Passos 	| 01-Acessar a página de login  <br> 02-Inserir o nome já cadastrado no campo _nome de usuario_. <br> 03-Inserir a senha cadastrada no campo _senha_.<br> 05-Clicar em _Entrar_. |
|Critério de Êxito | Login na aplicação e exibição da tela "Jogos" |
|  	|  	|
| **Caso de Teste**	| **CT-03 – Usuario conseguirar pesquisar ou filtrar os jogos**	|
|Requisito Associado | RF-02	- A aplicação deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar os jogos.|
| Objetivo do Teste 	| Verificar se o usuário consegue buscar por jogos. |
| Passos 	|  01-Acessar a página jogos <br> 02-Clicar na barra de pesquisa <br> 03-Digitar o nome do jogo <br> 04-Clicar em _busca_ |
|Critério de Êxito | Buscar o jogo atraves da barra de pesquisa. |
|  	|  	|
| **Caso de Teste**	| **CT-04 – Sistema de rangking baseado em cada jogo**	|
|Requisito Associado | RF-03- Sistema de ranking (pontuaçao) para algumas aplicaçoes na soluçao. |
| Objetivo do Teste 	| Verificar se o usuário consegue pontuar nos jogos. |
| Passos 	| 01-Acessar a página de jogos  <br> 02-Procurar o jogo. <br> 03- Jogar o jogo.<br> 04-Fazer a pontuação.
|Critério de Êxito | Mostrar a pontuação do usuario. |
|  	|  	|
| **Caso de Teste**	| **CT-05 – Alterar o nome de perfil**	|
|Requisito Associado | RF-03- Usuário poderar alterar o nome do perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue editar o nome de usuario. |
| Passos 	| 1-Na coluna de opções da direita, na tela inicial, clicar em _Perfil_ <br> 02- No _Campo 1_ , inserir o novo nome de usuario. <br> 07-Clicar em _Alterar nome de usuario_.  11- Clicar em _Salvar_. |
|Critério de Êxito | Usuario conseguirar alterar o nome. |
|  	|  	|
| **Caso de Teste**	| **CT-06 – Alterar a foto de perfil**	|
|Requisito Associado | RF-00Y	- Usuário poderar alterar a foto de perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue alterar a foto. |
| Passos 	 |Na coluna de opções da direita, na tela inicial, clicar em _Perfil_ <br> - Clicar no botão "foto" <br> - Inserir a foto <br> - Clicar em _Salvar_. |
|Critério de Êxito | - O usuario conseguirar mudar a foto do perfil. |
|  	|  	|
| **Caso de Teste**	| **CT-07 – Alterar o email do usuario**	|
|Requisito Associado | RF-00Y	- Usuário poderar alterar alterar o email. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar a alteração do email. |
| Passos 	| Na coluna de opções da direita, na tela inicial, clicar em _Perfil_ <br> - Clicar no botão "Alterar email" <br>   - Clicar em _Salvar_ .|
|Critério de Êxito | -A alteraçao sera realizada com sucesso. |
|  	|  	|
| **Caso de Teste**	| **CT-08 – Recuperar senha de acesso**	|
|Requisito Associado | RF-02	- O usuário deve conseguir recuperar senha |
| Objetivo do Teste 	| Verificar se o usuário consegue recuperar o acesso à aplicação após esquecer a senha. |
| Passos 	| -Acessar a página de login  <br> -Clicar em _Esqueci minha senha_ <br> -Digitar o e-mail cadastrado no campo _E-mail_ <br> -Clicar em _Enviar e-mail_ |
|Critério de Êxito | Receber a senha previamente cadastrada no e-mail cadastrado. |
|  	|  	|
| **Caso de Teste**	| **CT-09 – Tutorial dos jogos**	|
|Requisito Associado | RF-00Y	- Usuário tera acesso ao tutorial de cada jogo na aplicação. |
| Objetivo do Teste 	|  Verificar se o usuário consegue acessar o tutoria. |
| Passos 	| - Acessar a pagina do jogo <br> - Selecionar o jogo da preferrencia  <br> - Aparecerar um  video do tutorial para o usuario.  |
|Critério de Êxito | - O Tutorial aparecerar para o usuario. |
|  	|  	|
| **Caso de Teste**	| **CT-10 – Pontuação dos melhores no ranking**	|
|Requisito Associado | RF-00Y	- O sistema devera salvar a pontuaçao do usuario e exibir a maior no ranking dos 10 melhores. |
| Objetivo do Teste 	| Verificar se o usuário consegue acessar a pontuação no ranking. |
| Passos 	| - Acessar o pagina de jogos <br> - Selecionar o jogo da preferencia <br> - Clicar no botão "Jogar" <br> -Iniciar o game <br> - Fazer a pontuação <br> - Ao final os pontos seram salvos e entraram no ranking <br> - Acessar a pagina de ranking  |
|Critério de Êxito | - A pontuaçao do usuario aparecerar no ranking dos 10 melhores. |
|  	|  	|

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
