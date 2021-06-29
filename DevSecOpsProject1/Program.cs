// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DevSecOpsProject1
{
    using System;

    /// <summary>
    /// Program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main class.
        /// </summary>
        /// <param name="args">args param.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine($"Sum of 2 + 2 = {Arithmetic.Add(2, 2)}");
        }
    }
}
