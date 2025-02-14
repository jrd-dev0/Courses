
---

# Guia Tutorial de Git e GitHub

Este guia é uma referência prática para aprender e dominar os principais comandos do Git e GitHub, com exemplos detalhados e soluções para problemas comuns.

## Índice
1. [Introdução ao Git e GitHub](#introdução-ao-git-e-github)
2. [Configuração Inicial](#configuração-inicial)
3. [Comandos Básicos](#comandos-básicos)
4. [Trabalhando com Branches](#trabalhando-com-branches)
5. [Gerenciamento de Repositórios Remotos](#gerenciamento-de-repositórios-remotos)
6. [Resolvendo Conflitos](#resolvendo-conflitos)
7. [Git Stash e Rebase](#git-stash-e-rebase)
8. [Tags e Versões](#tags-e-versões)
9. [GitHub: Pull Requests e Issues](#github-pull-requests-e-issues)
10. [Situações de Problemas e Soluções](#situações-de-problemas-e-soluções)

---

## Introdução ao Git e GitHub

### O que é Git?
Git é um sistema de controle de versão distribuído que permite rastrear alterações em arquivos ao longo do tempo. Ele foi criado por Linus Torvalds (criador do Linux) e é amplamente utilizado no desenvolvimento de software.

### O que é GitHub?
GitHub é uma plataforma baseada em nuvem que hospeda repositórios Git e facilita a colaboração entre desenvolvedores. Além disso, oferece recursos como pull requests, issues e wikis.

---

## Configuração Inicial

### Configurando o nome e e-mail
```bash
# Define o nome do usuário globalmente
git config --global user.name "Seu Nome"

# Define o e-mail do usuário globalmente
git config --global user.email "seuemail@example.com"
```

**Comentário:** Essas configurações são usadas para identificar quem fez as alterações no repositório.

### Verificando as configurações
```bash
# Exibe todas as configurações atuais
git config --list
```

### Alterando a configuração local de um repositório
```bash
# Define o nome apenas para o repositório atual
git config user.name "Nome Local"
```

---

## Comandos Básicos

### Iniciando um repositório
```bash
# Inicia um novo repositório Git na pasta atual
git init
```

**Comentário:** Cria um diretório `.git` oculto que contém todos os metadados do repositório.

### Clonando um repositório
```bash
# Clona um repositório remoto para sua máquina local
git clone https://github.com/usuario/repositorio.git
```

### Verificando o status
```bash
# Mostra o estado atual do repositório (alterações, commits pendentes, etc.)
git status
```

### Adicionando arquivos ao staging area
```bash
# Adiciona um arquivo específico ao staging area
git add arquivo.txt

# Adiciona todos os arquivos modificados ao staging area
git add .
```

### Commitando alterações
```bash
# Cria um commit com uma mensagem descritiva
git commit -m "Adiciona funcionalidade X"
```

### Visualizando o histórico de commits
```bash
# Mostra o histórico de commits
git log

# Mostra o histórico de forma compacta
git log --oneline
```

### Desfazendo alterações
```bash
# Remove um arquivo do staging area, mas mantém as alterações locais
git reset arquivo.txt

# Descarta alterações locais em um arquivo
git checkout -- arquivo.txt
```

---

## Trabalhando com Branches

### Criando uma nova branch
```bash
# Cria uma nova branch chamada "feature-x"
git branch feature-x
```

### Alternando entre branches
```bash
# Alterna para a branch "feature-x"
git checkout feature-x

# Ou use o comando moderno (Git 2.23+)
git switch feature-x
```

### Mesclando branches
```bash
# Mescla a branch "feature-x" na branch atual
git merge feature-x
```

### Excluindo uma branch
```bash
# Exclui a branch "feature-x"
git branch -d feature-x
```

### Listando branches
```bash
# Lista todas as branches locais
git branch

# Lista todas as branches remotas
git branch -r
```

---

## Gerenciamento de Repositórios Remotos

### Adicionando um repositório remoto
```bash
# Adiciona um repositório remoto com o nome "origin"
git remote add origin https://github.com/usuario/repositorio.git
```

### Enviando alterações para o repositório remoto
```bash
# Envia as alterações da branch atual para o repositório remoto
git push origin main
```

### Baixando alterações do repositório remoto
```bash
# Atualiza o repositório local com as alterações do remoto
git pull origin main
```

### Verificando repositórios remotos
```bash
# Lista todos os repositórios remotos configurados
git remote -v
```

---

## Resolvendo Conflitos

### Identificando conflitos
Quando duas pessoas editam o mesmo trecho de código e tentam mesclar suas alterações, o Git pode gerar um conflito.

Exemplo de conflito:
```plaintext
<<<<<<< HEAD
console.log("Versão local");
=======
console.log("Versão remota");
>>>>>>> main
```

### Resolvendo conflitos manualmente
1. Abra o arquivo conflitante.
2. Edite o código para resolver o conflito.
3. Adicione o arquivo resolvido ao staging area:
   ```bash
   git add arquivo_conflito.txt
   ```
4. Finalize o merge:
   ```bash
   git commit -m "Resolve conflito no arquivo X"
   ```

---

## Git Stash e Rebase

### Usando `git stash`
O comando `git stash` é usado para salvar temporariamente alterações não commitadas.

```bash
# Salva as alterações atuais no stash
git stash

# Aplica as alterações salvas no stash
git stash apply

# Lista todos os stashes salvos
git stash list

# Remove o último stash
git stash drop
```

### Usando `git rebase`
O `rebase` é usado para aplicar commits de uma branch em outra, criando um histórico linear.

```bash
# Rebase da branch "feature-x" para "main"
git checkout feature-x
git rebase main
```

---

## Tags e Versões

### Criando tags
As tags são usadas para marcar versões específicas do projeto.

```bash
# Cria uma tag leve
git tag v1.0.0

# Cria uma tag anotada
git tag -a v1.0.0 -m "Versão 1.0.0"
```

### Enviando tags para o repositório remoto
```bash
# Envia todas as tags para o repositório remoto
git push origin --tags
```

---

## GitHub: Pull Requests e Issues

### Criando um Pull Request
1. Faça suas alterações em uma branch separada.
2. Envie a branch para o repositório remoto:
   ```bash
   git push origin feature-x
   ```
3. No GitHub, vá para a página do repositório e clique em "Compare & pull request".

### Trabalhando com Issues
Issues são usadas para rastrear bugs, tarefas ou melhorias no projeto. Você pode criar, atribuir e comentar em issues diretamente no GitHub.

---

## Situações de Problemas e Soluções

### Problema: Perdi minhas alterações locais durante um `pull`
**Causa:** O Git não consegue fazer o merge automaticamente e sobrescreve suas alterações.

**Solução:**
1. Use o comando abaixo para verificar se há alterações perdidas:
   ```bash
   git reflog
   ```
2. Restaure o commit ou estado desejado:
   ```bash
   git reset --hard HEAD@{número}
   ```

---

### Problema: Erro ao enviar alterações (`push`)
**Mensagem de erro:** `! [rejected] main -> main (non-fast-forward)`

**Causa:** O repositório remoto tem commits que não estão no seu repositório local.

**Solução:**
1. Atualize seu repositório local:
   ```bash
   git pull origin main
   ```
2. Resolva possíveis conflitos e envie novamente:
   ```bash
   git push origin main
   ```

---

### Problema: Arquivo ignorado pelo `.gitignore` ainda aparece no repositório
**Causa:** O arquivo já foi rastreado pelo Git antes de ser adicionado ao `.gitignore`.

**Solução:**
1. Remova o arquivo do cache:
   ```bash
   git rm --cached arquivo_ignorado.txt
   ```
2. Faça um novo commit:
   ```bash
   git commit -m "Remove arquivo ignorado do cache"
   ```

---

### Problema: Como reverter um commit específico?
**Solução:**
1. Use o comando abaixo para reverter um commit:
   ```bash
   git revert <hash-do-commit>
   ```
2. Isso cria um novo commit que desfaz as alterações do commit especificado.

---
