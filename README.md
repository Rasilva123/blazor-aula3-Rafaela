# Atividade Aula 3 – Componentes Reutilizáveis em Blazor

O FormProduto não adiciona o produto diretamente na lista porque sua responsabilidade é apenas realizar o cadastro e validar os dados.

Quem adiciona o produto é a página Produtos.razor, que é responsável por controlar a lista.

O formulário avisa a página utilizando EventCallback<Produto>, enviando o produto cadastrado.

Assim, cada componente possui sua própria responsabilidade e pode ser reutilizado em outras páginas.
