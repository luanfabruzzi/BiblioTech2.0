# 📚 BiblioTech 2.0

**Sistema de Gestão Bibliotecária Full-Stack**  
Gestão completa de livros, usuários e empréstimos com **Clean Architecture** + React + TypeScript

![.NET](https://img.shields.io/badge/.NET-8.0-blue?style=for-the-badge&logo=dotnet)
![React](https://img.shields.io/badge/React-19.0-61DAFB?style=for-the-badge&logo=react)
![TypeScript](https://img.shields.io/badge/TypeScript-5.0-3178C6?style=for-the-badge&logo=typescript)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-16-4169E1?style=for-the-badge&logo=postgresql)
![Clean Architecture](https://img.shields.io/badge/Architecture-Clean-FF6B6B?style=for-the-badge)

---

## ✨ Funcionalidades

- ✅ Cadastro, busca e gestão de livros (até 5.000 itens)
- ✅ Sistema completo de empréstimos e devoluções
- ✅ Autenticação JWT + autorização
- ✅ Dashboard moderno com React + TanStack Query
- ✅ Busca avançada e filtros
- ✅ Deploy gratuito (Railway + Vercel)
- ✅ Documentação automática com Swagger

## 🛠 Tecnologias

**Backend**  
- .NET 8 + Minimal APIs  
- Entity Framework Core + PostgreSQL  
- Clean Architecture (Domain / Application / Infrastructure / Api)  
- JWT + FluentValidation + AutoMapper + Swagger

**Frontend**  
- React 19 + TypeScript + Vite  
- TanStack Query + React Router + React Hook Form + Zod  
- Tailwind CSS + Lucide Icons

**Banco**  
- PostgreSQL (Supabase ou Neon)

**Deploy**  
- Backend: Railway  
- Frontend: Vercel

## 🏗 Arquitetura

Usamos **Clean Architecture** (camadas independentes):

<grok-card data-id="c4c411" data-type="image_card" data-plain-type="render_searched_image"  data-arg-image_id="FDZRi"  data-arg-size="LARGE" ></grok-card>


<grok-card data-id="ae4a4a" data-type="image_card" data-plain-type="render_searched_image"  data-arg-image_id="2ZhwN"  data-arg-size="LARGE" ></grok-card>


**Fluxo**:  
`Api → Application → Domain ← Infrastructure`

## 📸 Screenshots (em breve – já vai ficar assim)

<grok-card data-id="10ff3a" data-type="image_card" data-plain-type="render_searched_image"  data-arg-image_id="PdbSt"  data-arg-size="LARGE" ></grok-card>


<grok-card data-id="e0d97f" data-type="image_card" data-plain-type="render_searched_image"  data-arg-image_id="qKM4G"  data-arg-size="LARGE" ></grok-card>


## 🚀 Como Rodar Localmente

1. Clone o repositório
2. Backend:
   ```powershell
   cd backend
   dotnet run --project src/BiblioTech.Api