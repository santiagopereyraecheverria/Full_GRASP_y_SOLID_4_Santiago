//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CatalogManager.PopulateCatalogs();

            Recipe recipe = new Recipe();
            recipe.FinalProduct = CatalogManager.GetProduct("Café con leche");
            recipe.AddStep(CatalogManager.GetProduct("Café"), 100, CatalogManager.GetEquipment("Cafetera"), 120);
            recipe.AddStep(CatalogManager.GetProduct("Leche"), 200, CatalogManager.GetEquipment("Hervidor"), 60);

            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);
        }
    }
}
