# Plano de Testes de Software


 
| **Caso de Teste** 	| **CT-01 – Validar a inserção de dados para criação de uma conta** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-01 - <!-- A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. --> Criar e gerenciar dados de login |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar-se na aplicação. |
| Passos 	| 01-No acesso […], clicar em […] <br> 02-Acessar a página de cadastro de usuário <br> 03-Inserir um nome válido no campo _Nome_. <br> 04-Inserir um endereço de e-mail no campo _e-mail_. <br> 05-Inserir caracteres da senha no campo _senha_.<br> 06-Clicar em _Cadastrar_. |
|Critério de Êxito | E-mail de confirmação recebido e mensagem "bem-vindo" na tela. |
|  	|  	|
| **Caso de Teste**	| **CT-02 – Efetuar login**	|
|	Requisito Associado 	| RF-01 - Criar e gerenciar dados de login |
| Objetivo do Teste 	| Verificar se o usuário consegue logar-se na aplicação. |
| Passos 	| 01-No acesso […], clicar em […] <br> 02-Acessar a página de login _"Bem-vindo de volta"_ <br> 03-Inserir o e-mail já cadastrado no campo _email_. <br> 04-Inserir a senha cadastrada no campo _senha_.<br> 05-Clicar em _Entrar_. |
|Critério de Êxito | Login na aplicação e exibição da tela "Projetos" |
|  	|  	|
| **Caso de Teste**	| **CT-03 – Recuperar senha de acesso**	|
|Requisito Associado | RF-02	- O usuário deve conseguir recuperar senha |
| Objetivo do Teste 	| Verificar se o usuário consegue recuperar o acesso à aplicação após esquecer a senha. |
| Passos 	| 01-No acesso […], clicar em […] <br> 02-Acessar a página de login _"Bem-vindo de volta"_ <br> 03-Clicar em _Esqueci minha senha_ <br> 04-Digitar o e-mail cadastrado no campo _E-mail_ <br> 5-Clicar em _Enviar e-mail_ |
|Critério de Êxito | Receber a senha previamente cadastrada no e-mail cadastrado. |
|  	|  	|
| **Caso de Teste**	| **CT-04 – Criar dados de materiais**	|
|Requisito Associado | RF-03- A aplicação deve possuir a opção de criar e gerenciar dados dos materiais. |
| Objetivo do Teste 	| Verificar se o usuário consegue criar um material. |
| Passos 	| 01-Acessar a página de login _"Bem-vindo de volta"_ <br> 02-Inserir o e-mail já cadastrado no campo _email_. <br> 03-Inserir a senha cadastrada no campo _senha_.<br> 04-Clicar em _Entrar_. <br> 05-Na coluna de opções da esqueda, na tela inicial de Projetos, clicar em _Materiais_ <br> 06-Clicar sobre o ícone **+** no canto superior esquerdo da tela de Materiais. <br> 07- No _Campo 1_ e _Campo 2_, inserir o nome do material e o preço, respectivamete. <br> 08-Clicar em _Cadastrar_. |
|Critério de Êxito | Material é criado e exibido na lista na tela de Materiais. |
|  	|  	|
| **Caso de Teste**	| **CT-05 – Editar os dados de um material**	|
|Requisito Associado | RF-03- A aplicação deve possuir a opção de criar e gerenciar dados dos materiais. |
| Objetivo do Teste 	| Verificar se o usuário consegue editar os dados de um material. |
| Passos 	| 01-Acessar a página de login _"Bem-vindo de volta"_ <br> 02-Inserir o e-mail já cadastrado no campo _email_. <br> 03-Inserir a senha cadastrada no campo _senha_.<br> 04-Clicar em _Entrar_. <br> 05-Na coluna de opções da esqueda, na tela inicial de Projetos, clicar em _Materiais_ <br> 06-Clicar sobre o ícone **+** no canto superior esquerdo da tela de Materiais. <br> 07- No _Campo 1_ e _Campo 2_, inserir o nome do material e o preço, respectivamete. <br> 08-Clicar em _Cadastrar_. <br> 09-Buscar o material cadastrado na lista de materiais, clicar no ícone _"lápis"_ para editar os dados do material. <br> 10-Alterar o nome do material para outro nome válido e preço, no _Campo 1_ e _Campo 2_, respectivamente. <br> 11- Clicar em _Salvar_. |
|Critério de Êxito | Nome e preço do material é atualziados são exibidos na lista na tela de Materiais. |
|  	|  	|
| **Caso de Teste**	| CT-02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste**	| CT-02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste**	| CT-02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste**	| CT-02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste**	| CT-02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste**	| CT-02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
