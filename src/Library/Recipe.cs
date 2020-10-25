//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Text;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }
        /*
            Decidimos que el metodo PrintRecipe arme el string a imprimir ya que
            la clase Recipe es el experto en la informacion necesaria para esto.
            Si se mantiene la responsabilidad de imprimir en este metodo no se
            cumpliria con el principio SRP, por lo tanto se delega esta accion a
            cualquier clase que implementen el tipo IPrinter.
        */
        public string GetTextToPrint()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                sb.AppendLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }   
            return sb.ToString();
        }
    }
}