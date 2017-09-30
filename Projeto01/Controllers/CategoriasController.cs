﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Projeto01.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Projeto01.Controllers
{
    public class CategoriasController : Controller
    {
        private static IList<Categoria> categorias =
            new List<Categoria>()
            {
                new Categoria()
                {
                    CategoriaID = 1,
                    nome = "Notebooks"
                },
                new Categoria()
                {
                    CategoriaID = 2,
                    nome = "Monitores"
                },
                new Categoria()
                {
                    CategoriaID = 3,
                    nome = "Impressoras"
                },
                new Categoria()
                {
                    CategoriaID = 4,
                    nome="Mouses"

                },
                new Categoria()
                {
                    CategoriaID = 5,
                    nome = "Desktops"
                }

            };


        // GET: Categorias
        public ActionResult Index()
        {
            return View(categorias);
        }
        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria categoria)
        {
            categorias.Add(categoria);
            categoria.CategoriaID = categorias.Select(m => m.CategoriaID).Max() + 1;
            return RedirectToAction("Index");
        }
    }
}